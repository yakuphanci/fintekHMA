using System;
using System.Windows.Forms;




namespace taslakOdev
{
    public partial class Form_Kaydol : Form
    {
        #region Form Create
        public Form_Kaydol()
        {
            InitializeComponent();
        }
        #endregion


        #region İleri Geri islemleri
        ///Bir sonraki kayıt ekranını açar.
        private void button_kayitDevam_Click(object sender, EventArgs e)
        {
            if (Validasyon.IsValidNickName(textBox_kullaniciAdi.Text) &&
                Validasyon.IsValidEmail(textBox_ePosta.Text) &&
                Validasyon.IsValidPassword(textBox_parola.Text, textBox_reParola.Text))
            {
                panel_kayitFirst.Visible = false;
                panel_kayitSecond.Visible = true;
                textBox_isim.Focus();
            };

        }

     
        ///Bir önceki kayıt ekranını açar.
        private void button_kayitGeri_Click(object sender, EventArgs e)
        {
            panel_kayitSecond.Visible = false;
            panel_kayitFirst.Visible = true;
            textBox_kullaniciAdi.Focus();            
        }
        #endregion


        #region Kontrol islemleri
        ///Kaydın tamamlanması için gerekli sorgular.
        bool valid_KayitTamamla()
        {
           return
                Validasyon.IsValidName(textBox_isim.Text) &&
                Validasyon.IsValidName(textBox_soyisim.Text) &&
                Validasyon.IsValidTCKNO(textBox_tckNo.Text) &&
                Validasyon.IsValidAdres(textBox_adres.Text) &&
                Validasyon.IsValidTelNum(textBox_telefonNo.Text);
        }

        ///Kullanıcı adının kayıtlarda olup olmadıgına bakar.
        private bool checkUserNickName( Kullanici yeniKullanici)
        {
            //Daha önceden kullanıcı adı ile kaydolup olunmadığını kontrol ediyor.
            var eslesenKullanici = Veriler.GetKullanici(yeniKullanici.KullaniciAdi);

            bool evveldenVarmi = (eslesenKullanici != null);
            return evveldenVarmi;
        }
        #endregion


        #region Girilen Bilgileri kullanarak yeni Kullanıcı nesnesi oluşturma işlemi
        ///Kaydedilecek yeni kulanıcı için kullanıcı tipinde nesne oluştur.
        Kullanici CreateNewKullanici()
        {
            return new Kullanici()
            {
                Adi = textBox_isim.Text,
                Soyadi = textBox_soyisim.Text,
                TCKNo = textBox_tckNo.Text,
                TelefonNum = textBox_telefonNo.Text,
                Adres = textBox_adres.Text,

                KullaniciAdi = textBox_kullaniciAdi.Text,
                EPosta = textBox_ePosta.Text,
                Parola = textBox_parola.Text
            };
        }
        #endregion

 
        #region Kayıt Tamamla İslemi
        ///Kayıt tamamla işlemini yapan buton.
        private void button_kayitTamamla_Click(object sender, EventArgs e)
        {
            if( valid_KayitTamamla() )
            {
                //Veriler okunur kullanici listesi oluşturulur.

                var kullanicilar = Veriler.GetKullanicilar();

                //TextBoxdaki verilerle yeni bir kullanıcı nesnesi oluşturur.
                var yeniKullanici = CreateNewKullanici();


                //TextBoxdaki verilerden yeni bir kullanıcı oluşturuldugunda
                //bu kullanıcının daha önceden kayıtlı olup olmadıgını kontrol eder.
                bool evveldenVarmi = checkUserNickName(yeniKullanici);
                if ( !evveldenVarmi )
                {
                    kullanicilar.Add(yeniKullanici);
                    Mesajlar.Basarili();
                    this.Close();
                }
                else
                {
                    Mesajlar.UyariMesaji(
                        "Bu kullanıcı adı zaten kullanılıyor. Lütfen başka bir kullanıcı adı ile kayıt olmayı deneyin",
                        "Talihsizlik!");
                    ///Kullanıcı adını başkası aldıysa, kullanıcı adına odakla.
                    #region Kullanıcı Adına odaklan
                    button_kayitGeri.PerformClick();
                    textBox_kullaniciAdi.SelectAll();
                    textBox_kullaniciAdi.Focus();
                    #endregion
               
                }

                //güncellenen kullanıcı listesi dosyaya kaydedilir.
                Veriler.SaveData(kullanicilar);

            }

        }
        #endregion


        #region Tum TextBoxlar doluysa butonu aktif etme islemleri

        ///Kullanıcı kayıt formunun ilk safhası için,
        ///Tüm textboxların dolu olup olmadığına bakar. Ve devam butonunu aktif eder.
        private void textBoxes_IsAllNotEmpity_First(object sender, EventArgs e)
        {
            if (textBox_kullaniciAdi.Text.Length > 0 &&
                    textBox_ePosta.Text.Length > 0 &&
                    textBox_parola.Text.Length > 0 &&
                    textBox_reParola.Text.Length > 0  )
            {
                button_kayitDevam.Enabled = true;
            }
            else
            {
                button_kayitDevam.Enabled = false;
            }
        }


        ///Kullanıcı kayıt formunun ikinci safhası için,
        ///Tüm textboxların dolu olup olmadığına bakar. Ve butonları aktif eder.
        private void textBoxes_IsAllNotEmpity_Second(object sender, EventArgs e)
        {
            if (textBox_isim.Text.Length > 0 &&
                    textBox_soyisim.Text.Length > 0 &&
                    textBox_tckNo.Text.Length > 0 &&
                    textBox_telefonNo.Text.Length > 0 &&
                    textBox_adres.Text.Length > 0)
            {
                button_kayitTamamla.Enabled = true;
            }
            else
            {
                button_kayitTamamla.Enabled = false;
            }
        }

        #endregion

     
    }


}
