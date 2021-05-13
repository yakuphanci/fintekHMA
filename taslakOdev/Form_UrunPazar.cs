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
        Kullanici g_aktifKullanici;
        public Form_UrunPazar(Kullanici aktifKullanici, int kategoriID)
        {
            InitializeComponent();
            this.g_kategoriPazarID = kategoriID;
            this.g_aktifKullanici = aktifKullanici;
            PazarListele();
        }

        private void PazarUrun_Click(object sender, EventArgs e)
        {
            Mesajlar.SadeMesaj(
                "Şuanlık sadece bilgilendirme amaçlı görüntüleyebilirsiniz.\n" +
                "Satın almak için satın alma emri geçmeniz gerekmektedir."
                , "Seçmece Yok!");
        }


        Panel PazarUrunOlustur(SatilanUrun PazarUrun)
        {


            //Ürün Kontainer Paneli
            Panel urunContainer = new Panel();
            urunContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            urunContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            urunContainer.Location = new System.Drawing.Point(5, 5);
            urunContainer.Size = new System.Drawing.Size(560, 130);
            urunContainer.Tag = PazarUrun.pazarID;
            urunContainer.Click += new System.EventHandler(PazarUrun_Click);

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
            urunAdi.Text = PazarUrun.urun.urunAdi;

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
            urunMiktarValue.Text = PazarUrun.miktar.ToString();


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
            urunFiyatValue.Text = PazarUrun.fiyat.ToString();

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
            urunSaticiValue.Text = PazarUrun.saticiID;


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
            pazarTarihValue.Text = PazarUrun.tarih.ToString("dd/MM/yyyy");

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



            return urunContainer;
        }

        Color AcikGri()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
        }
       
        //Mevcut kategorideki tüm pazar ürünlerini listeler
        void PazarListele()
        {
            flowLayoutPanel1.Controls.Clear();
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
                Panel urunPazarNesnesi = (PazarUrunOlustur(satilanUrun));
                //Eğer bu listeye eklenecek ürün kullanıcıya aitse, 
                //diğerlerinden ayır. (ve tıklyamasın)
                if (satilanUrun.saticiID == this.g_aktifKullanici.KullaniciAdi)
                {
                    urunPazarNesnesi.BackColor = this.AcikGri();
                    urunPazarNesnesi.Cursor = Cursors.No;
                    urunPazarNesnesi.Click -= new System.EventHandler(PazarUrun_Click);
                }
                flowLayoutPanel1.Controls.Add(urunPazarNesnesi);
            }



        }

      
    }
}
