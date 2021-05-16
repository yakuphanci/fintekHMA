using System;
using System.Drawing;
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
            var pazarlar = Veriler.GetSatilanUrunler();

            //onaylanacak ürünü ayrıştırdık
            var tiklananPazar = Veriler.GetPazar(tiklananPazarID, pazarlar);
            //onayı verdik
            tiklananPazar.pazardaMi = true;
            //tarihi yayınlanma tarihi olarak güncelledik.
            tiklananPazar.tarih = DateTime.Now;

            //Güncellenen veriyi geri kaydettik.
            Veriler.SaveData(pazarlar);
        }

        #endregion



        #region Beklemedeki Urun Satisi Taleplerini Listeleme islemleri

        #region Pazar Nesnesi Olusturma  
        ///Pazar nesnelerini oluşturur.
        Panel Get_PazarNesnesi(SatilanUrun pazar, object Tag, Color BGColor)
        {
            uint pazarID = pazar.pazarID;
            string urunAdi = pazar.urun.Adi;
            string satici = pazar.saticiID;
            double fiyat = pazar.fiyat;
            int miktar = pazar.miktar;
            DateTime tarih = pazar.tarih;
            //urunResim varsayılan deger atandı. 
            Bitmap urunResmi = global::taslakOdev.Properties.Resources.patates1;
           
            //Kapsayici olusuyor.
            Panel pazarNesnesi = GorselNesneOlustur.Pazar.Container(BGColor);
            pazarNesnesi.Tag = Tag;
            pazarNesnesi.Cursor = Cursors.Hand;
            GorselNesneOlustur.Ekle_ClickEvent(pazarNesnesi, onayBekleyenUrun_Click);

            //Bilesenleri ekliyoruz.
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.Image(urunResmi));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunAdi(urunAdi));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunMiktar_Tittle("kg"));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunMiktar_Value(miktar));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunFiyat_Tittle("kg"));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunFiyat_Value(fiyat, "₺"));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarSahibi_Tittle());
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarSahibi_Value(satici));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarTarihi_Tittle());
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarTarihi_Value(tarih));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarID_Tittle());
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarID_Value(pazarID));

            return pazarNesnesi;
        }
        #endregion


        ///Satılan Ürün Listesinde pazara çıkmak için onay bekleyen ürünleri listeler.
        void BekleyenPazarUrunleriListele()
        {

            var beklemedekiUrunler = Veriler.GetPasifPazarlar();
            
            flowLayoutPanel_bekleyenUrunler.Controls.Clear();
            foreach (var satilanUrun in beklemedekiUrunler)
            {
                Panel pazarNesnesi = Get_PazarNesnesi(satilanUrun, satilanUrun.pazarID, Renkler.BGVarsayilan);
                flowLayoutPanel_bekleyenUrunler.Controls.Add(pazarNesnesi);
            }

        }
       
        #endregion



        //***********************/
      


        #region Beklemedeki Bakiye Islemleri 


        #region Bakiye Islem Nesnesi Olusturma

        
        Panel Get_BekleyenBakiyeIslemNesnesi(BakiyeIslemObject islemNesnesi, object Tag)
        {
            //Gerekli olan parametreler asagida kullanilmak uzere gecici degiskenelre alindi.
            bool reddedildiMi = islemNesnesi.reddedildiMi;
            DateTime islemTarihi = islemNesnesi.islemTarihi;
            double miktar = islemNesnesi.degisiklikMiktari;
            string aciklama = islemNesnesi.aciklama;


            //Container
            Color BGColor = reddedildiMi ? Renkler.BGKirmizi : Renkler.BGVarsayilan;
            Panel islemContainer = GorselNesneOlustur.BakiyeIslem.Container(BGColor);
            islemContainer.Tag = Tag;

            //İşlem Tarihi
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Tittle());
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Value(islemTarihi));

            //İşlem Açıklama
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.Aciklama(aciklama));

            //İşlem Miktar
            Color FRColor = (miktar < 0) ? Renkler.Kirmizi : Renkler.Yesil;
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemMiktari(miktar.ToString(), "₺", FRColor));


            //Tıklanma özelliği ekledik.
            GorselNesneOlustur.Ekle_ClickEvent(islemContainer, BakiyeIslemNesnesi_Click);
            islemContainer.Cursor = Cursors.Hand;

            return islemContainer;
        }

        #endregion


        #region Bakiye Islemleri Listeleme Islemi
        void Listele_OnayBekleyenBakiyeIslemleri()
        {
            //kullanicinin bekleyen islemlerini ayıklayıp tarihe(islem) göre sıraladık. (En son en başa.)
            var bekleyenIslemler = Veriler.GetBekleyenBakiyeIslemleri();

            flowLayoutPanel_bekleyenIslemler.Controls.Clear();
            foreach (var bekleyenIslem in bekleyenIslemler)
            {
                //islem Nesnesine gerekli parametreleri verip olusturduk.
                var islemNesne = Get_BekleyenBakiyeIslemNesnesi(bekleyenIslem, bekleyenIslem.ID);

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
            var bakiyeIslemleri = Veriler.GetBakiyeIslemleri();

            //üzerinde işlem yapılacak bakiye işlemi ayıklandı.
            var islem = Veriler.GetBakiyeIslemi(onaylanacakIslemID, bakiyeIslemleri);
           
            islem.incelendiMi = true;

            //şartlar sağlanıyorsa değişiklik işlemini gerçekleştir.
            if ( !islem.IslemiIsle(izinverildiMi) )
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
            Veriler.SaveData(bakiyeIslemleri);

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
