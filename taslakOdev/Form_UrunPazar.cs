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
            this.Text = "Aktif \'" + this.g_kategori.Adi + "\' Pazarları"; 
            PazarListele();
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

            var onayliSatilanUrunler = Veriler.GetAktifPazarlar(this.g_kategori.ID);

            flowLayoutPanel_pazarlar.Controls.Clear();
            foreach (var satilanUrun in onayliSatilanUrunler)
            {
                bool kendiPazariMi = (satilanUrun.saticiID == this.g_aktifKullanici.KullaniciAdi);
                Panel urunPazarNesnesi = Get_PazarNesnesi(satilanUrun, satilanUrun.pazarID, kendiPazariMi);
                
                flowLayoutPanel_pazarlar.Controls.Add(urunPazarNesnesi);
            }

        }

      

    }
}
