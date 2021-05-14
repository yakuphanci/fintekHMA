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
            int tiklananKategoriID = (int)((Panel)(sender)).Tag;
            Form_UrunPazar frm_UrunPazar = new Form_UrunPazar(this.g_aktifKullanici, tiklananKategoriID);
            frm_UrunPazar.ShowDialog();
        }
        #endregion


        #region Kategori Nesnesi Olusturma ve Listeleme islemleri
        /// <summary>
        /// Kategori Pazar verilerinin goruntulenecegi nesneyi olusturur.
        /// </summary>
        /// <param name="kategoriPazar">Verileri okuyacagi KategoriPazar nesnesi</param>
        /// <returns></returns>
        Panel PazarKategoriOlustur(KategoriPazar kategoriPazar)
        {


            //Ürün Kategori Kontainer Paneli
            Panel urunContainer = new Panel();
            urunContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            urunContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            urunContainer.Location = new System.Drawing.Point(3, 3);
            urunContainer.Size = new System.Drawing.Size(558, 130);
            urunContainer.Click += new System.EventHandler(urunKategori_Click);
            urunContainer.Tag = kategoriPazar.urun.urunID;

            //Urun Fotografi
            PictureBox urunResmi = new PictureBox();
            urunResmi.Image = global::taslakOdev.Properties.Resources.patates1;
            urunResmi.Location = new System.Drawing.Point(3, 3);
            urunResmi.Size = new System.Drawing.Size(120, 120);
            urunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            urunResmi.TabIndex = 0;
            urunResmi.TabStop = false;


            //Ürün Adı
            Label urunAdi = new Label();
            urunAdi.AutoSize = true;
            urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            urunAdi.Location = new System.Drawing.Point(129, 12);
            urunAdi.Size = new System.Drawing.Size(73, 20);
            urunAdi.TabIndex = 1;
            urunAdi.Text = kategoriPazar.urun.urunAdi;

            //urunMiktar Tittle
            Label urunMiktarTittle = new Label();
            urunMiktarTittle.AutoSize = true;
            urunMiktarTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunMiktarTittle.Location = new System.Drawing.Point(130, 43);
            urunMiktarTittle.Size = new System.Drawing.Size(70, 16);
            urunMiktarTittle.TabIndex = 2;
            urunMiktarTittle.Text = "Miktar (kg)";

            //urunMiktar Value
            Label urunMiktarValue = new Label();
            urunMiktarValue.AutoSize = true;
            urunMiktarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunMiktarValue.Location = new System.Drawing.Point(206, 44);
            urunMiktarValue.Size = new System.Drawing.Size(40, 16);
            urunMiktarValue.TabIndex = 3;
            urunMiktarValue.Text = kategoriPazar.toplamMiktar.ToString();


            //en dusuk fiyat tittle
            Label urunEnDusukFiyatTittle = new Label();
            urunEnDusukFiyatTittle.AutoSize = true;
            urunEnDusukFiyatTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunEnDusukFiyatTittle.Location = new System.Drawing.Point(130, 73);
            urunEnDusukFiyatTittle.Size = new System.Drawing.Size(53, 16);
            urunEnDusukFiyatTittle.TabIndex = 4;
            urunEnDusukFiyatTittle.Text = "EDF(₺):";


            //en dusuk fiyat value
            Label urunEnDusukFiyatValue = new Label();
            urunEnDusukFiyatValue.AutoSize = true;
            urunEnDusukFiyatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunEnDusukFiyatValue.Location = new System.Drawing.Point(206, 74);
            urunEnDusukFiyatValue.Size = new System.Drawing.Size(36, 16);
            urunEnDusukFiyatValue.TabIndex = 5;
            urunEnDusukFiyatValue.Text = kategoriPazar.enDusukFiyat.ToString();

            // 
            // kategoriIDTittle
            // 
            Label kategoriIDTittle = new Label();
            kategoriIDTittle.AutoSize = true;
            kategoriIDTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            kategoriIDTittle.Location = new System.Drawing.Point(433, 107);
            kategoriIDTittle.Size = new System.Drawing.Size(77, 16);
            kategoriIDTittle.TabIndex = 10;
            kategoriIDTittle.Text = "Kategori ID:";
            // 
            // kategoriIDValue
            // 
            Label kategoriIDValue = new Label();
            kategoriIDValue.AutoSize = true;
            kategoriIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            kategoriIDValue.Location = new System.Drawing.Point(516, 107);
            kategoriIDValue.Size = new System.Drawing.Size(16, 16);
            kategoriIDValue.TabIndex = 11;
            kategoriIDValue.Text = kategoriPazar.urun.urunID.ToString();



            //Ekleme işlemleri
            urunContainer.Controls.Add(urunResmi);
            urunContainer.Controls.Add(urunAdi);
            urunContainer.Controls.Add(urunMiktarTittle);
            urunContainer.Controls.Add(urunMiktarValue);
            urunContainer.Controls.Add(urunEnDusukFiyatTittle);
            urunContainer.Controls.Add(urunEnDusukFiyatValue);
            urunContainer.Controls.Add(kategoriIDTittle);
            urunContainer.Controls.Add(kategoriIDValue);

            return urunContainer;
        }
        #endregion


        #region Satılan Urunleri kategorile ve listele.
        /// <summary>
        /// Onaylanmis satilan urunlerdeki urunleri gruplandirir ve kategori olarak listeleme islemini yapar.
        /// </summary>
        void KategoriListele()
        {
            //güncel verileri yüklemeden önce paneli temizle.
            flowLayoutPanel_kategoriler.Controls.Clear();
            var kayitliSatilanUrunler = GetSatilanUrunler();

            //Satışa sunulan tüm ürünlerden gösterime onaylananlar ayıklandı.
            var onayliSatilanUrunler = from su in kayitliSatilanUrunler
                                       where su.pazardaMi == true
                                       orderby su.urun.urunAdi ascending
                                       select su;

            //satışa açılmış ürünler kategorilerine göre gruplandı.
            var kategorilenmisSatilanUrunler = from su in onayliSatilanUrunler
                                               group su by su.urun.urunID;

            foreach (var kategoriGroup in kategorilenmisSatilanUrunler)
            {
                var kategori = new KategoriPazar();

                //Mevcut kategorideki en düşük fiyatlı ürünü hesapladık.
                var fiyataGoreSiralanmisUrunler = (from u in kategoriGroup
                                                   orderby u.fiyat ascending
                                                   select u).ToList();

                foreach (var satilanUrun in fiyataGoreSiralanmisUrunler)
                {
                    //Her kategorideki satışta olan ürünlerin miktarları toplanır.
                    kategori.toplamMiktar += satilanUrun.miktar;
                }

                //Hesaplanan EDF kaydedildi.
                kategori.enDusukFiyat = fiyataGoreSiralanmisUrunler[0].fiyat;
                //Hangi ürünün kategorisi oldugu kaydedildi.
                kategori.urun = fiyataGoreSiralanmisUrunler[0].urun;

                //Kategoriler listelendi.                                                                                                                                                                                                                                                                                                                                                                                                                                  
                flowLayoutPanel_kategoriler.Controls.Add(PazarKategoriOlustur(kategori));
            }

        }
        #endregion


        List<SatilanUrun> GetSatilanUrunler()
        {
            string json_kayitliSatilanUrunler = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var kayitliSatilanUrunler = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_kayitliSatilanUrunler);

            return kayitliSatilanUrunler;
        }

        List<Kullanici> GetKullanicilar()
        {
            var json_kullanicilar = JsonController.GetJsonFromFile(@"kullanicilar.json");
            var kullanicilar = JsonController.GetDataFromJSON<List<Kullanici>>(json_kullanicilar);

            return kullanicilar;
        }



        #region Yenileme Islemi
        private void KullaniciBilgileriniYenile()
        {
            var kullanicilar = GetKullanicilar();
            var kullanici = (from k in kullanicilar
                             where k.KullaniciAdi == this.g_aktifKullanici.KullaniciAdi
                             select k).ToList()[0];
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
