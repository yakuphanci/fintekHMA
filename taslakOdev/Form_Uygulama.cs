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
        Form_Main g_frm_main;
        Kullanici g_aktifKullanici;
        bool g_bGuvenliCikis = false;
        public Form_Uygulama(Form_Main _frm_main, object _aktifKullanici)
        {
            InitializeComponent();
            this.g_frm_main = _frm_main;
            this.g_aktifKullanici = (Kullanici)_aktifKullanici;
            
            //Giriş kontrol taslak.
            //if (g_aktifKullanici.yetki == Yetki.Admin)
               // ADMIN ISE BUNLARI YAP
        }


      



        private void urunKategori_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ay, Tıklandım! Kategori ID: [" + ((Panel)(sender)).Tag + "]");
            Form_UrunPazar frm_UrunPazar = new Form_UrunPazar((int)((Panel)(sender)).Tag);
            frm_UrunPazar.Show();
        }

        #region IVIR ZIVIR 
        private void Form_Uygulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!g_bGuvenliCikis)
                Application.Exit();
        }

        private void label_bakiye_Click(object sender, EventArgs e)
        {
            label_bakiye.Text = "1532165 ₺";
        }

        private void guvenliCikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g_bGuvenliCikis = true;
            g_frm_main.Show();
            this.Close();
        }
        #endregion


        Panel PazarKategoriOlustur(KategoriPazar kategoriPazar)
        {


            //Ürün Kategori Kontainer Paneli
            Panel urunContainer = new Panel();
            urunContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            urunContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            urunContainer.Location = new System.Drawing.Point(3, 3);
            urunContainer.Size = new System.Drawing.Size(264, 130);
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

            //Ekleme işlemleri
            urunContainer.Controls.Add(urunResmi);
            urunContainer.Controls.Add(urunAdi);
            urunContainer.Controls.Add(urunMiktarTittle);
            urunContainer.Controls.Add(urunMiktarValue);
            urunContainer.Controls.Add(urunEnDusukFiyatTittle);
            urunContainer.Controls.Add(urunEnDusukFiyatValue);

            return urunContainer;
        }


        void KategoriListele()
        {

            string json_kayitliSatilanUrunler = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var kayitliSatilanUrunler = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_kayitliSatilanUrunler);

            //Satışa sunulan tüm ürünlerden gösterime onaylananlar ayıklandı.
            var onayliSatilanUrunler = from su in kayitliSatilanUrunler
                                       where su.pazardaMi == true
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
                flowLayoutPanel1.Controls.Add(PazarKategoriOlustur(kategori));
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            KategoriListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var satilanUruns = new List<SatilanUrun>();
            var urunler = JsonController.GetDataFromJSON<List<Urun>>(JsonController.GetJsonFromFile(@"urunler.json"));
            for(int i = 0; i < 10; i++)
            {
                var satilanUrun = new SatilanUrun();
                satilanUrun.urun = urunler[i % urunler.Count];
                satilanUrun.fiyat = (i + 1) * (0.8);
                satilanUrun.EkleMiktar(((i + 1) * (17)));
                satilanUrun.saticiID = g_aktifKullanici.KullaniciAdi;
                satilanUruns.Add(satilanUrun);
            }

            JsonController.SaveJsonToFile(@"SatilanUrunler.json", satilanUruns);
        }
    }
}
