using System;
using System.Drawing;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_Profil : Form
    {
        #region Form Create && aktif kullanıcı tutucu
        Kullanici g_aktifKullanici;
        public Form_Profil(Kullanici aktifKullanici)
        {
            InitializeComponent();
            this.g_aktifKullanici = aktifKullanici;
            TumunuYenile();
        }
        #endregion


        #region Pazar Nesnesi Olusturma  
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
            Panel pazarNesnesi = GorselNesneOlustur.Pazar.Container(BGColor);

            //Bilesenleri ekliyoruz.
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.Image(urunResmi) );
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunAdi(urunAdi) );
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunMiktar_Tittle("kg") );
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunMiktar_Value(miktar) );
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunFiyat_Tittle("kg") );
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunFiyat_Value(fiyat,"₺"));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarSahibi_Tittle() );
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarSahibi_Value(satici));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarTarihi_Tittle());
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarTarihi_Value(tarih));
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarID_Tittle() );
            pazarNesnesi.Controls.Add(GorselNesneOlustur.Pazar.PazarID_Value(pazarID));

            //Kaldırma butonu
            var kaldirmaButonu = GorselNesneOlustur.Pazar.CrossButton(Renkler.KoyuGri);
            kaldirmaButonu.Cursor = Cursors.Hand;
            kaldirmaButonu.Tag = Tag;
            GorselNesneOlustur.Ekle_ClickEvent(kaldirmaButonu, btn_yayindanKaldir_Click);
            
            pazarNesnesi.Controls.Add(kaldirmaButonu);
            return pazarNesnesi;
        }
        #endregion

        
        #region Yayindan Kaldırma Islemleri
        private void btn_yayindanKaldir_Click(object sender, EventArgs e)
        {
            //Yayından kaldırılmak istenen ürün pazarının ID'sini çektik
            uint tiklananPazarID = (uint)((Button)sender).Tag;

            //Onaylayıp onaylamadığını sorduk.
            DialogResult onaySorgu = new DialogResult();
            onaySorgu = MessageBox.Show(" [ " + tiklananPazarID + " ] Pazar numaralı ürünü sistemden kaldırmak istiyor musunuz?", "Pazar Onaylama", MessageBoxButtons.YesNo);

            //Onayladıysa veriyi güncelledik.
            if (onaySorgu == DialogResult.Yes)
            {
                SistemdenKaldir(tiklananPazarID);
                Mesajlar.Basarili();//Başarılı mesajı.
                
                //Listeyi yeniledik.
                TumunuYenile();
            }

           
        }

        private void SistemdenKaldir(uint tiklananPazarID)
        {
            var sistemdeSatilanUrunler = Veriler.GetSatilanUrunler();
            var kaldirilacakPazar = Veriler.GetPazar(tiklananPazarID, sistemdeSatilanUrunler);
         
            sistemdeSatilanUrunler.Remove(kaldirilacakPazar);
           
            Veriler.SaveData(sistemdeSatilanUrunler);
        }
        #endregion

        
        #region Listeleme Fonksiyonları
        void yayindakiUrunlerListele()
        { 
            //Pazara çıkması onaylanmış ve yayına alınmış ürünler filtreler/sıralar.
            var yayindakiUrunler = Veriler.GetKullaniciAktifPazarlari(this.g_aktifKullanici.KullaniciAdi);

            flowLayoutPanel_yayindakiUrunler.Controls.Clear();
            foreach (var satilanUrun in yayindakiUrunler)
            {
                Panel pazarNesnesi = Get_PazarNesnesi(satilanUrun, satilanUrun.pazarID,Renkler.BGVarsayilan);
                flowLayoutPanel_yayindakiUrunler.Controls.Add(pazarNesnesi);
            }
        }

        void beklemedekiUrunlerListele()
        {
            //Henüz pazara çıkmayı bekleyen, onaylanmamış ürünleri filtreler/sıralar.
            var beklemedekiUrunler = Veriler.GetKullaniciPasifPazarlari(this.g_aktifKullanici.KullaniciAdi);

            flowLayoutPanel_beklemedekiUrunler.Controls.Clear();
            foreach (var satilanUrun in beklemedekiUrunler)
            {
                Panel pazarNesnesi = Get_PazarNesnesi(satilanUrun, satilanUrun.pazarID, Renkler.BGVarsayilan);
                flowLayoutPanel_beklemedekiUrunler.Controls.Add(pazarNesnesi);
            }
        }
        #endregion


        #region Yeni Urun Ekle Butonu Tıklama Olayı
        /// <summary>
        /// Urun Ekleme Butonu Tıklama Olayı.
        /// Kullanıcının Eklenebilir ürün kategorilerinden ürün seçip yükleyebileceği pencere açılır.
        /// </summary>
        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            Form_UrunEkle frm_UrunEkle = new Form_UrunEkle(this.g_aktifKullanici.KullaniciAdi);
            frm_UrunEkle.ShowDialog();
            button_yenile.PerformClick();
        }
        #endregion


        #region Yenileme İslemleri
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
            beklemedekiUrunlerListele();
            yayindakiUrunlerListele();
            BakiyeYenile();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            TumunuYenile();
        }
        #endregion


        #region Bekleyenler/Yayındakiler listesi görünüm geçiş buton olayları
        
        #region Show/Hide Panels
        void Show_Panel(object sender)
        {
            ((Panel)sender).Visible = true;
        }

        void Hide_Panel(object sender)
        {
            ((Panel)sender).Visible = false;
        }
        #endregion

        #region aktive/deAktive Buttons
        void aktive_Button(object sender)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
            ((Button)sender).Cursor = Cursors.Default;
        }
        void deAktive_Button(object sender)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
            ((Button)sender).Cursor = Cursors.Hand;

        }
        #endregion

        private void button_satistakiUrunler_Click(object sender, EventArgs e)
        {
            //Tıkladığımız butonun tasarımını seçilmiş gibi yaptık.
            aktive_Button(sender);

            //Beklemedeki ürünler butonunu seçilmemiş gibi gösterdik.
            deAktive_Button(button_bekleyenUrunler);

            //Beklemedeki ürünleri gizledik.
            Hide_Panel(flowLayoutPanel_beklemedekiUrunler);

            //Satıştaki ürünleri gösterdik.
            Show_Panel(flowLayoutPanel_yayindakiUrunler);

        }

        private void button_bekleyenUrunler_Click(object sender, EventArgs e)
        {
            //Tıkladığımız butonun tasarımını seçilmiş gibi yaptık.
            aktive_Button(sender);

            //Satıştaki ürünler butonunu seçilmemiş gibi gösterdik.
            deAktive_Button(button_satistakiUrunler);

            //Satıştaki ürünleri gizledik.
            Hide_Panel(flowLayoutPanel_yayindakiUrunler);

            //Beklemedeki ürünleri gösterdik.
            Show_Panel(flowLayoutPanel_beklemedekiUrunler);

        }

        #endregion


        #region Bakiye Islemleri Butonu Tıklama Olayı
        private void button_bakiyeIslemleri_Click(object sender, EventArgs e)
        {
            Form_BakiyeIslem frm_bakiyeIslem = new Form_BakiyeIslem(this.g_aktifKullanici);
            frm_bakiyeIslem.ShowDialog();
            //işlem yapıldıktan sonra bakiye bilgisini yeniden çek.
            TumunuYenile();
        }
        #endregion
        
    }
}
