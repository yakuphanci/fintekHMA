using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_Uygulama : Form
    {
        #region Form Create & Form_Main tutucu, aktifKullanici Tutucu
        public Form_Main g_frm_main;
        Kullanici g_aktifKullanici;
        bool g_bGuvenliCikis = false;
        public Form_Uygulama(Form_Main _frm_main, object _aktifKullanici)
        {
            InitializeComponent();
            this.g_frm_main = _frm_main;
            this.g_aktifKullanici = (Kullanici)_aktifKullanici;
            
            hesapToolStripMenuItem.Text = this.g_aktifKullanici.KullaniciAdi;
            TumunuYenile();
        }
        #endregion


        #region Listedeki Kategoriye tiklama olayı
        private void urunKategori_Click(object sender, EventArgs e)
        {
            uint tiklananKategoriID = (uint)((Panel)(sender)).Tag;
            Form_UrunPazar frm_UrunPazar = new Form_UrunPazar(this.g_aktifKullanici, tiklananKategoriID);
            frm_UrunPazar.ShowDialog();
        }
        #endregion



        #region Kategori Nesnesi Olusturma  
        /// <summary>
        /// Kategori Pazar verilerinin goruntulenecegi nesneyi olusturur.
        /// </summary>
        /// <param name="kategoriPazar">Verileri okuyacagi KategoriPazar nesnesi</param>
        /// <returns></returns>
        Panel Get_KategoriNesnesi(KategoriPazar kategoriPazar)
        {
            uint kategoriID = kategoriPazar.urun.ID;
            string urunAdi = kategoriPazar.urun.Adi;
            double enDusukFiyat = kategoriPazar.enDusukFiyat;
            int toplamMiktar = kategoriPazar.toplamMiktar;
        
            //urunResim varsayılan deger atandı. 
            Bitmap urunResmi = global::taslakOdev.Properties.Resources.patates1;

            Panel kategoriNesnesi = GorselNesneOlustur.Pazar.Container(Renkler.BGVarsayilan);
            kategoriNesnesi.Tag = kategoriID;
      
            kategoriNesnesi.Cursor = Cursors.Hand;
            GorselNesneOlustur.Ekle_ClickEvent(kategoriNesnesi, urunKategori_Click);

            //Bilesenleri ekliyoruz.
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.Image(urunResmi));
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunAdi(urunAdi));
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunMiktar_Tittle("kg"));
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.UrunMiktar_Value(toplamMiktar));
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.EnDusukFiyat_Tittle("kg/₺"));
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.EnDusukFiyat_Value(enDusukFiyat, "₺"));
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.KategoriID_Tittle());
            kategoriNesnesi.Controls.Add(GorselNesneOlustur.Pazar.KategoriID_Value(kategoriID));


            return kategoriNesnesi;
        }
        #endregion


        #region Satılan Urunleri kategorile ve listele.
        /// <summary>
        /// Onaylanmis satilan urunlerdeki urunleri gruplandirir ve kategori olarak listeleme islemini yapar.
        /// </summary>
        void KategoriListele()
        {
           
            
            var onayliSatilanUrunler = Veriler.GetAktifPazarlar();

            //satışa açılmış ürünler kategorilerine göre gruplandı.
            var kategorilenmisSatilanUrunler = from su in onayliSatilanUrunler
                                               group su by su.urun.ID;


            //güncel verileri yüklemeden önce paneli temizle.
            flowLayoutPanel_kategoriler.Controls.Clear();
            foreach (var kategoriGroup in kategorilenmisSatilanUrunler)
            {
                var kategori = new KategoriPazar();

                //Mevcut kategorideki en düşük fiyatlı ürünü hesapladık.
                var fiyataGoreSiralanmisUrunler = (from u in kategoriGroup
                                                   orderby u.fiyat ascending
                                                   select u).ToList();
               
                //Her kategorideki satışta olan ürünlerin miktarları toplanır.
                foreach (var satilanUrun in fiyataGoreSiralanmisUrunler)
                {
                    kategori.toplamMiktar += satilanUrun.miktar;
                }

                //Hesaplanan EDF kaydedildi.
                kategori.enDusukFiyat = fiyataGoreSiralanmisUrunler[0].fiyat;
                //Hangi ürünün kategorisi oldugu kaydedildi.
                kategori.urun = fiyataGoreSiralanmisUrunler[0].urun;
                
                Panel kategoriNesnesi = Get_KategoriNesnesi(kategori);
                
                //Kategoriler listelendi.                                                                                                                                                                                                                                                                                                                                                                                                                                  
                flowLayoutPanel_kategoriler.Controls.Add(kategoriNesnesi);
            }

        }
        #endregion



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
            KategoriListele();
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
            TumunuYenile();
        }
        #endregion


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


        #region Bakiye Islemleri Butonu Tıklama Olayı.
        ///<summary>
        ///Bakiye İşlem penceresini açar.
        ///</summary>
        private void button_bakiyeIslemleri_Click(object sender, EventArgs e)
        {
            Form_BakiyeIslem frm_bakiyeIslem = new Form_BakiyeIslem(this.g_aktifKullanici);
            frm_bakiyeIslem.ShowDialog();
            TumunuYenile();
        }
        #endregion

       
        #region Cikis islemleri 
        private void Form_Uygulama_FormClosing(object sender, FormClosingEventArgs e)
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
