using System;
using System.Drawing;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_UrunPazar : Form
    {
        #region Form Create && KategoriID, Aktif Kullanıcı tutucu
        Urun g_kategori;
        Kullanici g_aktifKullanici;
        public Form_UrunPazar(Kullanici aktifKullanici, uint kategoriID)
        {
            InitializeComponent();
            this.g_kategori = UrunBilgiCek(kategoriID);
            this.g_aktifKullanici = aktifKullanici;
            this.Text = "Aktif \"" + this.g_kategori.Adi + "\" Pazarları"; 
            this.groupBox_pazarlar.Text ="\"" + this.g_kategori.Adi + "\" Pazarları";
            TumunuYenile();
        }

        Urun UrunBilgiCek(uint kategoriID)
        {
            var urun = Veriler.GetUrunTuru(kategoriID);
            return urun;
        }

        #endregion

        #region Pazar Nesnesi Tiklanma Olayi
        private void PazarUrun_Click(object sender, EventArgs e)
        {
            Mesajlar.SadeMesaj(
                "Şuanlık sadece bilgilendirme amaçlı görüntüleyebilirsiniz.\n" +
                "Satın almak için satın alma emri geçmeniz gerekmektedir."
                , "Seçmece Yok!");
        }
        #endregion

        #region Pazar Nesnesi Olusturma  
        Panel Get_PazarNesnesi(SatilanUrun pazar, object Tag, bool kendiPazariMi)
        {
            uint pazarID = pazar.pazarID;
            string urunAdi = pazar.urun.Adi;
            string satici = pazar.saticiID;
            double fiyat = pazar.fiyat;
            int miktar = pazar.miktar;
            DateTime tarih = pazar.tarih;

            //urunResim varsayılan deger atandı. 
            Bitmap urunResmi = global::taslakOdev.Properties.Resources.patates1;
            
            Color pazarColor = kendiPazariMi ? Renkler.AcikGri : Renkler.BGVarsayilan;
            Panel pazarNesnesi = GorselNesneOlustur.Pazar.Container(pazarColor);
            pazarNesnesi.Tag = Tag;
           
            if(!kendiPazariMi)
            {
                pazarNesnesi.Cursor = Cursors.Hand;
                GorselNesneOlustur.Ekle_ClickEvent(pazarNesnesi, PazarUrun_Click);
            }
     

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

       
        //Mevcut kategorideki tüm pazar ürünlerini listeler
        void PazarListele()
        {
           
            flowLayoutPanel_pazarlar.Controls.Clear();
            var onayliSatilanUrunler = Veriler.GetUcuzAktifPazarlar(this.g_kategori.ID);

            flowLayoutPanel_pazarlar.Controls.Clear();
            foreach (var satilanUrun in onayliSatilanUrunler)
            {
                bool kendiPazariMi = (satilanUrun.saticiID == this.g_aktifKullanici.KullaniciAdi);
                Panel urunPazarNesnesi = Get_PazarNesnesi(satilanUrun, satilanUrun.pazarID, kendiPazariMi);
                
                flowLayoutPanel_pazarlar.Controls.Add(urunPazarNesnesi);
            }

        }


        #region Yenileme Islemi
        private void KullaniciBilgileriniYenile()
        {
            var kullanici = Veriler.GetKullanici(this.g_aktifKullanici.KullaniciAdi);
            this.g_aktifKullanici = kullanici;
        }

        void BakiyeYenile()
        {
            this.label_bakiye.Text = this.g_aktifKullanici.Bakiye + " ₺";
        }

        void TumunuYenile()
        {
            KullaniciBilgileriniYenile();
            PazarListele();
            BakiyeYenile();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumunuYenile();
        }
        #endregion

        #region Kullanici(Satici)nin kendi urunlerini yonetecegi formu acma islemi
        /// <summary>
        /// Kullanicinin (Satici) kendi urunlerini yonetebilecegi FormEkranini acar
        /// </summary>
        private void button_kullaniciPazari_Click(object sender, EventArgs e)
        {
            Form_Profil frm_profil = new Form_Profil(this.g_aktifKullanici);
            frm_profil.ShowDialog();
        }
        #endregion
              
        #region Bakiye Islemleri Butonu Tıklama Olayı.
        ///<summary>
        ///Bakiye İşlem penceresini açar.
        ///</summary>
        private void button_bakiyeIslemleri_Click(object sender, EventArgs e)
        {
            Form_BakiyeIslem frm_bakiyeIslem = new Form_BakiyeIslem(this.g_aktifKullanici);
            frm_bakiyeIslem.ShowDialog();
            KullaniciBilgileriniYenile();
            BakiyeYenile();
       
        }
        #endregion

        #region Alis Emri Butonu Tıklama Olayı.
        private void button_alisEmri_Click(object sender, EventArgs e)
        {
            Form_AlisEmri frm_alisEmri = new Form_AlisEmri(this.g_aktifKullanici);
            frm_alisEmri.ShowDialog();
            KullaniciBilgileriniYenile();
            BakiyeYenile();
        }
        #endregion
   
    }
}
