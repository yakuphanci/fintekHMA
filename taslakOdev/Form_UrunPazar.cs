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
    public partial class Form_UrunPazar : Form
    {
        int g_kategoriPazarID;
        public Form_UrunPazar(int kategoriID)
        {
            InitializeComponent();
            this.g_kategoriPazarID = kategoriID;
        }

        private void PazarUrun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SATIN ALINMAYA TEŞEBBÜS EDİNDİM saticim: ["+((Panel)(sender)).Tag+"]");
        }

        Panel PazarUrunOlustur(SatilanUrun PazarUrun)
        {


            //Ürün Kategori Kontainer Paneli
            Panel urunContainer = new Panel();
            urunContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            urunContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            urunContainer.Location = new System.Drawing.Point(3, 3);
            urunContainer.Size = new System.Drawing.Size(264, 130);
            urunContainer.Click += new System.EventHandler(PazarUrun_Click);
            urunContainer.Tag = PazarUrun.saticiID;

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
            urunAdi.Text = PazarUrun.urun.urunAdi;

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
            urunMiktarValue.Text = PazarUrun.miktar.ToString();


            //en dusuk fiyat tittle
            Label urunFiyatTittle = new Label();
            urunFiyatTittle.AutoSize = true;
            urunFiyatTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunFiyatTittle.Location = new System.Drawing.Point(130, 73);
            urunFiyatTittle.Size = new System.Drawing.Size(53, 16);
            urunFiyatTittle.TabIndex = 4;
            urunFiyatTittle.Text = "EDF(₺):";


            //en dusuk fiyat value
            Label urunFiyatValue = new Label();
            urunFiyatValue.AutoSize = true;
            urunFiyatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunFiyatValue.Location = new System.Drawing.Point(206, 74);
            urunFiyatValue.Size = new System.Drawing.Size(36, 16);
            urunFiyatValue.TabIndex = 5;
            urunFiyatValue.Text = PazarUrun.fiyat.ToString();

            //Ekleme işlemleri
            urunContainer.Controls.Add(urunResmi);
            urunContainer.Controls.Add(urunAdi);
            urunContainer.Controls.Add(urunMiktarTittle);
            urunContainer.Controls.Add(urunMiktarValue);
            urunContainer.Controls.Add(urunFiyatTittle);
            urunContainer.Controls.Add(urunFiyatValue);

            return urunContainer;
        }


        void PazarListele()
        {

            string json_kayitliSatilanUrunler = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var kayitliSatilanUrunler = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_kayitliSatilanUrunler);

            //Satışa sunulan tüm ürünlerden gösterime onaylananlar ayıklandı.
            var onayliSatilanUrunler = from su in kayitliSatilanUrunler
                                       where su.pazardaMi == true 
                                       && su.urun.urunID == this.g_kategoriPazarID
                                       orderby su.fiyat ascending
                                       select su;





            foreach (var satilanUrun in onayliSatilanUrunler)
            {
                flowLayoutPanel1.Controls.Add(PazarUrunOlustur(satilanUrun));
            
            }



        }

        private void Form_UrunPazar_Load(object sender, EventArgs e)
        {
            PazarListele();
        }
    }
}
