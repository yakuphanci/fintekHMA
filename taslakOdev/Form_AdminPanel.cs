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
            BekleyenPazarUrunleriListele();
        }
        #endregion


        #region Bekleyen Urun Onaylama Islemleri
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

        void PazardakiUrunOnayla(uint tiklananPazarID)
        {
            //pazardaki ürünleri çektik
            var json_pazarlar = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var pazarlar = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_pazarlar);
            
            //onaylanacak ürünü ayrıştırdık
            var tiklananPazar = (from pz in pazarlar
                                 where pz.pazarID == tiklananPazarID
                                 select pz).ToList()[0];
            //onayı verdik
            tiklananPazar.pazardaMi = true;
            //tarihi yayınlanma tarihi olarak güncelledik.
            tiklananPazar.tarih = DateTime.Now;

            //Güncellenen veriyi geri kaydettik.
            JsonController.SaveJsonToFile(@"SatilanUrunler.json", pazarlar);
            
        }

        #endregion


        #region Beklemedeki Urun Ekleme Taleplerini Listeleme islemleri
        ///Pazar nesnelerini oluşturur.
        Panel PazarUrunOlustur(SatilanUrun pazarUrun)
        {


            //Ürün Kontainer Paneli
            Panel urunContainer = new Panel();
            urunContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            urunContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            urunContainer.Location = new System.Drawing.Point(5, 5);
            urunContainer.Size = new System.Drawing.Size(560, 130);
            urunContainer.Tag = pazarUrun.pazarID;
            urunContainer.Click += new System.EventHandler(onayBekleyenUrun_Click);

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

            // 
            // label_pazarIDTittle
            // 
            Label pazarIDTittle = new Label();
            pazarIDTittle.AutoSize = true;
            pazarIDTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            pazarIDTittle.Location = new System.Drawing.Point(407, 91);
            pazarIDTittle.Size = new System.Drawing.Size(62, 16);
            pazarIDTittle.TabIndex = 10;
            pazarIDTittle.Text = "Pazar ID:";


            // 
            // label_pazarIDValue
            // 
            Label pazarIDValue = new Label();
            pazarIDValue.AutoSize = true;
            pazarIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            pazarIDValue.Location = new System.Drawing.Point(472, 91);
            pazarIDValue.Size = new System.Drawing.Size(32, 16);
            pazarIDValue.TabIndex = 11;
            pazarIDValue.Text = pazarUrun.pazarID.ToString();



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
            urunContainer.Controls.Add(pazarIDTittle);
            urunContainer.Controls.Add(pazarIDValue);



            return urunContainer;
        }

        ///Satılan Ürün Listesinde pazara çıkmak için onay bekleyen ürünleri listeler.
        void BekleyenPazarUrunleriListele()
        {
            flowLayoutPanel_bekleyenUrunler.Controls.Clear();

            string json_kayitliSatilanUrunler = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
            var kayitliSatilanUrunler = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_kayitliSatilanUrunler);

            //Pazara çıkması onaylanmamış ürünler
            var beklemedekiUrunler = from su in kayitliSatilanUrunler
                                     where su.pazardaMi == false
                                     orderby su.tarih ascending
                                     select su;

            foreach (var satilanUrun in beklemedekiUrunler)
            {
                flowLayoutPanel_bekleyenUrunler.Controls.Add(PazarUrunOlustur(satilanUrun));
            }

        }
        #endregion

        #region Sayfa Yenileme
        //Yenileme click olayı ya da (F5)
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BekleyenPazarUrunleriListele();
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

    }
}
