using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace taslakOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        //Bir sonraki kayıt ekranını açar.
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

     
        //Bir önceki kayıt ekranını açar.
        private void button_kayitGeri_Click(object sender, EventArgs e)
        {
            panel_kayitSecond.Visible = false;
            panel_kayitFirst.Visible = true;
            textBox_kullaniciAdi.Focus();            
        }


        bool KayitTamamla_valid()
        {
            return
                Validasyon.IsValidName(textBox_isim.Text) &&
                Validasyon.IsValidName(textBox_soyisim.Text) &&
                Validasyon.IsValidTCKNO(textBox_tckNo.Text) &&
                Validasyon.IsValidAdres(textBox_adres.Text) &&
                Validasyon.IsValidTelNum(textBox_telefonNo.Text);
        }

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

        //Kayıt tamamla işlemini yapan buton.
        private void button_kayitTamamla_Click(object sender, EventArgs e)
        {
            if( KayitTamamla_valid() )
            {
                //Veriler okunur kullanici listesi oluşturulur.
                var json_kullanicilar = GetJsonFromFile(@"kullanicilar.json");
                var kullanicilar = GetDataFromJSON<List<Kullanici>>(json_kullanicilar);

                //TextBoxdaki verilerle yeni bir kullanıcı nesnesi oluşturur.
                var yeniKullanici = CreateNewKullanici();


                //TextBoxdaki verilerden yeni bir kullanıcı oluşturuldugunda
                //bu kullanıcının daha önceden kayıtlı olup olmadıgını kontrol eder.
                bool evveldenVarmi = checkUserNickName(kullanicilar, yeniKullanici);


                if ( !evveldenVarmi )
                    kullanicilar.Add(yeniKullanici);
                else
                    MessageBox.Show("Bu kullanıcı adı daha önceden kayıtlanmış.", "HOOP HEMŞEHRM NREYE!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

                
                //güncellenen kullanıcı listesi dosyaya kaydedilir.
                SaveJsonToFile(@"kullanicilar.json", kullanicilar);

            }

        }

       
        private static bool checkUserNickName(List<Kullanici> kullanicilar, Kullanici yeniKullanici)
        {
            //Daha önceden kullanıcı adı ile kaydolup olunmadığını kontrol ediyor.
            var eslesenKullanicilar = (from k in kullanicilar
                                       where k.KullaniciAdi == yeniKullanici.KullaniciAdi
                                       select k).ToList();

            bool evveldenVarmi = (eslesenKullanicilar.Count > 0);
            return evveldenVarmi;
        }


        //Parametre olarak aldığı nesneyi json formatına çevirir ve parametre olarak aldığı konuma kaydeder.
        void SaveJsonToFile(string filePath, object data )
        {
            File.WriteAllText( filePath, ConvertToJSON(data) ); 
        }


        //Dosya konumu parametre olarak gönderilen JSON veriyi geri döndürür.
        string GetJsonFromFile(string filePath)
        {
            try
            {
                //Konumdan dosyayı okur.
                string json = File.ReadAllText(filePath);
                //veriyi geri döndürür.
                return json;
            }
            catch (Exception)
            {

                return string.Empty;
            }
            
        }


        //JSON veriyi istenilen formata çevirip geri döndürür.
        T GetDataFromJSON<T>(string JSON) where T :  new()
        {
            //Parametre olarak gönderilen JSON verisini belirtilen T tipine çevirir. 
            //Eğer JSON verisi NULLsa belitilen T tipinde obje oluşturulup geri döndürülür.
            var data = (T)(JsonConvert.DeserializeObject(JSON, typeof(T)) ?? new T() );
            return data;
        }


        //Bir objeyi JSON formatında geri döndürür.
        string ConvertToJSON(object kullanicilar)
        {
            return JsonConvert.SerializeObject(kullanicilar);
        }



        //Kullanıcı kayıt formunun ilk safhası için,
        //Tüm textboxların dolu olup olmadığına bakar. Ve devam butonunu aktif eder.
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

        //Kullanıcı kayıt formunun ikinci safhası için,
        //Tüm textboxların dolu olup olmadığına bakar. Ve butonları aktif eder.
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

    
    }

    
}
