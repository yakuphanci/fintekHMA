using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_AdminPanel : Form
    {

        #region Form Create & Form_Main tutucu, aktifKullanici tutucusu
        public Form_Main g_frm_main;
        Kullanici g_aktifKullanici;
        bool g_bGuvenliCikis = false;
        public Form_AdminPanel(Form_Main _frm_main, object _aktifKullanici)
        {
            InitializeComponent();
            this.g_frm_main = _frm_main;
            this.g_aktifKullanici = (Kullanici)_aktifKullanici;
            hesapToolStripMenuItem.Text = this.g_aktifKullanici.KullaniciAdi;
            TumunuYenile();
        }
        #endregion


        #region Sayfa Yenileme
        //Yenileme click olayı ya da (F5)
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumunuYenile();
        }
        void TumunuYenile()
        {
            BekleyenPazarUrunleriListele();
            Listele_OnayBekleyenBakiyeIslemleri();
        }
        #endregion


        /************************/

        List<SatilanUrun> GetSatilanUrunlerFromFile()
        {
            var json_pazarlar = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var pazarlar = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_pazarlar);
            return pazarlar;
        }

        #region Bekleyen Urun Onaylama Islemleri
      
        //Onay Bekleyen Pazar Ürünleri Tıklama Olayı
        public void onayBekleyenUrun_Click(object sender, EventArgs e)
        {
            //Onaylanmak için tıklanan pazarın ID sini çektik.
            uint tiklananPazarID = (uint)((Panel)sender).Tag;

            //Onaylayıp onaylamadığını sorduk.
            DialogResult onaySorgu = new DialogResult();
            onaySorgu =  MessageBox.Show(" [ "+ tiklananPazarID + " ] Pazar numaralı ürün satış talebini onaylıyor musunuz?", "Pazar Onaylama", MessageBoxButtons.YesNo);
           
            //Onayladıysa veriyi güncelledik.
            if(onaySorgu == DialogResult.Yes)
            {
                PazardakiUrunOnayla(tiklananPazarID);
                Mesajlar.Basarili();//Başarılı mesajı.
            }
            BekleyenPazarUrunleriListele();
        }

        //Onay Bekleyen Urun Pazarını onayla.
        void PazardakiUrunOnayla(uint tiklananPazarID)
        {
            //pazardaki ürünleri çektik
            var pazarlar = GetSatilanUrunlerFromFile();
            
            //onaylanacak ürünü ayrıştırdık
            var tiklananPazar = (from pz in pazarlar
                                 where pz.pazarID == tiklananPazarID
                                 select pz).ToList()[0];
            //onayı verdik
            tiklananPazar.pazardaMi = true;
            //tarihi yayınlanma tarihi olarak güncelledik.
            tiklananPazar.tarih = DateTime.Now;

            //Güncellenen veriyi geri kaydettik.
            JsonController.SaveJsonToFile(@"SatilanUrunler.json", pazarlar);
            
        }

        #endregion


        #region Beklemedeki Urun Ekleme Taleplerini Listeleme islemleri
        ///Pazar nesnelerini oluşturur.
        Panel PazarUrunOlustur(SatilanUrun pazarUrun)
        {


            //Ürün Kontainer Paneli
            Panel urunContainer = new Panel();
            urunContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            urunContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            urunContainer.Location = new System.Drawing.Point(5, 5);
            urunContainer.Size = new System.Drawing.Size(560, 130);
            urunContainer.Tag = pazarUrun.pazarID;
            urunContainer.Click += new System.EventHandler(onayBekleyenUrun_Click);

            //Urun Fotografi
            PictureBox urunResmi = new PictureBox();
            urunResmi.Image = global::taslakOdev.Properties.Resources.patates1;
            urunResmi.Location = new System.Drawing.Point(5, 5);
            urunResmi.Size = new System.Drawing.Size(120, 120);
            urunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            urunResmi.TabStop = false;


            //Ürün Adı
            Label urunAdi = new Label();
            urunAdi.AutoSize = true;
            urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            urunAdi.Location = new System.Drawing.Point(129, 12);
            urunAdi.Size = new System.Drawing.Size(61, 20);
            urunAdi.Text = pazarUrun.urun.urunAdi;

            //urunMiktar Tittle
            Label urunMiktarTittle = new Label();
            urunMiktarTittle.AutoSize = true;
            urunMiktarTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunMiktarTittle.Location = new System.Drawing.Point(130, 43);
            urunMiktarTittle.Size = new System.Drawing.Size(70, 16);
            urunMiktarTittle.Text = "Miktar (kg)";

            //urunMiktar Value
            Label urunMiktarValue = new Label();
            urunMiktarValue.AutoSize = true;
            urunMiktarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunMiktarValue.Location = new System.Drawing.Point(206, 44);
            urunMiktarValue.Size = new System.Drawing.Size(40, 16);
            urunMiktarValue.Text = pazarUrun.miktar.ToString();


            //fiyat tittle
            Label urunFiyatTittle = new Label();
            urunFiyatTittle.AutoSize = true;
            urunFiyatTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunFiyatTittle.Location = new System.Drawing.Point(130, 68);
            urunFiyatTittle.Size = new System.Drawing.Size(52, 16);
            urunFiyatTittle.Text = "Fiyat(₺)";


            //fiyat value
            Label urunFiyatValue = new Label();
            urunFiyatValue.AutoSize = true;
            urunFiyatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunFiyatValue.Location = new System.Drawing.Point(206, 68);
            urunFiyatValue.Size = new System.Drawing.Size(36, 16);
            urunFiyatValue.Text = pazarUrun.fiyat.ToString();

            // satici tittle
            Label urunSaticiTittle = new Label();
            urunSaticiTittle.AutoSize = true;
            urunSaticiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunSaticiTittle.Location = new System.Drawing.Point(130, 91);
            urunSaticiTittle.Size = new System.Drawing.Size(44, 16);
            urunSaticiTittle.Text = "Satıcı:";

            // satici value
            Label urunSaticiValue = new Label();
            urunSaticiValue.AutoSize = true;
            urunSaticiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunSaticiValue.Location = new System.Drawing.Point(206, 91);
            urunSaticiValue.Size = new System.Drawing.Size(74, 16);
            urunSaticiValue.Text = pazarUrun.saticiID;


            // 
            // label_tarihTittle
            // 
            Label pazarTarihTittle = new Label();
            pazarTarihTittle.AutoSize = true;
            pazarTarihTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            pazarTarihTittle.Location = new System.Drawing.Point(427, 109);
            pazarTarihTittle.Size = new System.Drawing.Size(42, 16);
            pazarTarihTittle.TabIndex = 8;
            pazarTarihTittle.Text = "Tarih:";

            // 
            // label_tarihValue
            // 
            Label pazarTarihValue = new Label();
            pazarTarihValue.AutoSize = true;
            pazarTarihValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            pazarTarihValue.Location = new System.Drawing.Point(472, 109);
            pazarTarihValue.Size = new System.Drawing.Size(80, 16);
            pazarTarihValue.TabIndex = 9;
            pazarTarihValue.Text = pazarUrun.tarih.ToString("dd/MM/yyyy");

            // 
            // label_pazarIDTittle
            // 
            Label pazarIDTittle = new Label();
            pazarIDTittle.AutoSize = true;
            pazarIDTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            pazarIDTittle.Location = new System.Drawing.Point(407, 91);
            pazarIDTittle.Size = new System.Drawing.Size(62, 16);
            pazarIDTittle.TabIndex = 10;
            pazarIDTittle.Text = "Pazar ID:";


            // 
            // label_pazarIDValue
            // 
            Label pazarIDValue = new Label();
            pazarIDValue.AutoSize = true;
            pazarIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            pazarIDValue.Location = new System.Drawing.Point(472, 91);
            pazarIDValue.Size = new System.Drawing.Size(32, 16);
            pazarIDValue.TabIndex = 11;
            pazarIDValue.Text = pazarUrun.pazarID.ToString();



            //Ekleme işlemleri
            urunContainer.Controls.Add(urunResmi);
            urunContainer.Controls.Add(urunAdi);
            urunContainer.Controls.Add(urunMiktarTittle);
            urunContainer.Controls.Add(urunMiktarValue);
            urunContainer.Controls.Add(urunFiyatTittle);
            urunContainer.Controls.Add(urunFiyatValue);
            urunContainer.Controls.Add(urunSaticiTittle);
            urunContainer.Controls.Add(urunSaticiValue);
            urunContainer.Controls.Add(pazarTarihValue);
            urunContainer.Controls.Add(pazarTarihTittle);
            urunContainer.Controls.Add(pazarIDTittle);
            urunContainer.Controls.Add(pazarIDValue);



            return urunContainer;
        }

        ///Satılan Ürün Listesinde pazara çıkmak için onay bekleyen ürünleri listeler.
        void BekleyenPazarUrunleriListele()
        {
            flowLayoutPanel_bekleyenUrunler.Controls.Clear();

            string json_kayitliSatilanUrunler = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var kayitliSatilanUrunler = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_kayitliSatilanUrunler);

            //Pazara çıkması onaylanmamış ürünler
            var beklemedekiUrunler = from su in kayitliSatilanUrunler
                                     where su.pazardaMi == false
                                     orderby su.tarih ascending
                                     select su;

            foreach (var satilanUrun in beklemedekiUrunler)
            {
                flowLayoutPanel_bekleyenUrunler.Controls.Add(PazarUrunOlustur(satilanUrun));
            }

        }
        #endregion



        //***********************/
        #region RENKLER
        Color Yesil()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }
        Color Kirmizi()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        }

        Color BGVarsayilan()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
        }
        Color BGKirmizi()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
        }
        #endregion


        /// <summary>
        /// Bakiye İşlemlerinin tutulduğu dosyadan bakiye işlemlerini çeker.
        /// </summary>
        /// <returns>Bir BakiyeKontrol türünde liste döndürür.</returns>
        List<BakiyeIslemObject> GetBakiyeIslemlerFromFile()
        {
            var json_bakiyeIslemler = JsonController.GetJsonFromFile(@"bakiyeIslemler.json");
            var bakiyeIslemler = JsonController.GetDataFromJSON<List<BakiyeIslemObject>>(json_bakiyeIslemler);

            return bakiyeIslemler;
        }

        #region Beklemedeki Bakiye Islemleri 

        #region Bakiye Islem Nesnesi Olusturma
       
        #region Islem Nesnesi Bilesenleri
        Panel Get_BakiyeIslemContainer(Color BGColor, object Tag)
        {
            // 
            // bakiyeIslemContainer
            // 
            var bakiyeIslemContainer = new Panel();
            bakiyeIslemContainer.BackColor = BGColor;
            bakiyeIslemContainer.Location = new System.Drawing.Point(3, 3);
            bakiyeIslemContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            bakiyeIslemContainer.Size = new System.Drawing.Size(355, 100);
            bakiyeIslemContainer.Tag = Tag;
            return bakiyeIslemContainer;


        }

        Label Get_tarihAyrac()
        {
            // 
            // lbl_tarihAyrac
            // 
            var lbl_tarihAyrac = new Label();
            lbl_tarihAyrac.AutoSize = true;
            lbl_tarihAyrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            lbl_tarihAyrac.Location = new System.Drawing.Point(149, 11);
            lbl_tarihAyrac.Size = new System.Drawing.Size(10, 13);
            lbl_tarihAyrac.Text = "-";
            return lbl_tarihAyrac;
        }

        Label Get_gerceklesmeTarihiTittle()
        {
            // 
            // lbl_gerceklesmeTarihiTittle
            // 
            var lbl_gerceklesmeTarihiTittle = new Label();
            lbl_gerceklesmeTarihiTittle.AutoSize = true;
            lbl_gerceklesmeTarihiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            lbl_gerceklesmeTarihiTittle.Location = new System.Drawing.Point(165, 11);
            lbl_gerceklesmeTarihiTittle.Size = new System.Drawing.Size(97, 13);
            lbl_gerceklesmeTarihiTittle.Text = "Gerçekleşme Tarihi:";
            return lbl_gerceklesmeTarihiTittle;
        }

        Label Get_gerceklesmeTarihiValue(DateTime tarih)
        {
            // 
            // lbl_gerceklesmeTarihiValue
            // ***tarih
            var lbl_gerceklesmeTarihiValue = new Label();
            lbl_gerceklesmeTarihiValue.AutoSize = true;
            lbl_gerceklesmeTarihiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbl_gerceklesmeTarihiValue.Location = new System.Drawing.Point(267, 11);
            lbl_gerceklesmeTarihiValue.Size = new System.Drawing.Size(69, 13);
            lbl_gerceklesmeTarihiValue.Text = tarih.ToString("dd MMM yyyy");
            return lbl_gerceklesmeTarihiValue;
        }

        Label Get_islemTarihiTittle()
        {
            // 
            // lbl_islemTarihiTittle
            // 
            var lbl_islemTarihiTittle = new Label();
            lbl_islemTarihiTittle.AutoSize = true;
            lbl_islemTarihiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            lbl_islemTarihiTittle.Location = new System.Drawing.Point(12, 11);
            lbl_islemTarihiTittle.Size = new System.Drawing.Size(61, 13);
            lbl_islemTarihiTittle.Text = "İşlem Tarihi:";
            return lbl_islemTarihiTittle;

        }

        Label Get_islemTarihiValue(DateTime tarih)
        {
            // 
            // lbl_islemTarihiValue
            // ***tarih
            var lbl_islemTarihiValue = new Label();
            lbl_islemTarihiValue.AutoSize = true;
            lbl_islemTarihiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbl_islemTarihiValue.Location = new System.Drawing.Point(74, 11);
            lbl_islemTarihiValue.Size = new System.Drawing.Size(69, 13);
            lbl_islemTarihiValue.Text = tarih.ToString("dd MMM yyyy");
            return lbl_islemTarihiValue;
        }

        Label Get_islemMiktari(string value, string birim, Color FRColor)
        {
            // 
            // lbl_islemMiktari
            // ***Renk ***miktar
            var lbl_islemMiktari = new Label();
            lbl_islemMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            lbl_islemMiktari.ForeColor = FRColor;
            lbl_islemMiktari.Location = new System.Drawing.Point(181, 74);
            lbl_islemMiktari.Size = new System.Drawing.Size(170, 22);
            lbl_islemMiktari.Text = value + " " + birim;
            lbl_islemMiktari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            return lbl_islemMiktari;
        }

        Label Get_islemAciklama(string value)
        {
            // 
            // lbl_islemAciklama
            // ***aciklama
            var lbl_islemAciklama = new Label();
            lbl_islemAciklama.AutoSize = true;
            lbl_islemAciklama.Location = new System.Drawing.Point(12, 42);
            lbl_islemAciklama.Size = new System.Drawing.Size(148, 18);
            lbl_islemAciklama.Text = value;
            return lbl_islemAciklama;
        }

        Label Get_islemTalepEdenTittle()
        {
            // 
            // label_bakiyeIslemTalepEdenTittle
            // 
            Label talepEdenTittle = new Label();
            talepEdenTittle.AutoSize = true;
            talepEdenTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            talepEdenTittle.Location = new System.Drawing.Point(12, 80);
            talepEdenTittle.Size = new System.Drawing.Size(65, 13);
            talepEdenTittle.Text = "Talep Eden:";
            return talepEdenTittle;
           
        }

        Label Get_islemTalepEdenValue(string value)
        {
            // 
            // label_bakiyeIslemTalepEdenValue
            // 
            Label talepEdenValue = new Label();
            talepEdenValue.AutoSize = true;
            talepEdenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            talepEdenValue.Location = new System.Drawing.Point(74, 80);
            talepEdenValue.Size = new System.Drawing.Size(58, 13);
            talepEdenValue.Text = value;
            return talepEdenValue;
        }

        Label Get_islemTalepNoValue(uint talepID)
        {
            // 
            //  bakiyeIslemTalepNumValue
            // 
            Label islemTalepNumValue = new Label();
            islemTalepNumValue.AutoSize = true;
            islemTalepNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            islemTalepNumValue.Location = new System.Drawing.Point(74, 65);
            islemTalepNumValue.Size = new System.Drawing.Size(28, 13);
            islemTalepNumValue.Text = talepID.ToString();
            return islemTalepNumValue;
         
        }

        Label Get_islemTalepNoTittle()
        {
            // 
            // bakiyeIslemTalepNumTittle
            // 
            Label islemTalepNumTittle = new Label();
            islemTalepNumTittle.AutoSize = true;
            islemTalepNumTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            islemTalepNumTittle.Location = new System.Drawing.Point(12, 65);
            islemTalepNumTittle.Size = new System.Drawing.Size(62, 13);
            islemTalepNumTittle.Text = "Talep Num:";
            return islemTalepNumTittle;
        }
        #endregion

        //Admin onayı için olan
        Panel Get_BakiyeIslemNesnesi(BakiyeIslemObject islemNesnesi, object Tag)
        {
            //Gerekli olan parametreler asagida kullanilmak uzere gecici degiskenelre alindi.
            DateTime islemTarihi = islemNesnesi.islemTarihi;
            string aciklama = islemNesnesi.aciklama;
            double miktar = islemNesnesi.degisiklikMiktari;                           
            string talepEden = islemNesnesi.kullaniciAdi;
            uint talepID = islemNesnesi.ID;


            //Container
            Panel islemContainer = Get_BakiyeIslemContainer(BGVarsayilan(), Tag);

            //İşlem Tarihi
            islemContainer.Controls.Add(Get_islemTarihiTittle());
            islemContainer.Controls.Add(Get_islemTarihiValue(islemTarihi));


            //İşlem Açıklama
            islemContainer.Controls.Add(Get_islemAciklama(aciklama));

            //İşlem Miktar
            Color FRColor = (miktar < 0) ? Kirmizi() : Yesil(); //Çekme işlemi yaptıysa kırmızı yatırma yaptıysa yeişil.
            islemContainer.Controls.Add(Get_islemMiktari(miktar.ToString(), "₺", FRColor));

            //Talep eden tittle ve talep edenin adını yolladık.
            islemContainer.Controls.Add(Get_islemTalepEdenTittle());
            islemContainer.Controls.Add(Get_islemTalepEdenValue(talepEden));

            //Talep Numarası tittle ve talep numarasını yolladık.
            islemContainer.Controls.Add(Get_islemTalepNoTittle());
            islemContainer.Controls.Add(Get_islemTalepNoValue(talepID));

            //Tıklanma özelliği ekledik.
            AddEvent_Click(islemContainer, BakiyeIslemNesnesi_Click);


            return islemContainer;
        }

        #endregion


        void AddEvent_Click(Panel sender, EventHandler eventHandlerMethod)
        {
            (sender).Cursor = Cursors.Hand;
            (sender).Click += new EventHandler(eventHandlerMethod);
        }


        #region Bakiye Islemleri Listeleme Islemi
        void Listele_OnayBekleyenBakiyeIslemleri()
        {
            var bakiyeIslemler = GetBakiyeIslemlerFromFile();

            //kullanicinin bekleyen islemlerini ayıklayıp tarihe(islem) göre sıraladık. (En son en başa.)
            var bekleyenIslemler = (from bi in bakiyeIslemler
                                    where bi.incelendiMi == false
                                    orderby bi.islemTarihi descending
                                    select bi).ToList();

            flowLayoutPanel_bekleyenIslemler.Controls.Clear();
            foreach (var bekleyenIslem in bekleyenIslemler)
            {

                //islem Nesnesine gerekli parametreleri verip olusturduk.
                var islemNesne = Get_BakiyeIslemNesnesi(bekleyenIslem, bekleyenIslem.ID);

                

                //ekrana yansıttık.
                flowLayoutPanel_bekleyenIslemler.Controls.Add(islemNesne);
            }

        }
        #endregion


        #region Bekleyen Bakiye Islemi Onaylama Islemleri
        //Bakiye Islemi tiklama olayı
        void BakiyeIslemNesnesi_Click(object sender, EventArgs e)
        {
            var islemID = (uint)( ((Panel)(sender)).Tag );
            DialogResult dResult =
                 MessageBox.Show(
                     "[ " + islemID + " ] işlem numaralı bakiye değişiklik işlemini onaylıyorsanız \"Evet\" onaylamıyorsanız \"Hayır\" seçeneğini seçiniz. " +
                     "\n İşlemi iptal etmek için lütfen \"İptal\" seçeneğini seçiniz.",
                     "İşlemi onaylıyor musunuz?",
                     MessageBoxButtons.YesNoCancel);
            if(dResult != DialogResult.Cancel)
            {
                if(dResult == DialogResult.Yes)
                {
                    //Evet dediyse admin, yapılmak istenen işleme izin ver.
                    Incele_BakiyeIslemi(islemID, true);
                }
                else
                {
                    //Hayır dediyse yapılmak istenen işleme izin verme.
                    Incele_BakiyeIslemi(islemID, false);
                 
                }
                Listele_OnayBekleyenBakiyeIslemleri();
            }

          
        }
        
        //Bakiye Islemini Onaylayıp dosyaya kaydetme islemi
        void Incele_BakiyeIslemi(uint onaylanacakIslemID, bool izinverildiMi)
        {
            var bakiyeIslemleri = GetBakiyeIslemlerFromFile();

            //üzerinde işlem yapılacak bakiye işlemi ayıklandı.
            var islem = (from bi in bakiyeIslemleri
                         where bi.ID == onaylanacakIslemID
                         select bi).ToList()[0];
            islem.incelendiMi = true;
            islem.onaylandiMi = izinverildiMi;
            //şartlar sağlanıyorsa değişiklik işlemini gerçekleştir.
       
            if (!islem.degisiklikGerceklestir() && izinverildiMi)
            {
                //admin izin verdi ama değişiklik gerçekleşmediyse bilgilendir.
                Mesajlar.SadeMesaj(
                    "Kullanıcının bakiyesi yetersiz olduğundan işlem gerçekleştirilemedi.",
                    "Kullanıcı Bakiye İşlem talebi gerçekleştirilmedi.");
            
            }
            else
            {
                //kullanıcının yeterli bakiyesi varsa işlem başarılı mesajı ver.
                Mesajlar.Basarili();
            }

            JsonController.SaveJsonToFile(@"bakiyeIslemler.json",bakiyeIslemleri);

        }
        #endregion

        #endregion


        /************************/

        #region Menu Strip Koyu tema ayarı
        private void ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            // menu strip renk ayarı
            ((ToolStripMenuItem)(sender)).ForeColor = Color.Black;
        }

        private void ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            // menu strip renk ayarı
            ((ToolStripMenuItem)(sender)).ForeColor = Color.WhiteSmoke;
        }
        #endregion


        #region Cikis islemleri 
        private void Form_AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!g_bGuvenliCikis)
                Application.Exit();
        }

        private void guvenliCikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g_bGuvenliCikis = true;
            g_frm_main.Show();
            this.Close();
        }
        #endregion

    }
}
