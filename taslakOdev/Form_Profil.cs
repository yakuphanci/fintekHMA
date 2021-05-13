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
    public partial class Form_Profil : Form
    {
        string g_kullaniciAdi;
        public Form_Profil(string kullaniciAdi)
        {
            InitializeComponent();
            this.g_kullaniciAdi = kullaniciAdi;
        }


        Panel PazarUrunOlustur(SatilanUrun pazarUrun)
        {

            //Ürün Kontainer Paneli
            Panel urunContainer = new Panel();
            urunContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            urunContainer.Location = new System.Drawing.Point(5, 5);
            urunContainer.Size = new System.Drawing.Size(560, 130);

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
            // pazarIDValue
            // 
            Label pazarIDValue = new Label();
            pazarIDValue.AutoSize = true;
            pazarIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            pazarIDValue.Location = new System.Drawing.Point(477, 91);
            pazarIDValue.Size = new System.Drawing.Size(32, 16);
            pazarIDValue.TabIndex = 16;
            pazarIDValue.Text = pazarUrun.pazarID.ToString();
            // 
            // pazarIDTittle
            // 
            Label pazarIDTittle = new Label();
            pazarIDTittle.AutoSize = true;
            pazarIDTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            pazarIDTittle.Location = new System.Drawing.Point(412, 91);
            pazarIDTittle.Size = new System.Drawing.Size(62, 16);
            pazarIDTittle.TabIndex = 15;
            pazarIDTittle.Text = "Pazar ID:";
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

         
            //Ekleme işlemleri
            urunContainer.Controls.Add(urunResmi);
            urunContainer.Controls.Add(urunAdi);
            urunContainer.Controls.Add(urunMiktarTittle);
            urunContainer.Controls.Add(urunMiktarValue);
            urunContainer.Controls.Add(urunFiyatTittle);
            urunContainer.Controls.Add(urunFiyatValue);
            urunContainer.Controls.Add(urunSaticiTittle);
            urunContainer.Controls.Add(urunSaticiValue);
            urunContainer.Controls.Add(pazarTarihTittle);
            urunContainer.Controls.Add(pazarTarihValue);
            urunContainer.Controls.Add(pazarIDTittle);
            urunContainer.Controls.Add(pazarIDValue);



            return urunContainer;
        }

        /// <summary>
        /// Satılan urunleri dosyadan okur ve döndürür.
        /// </summary>
        /// <returns>Satılan Urunlerin listesini dondurur.</returns>
        List<SatilanUrun> GetSatilanUrunler()
        {
            string json_kayitliSatilanUrunler = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var kayitliSatilanUrunler = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_kayitliSatilanUrunler);

            return kayitliSatilanUrunler;
        }

        #region Listeleme Fonksiyonları
        void yayindakiUrunlerListele()
        {
            flowLayoutPanel_yayindakiUrunler.Controls.Clear();

            var kayitliSatilanUrunler = GetSatilanUrunler();

            //Pazara çıkması onaylanmış ve yayına alınmış ürünler filtreler/sıralar.
            var yayindakiUrunler = from su in kayitliSatilanUrunler
                                   where su.pazardaMi == true
                                   && su.saticiID == this.g_kullaniciAdi
                                   orderby su.tarih ascending
                                   select su;
          
            foreach (var satilanUrun in yayindakiUrunler)
            {
                flowLayoutPanel_yayindakiUrunler.Controls.Add(PazarUrunOlustur(satilanUrun));
            }

        }

        void beklemedekiUrunlerListele()
        {
            
            flowLayoutPanel_beklemedekiUrunler.Controls.Clear();

            var kayitliSatilanUrunler = GetSatilanUrunler();

            //Henüz pazara çıkmayı bekleyen, onaylanmamış ürünleri filtreler/sıralar.
            var beklemedekiUrunler = from su in kayitliSatilanUrunler
                                       where su.pazardaMi == false
                                       && su.saticiID == this.g_kullaniciAdi
                                       orderby su.tarih ascending
                                       select su;


            foreach (var satilanUrun in beklemedekiUrunler)
            {
                flowLayoutPanel_beklemedekiUrunler.Controls.Add(PazarUrunOlustur(satilanUrun));
            }
        }
        #endregion


        #region Yeni Urun Ekleme Penceresi Acma
        /// <summary>
        /// Urun Ekleme Butonu Tıklama Olayı.
        /// Kullanıcının Eklenebilir ürün kategorilerinden ürün seçip yükleyebileceği pencere açılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            Form_UrunEkle frm_UrunEkle = new Form_UrunEkle(this.g_kullaniciAdi);
            frm_UrunEkle.ShowDialog();
            button_yenile.PerformClick();
        }
        #endregion


        #region Yenileme İslemleri
        private void button_yenile_Click(object sender, EventArgs e)
        {
            beklemedekiUrunlerListele();
            yayindakiUrunlerListele();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beklemedekiUrunlerListele();
            yayindakiUrunlerListele();

        }
        private void Form_UrunSat_Load(object sender, EventArgs e)
        {
            beklemedekiUrunlerListele();
            yayindakiUrunlerListele();

        }
        #endregion


        #region Bekleyenler/Yayındakiler listesi görünüm geçiş buton olayları
        private void button_satistakiUrunler_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_beklemedekiUrunler.Visible = false;
            flowLayoutPanel_yayindakiUrunler.Visible = true;
            button_satistakiUrunler.Enabled = false;
            button_bekleyenUrunler.Enabled = true;
        }

        private void button_bekleyenUrunler_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_yayindakiUrunler.Visible = false;
            flowLayoutPanel_beklemedekiUrunler.Visible = true;
            button_bekleyenUrunler.Enabled = false;
            button_satistakiUrunler.Enabled = true;
        }
        #endregion

       
    }
}
