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
    public partial class Form_UrunEkle : Form
    {
        #region Form Create & KullaniciAdi tutucu
        string g_kullaniciAdi;
        public Form_UrunEkle(string kullaniciAdi)
        {
            InitializeComponent();
            this.g_kullaniciAdi = kullaniciAdi;
        }
        #endregion


        #region Kategori Doldurma islemi
        /// <summary>
        /// Eklenebilir ürünlerin listesini Form ekranındaki comboBox'a doldurur.
        /// </summary>
        void KategoriDoldur()
        {
            comboBox_kategoriler.Items.Clear();
            string json_urunler = JsonController.GetJsonFromFile(@"urunler.json");
            var urunler = JsonController.GetDataFromJSON<List<Urun>>(json_urunler);

            foreach (var urun in urunler)
            {
                comboBox_kategoriler.Items.Add(urun.urunAdi + " - " + urun.urunID);
            }
        }
        /// <summary>
        /// Form'un açılışında comboBoxu doldurma islemi baslatilir
        /// </summary>
        private void Form_UrunEkle_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
        }
        #endregion


        #region Validasyon Islemleri
        bool valid_SeciliKategori(out Urun seciliUrun)
        {
            seciliUrun = new Urun();
            if (comboBox_kategoriler.SelectedIndex > -1)
            {
                var seciliCmbItem = comboBox_kategoriler.SelectedItem.ToString();
                var splitCmbItem = seciliCmbItem.Split(' ');

                seciliUrun.urunAdi = splitCmbItem[0];
                seciliUrun.urunID = Int32.Parse(splitCmbItem[2]);
                return true;
            }
            else
            {
                Mesajlar.UyariMesaji("Lütfen ürün türünü seçiniz.", "Ürün türü seçilmedi!");

                comboBox_kategoriler.SelectAll();
                comboBox_kategoriler.Focus();
                return false;
            }

        }

        bool valid_Fiyat(out double fiyat)
        {
            // virgül yerine nokta ile ayırdıysa küsüratı virgüle çeviriyoruz.
            textBox_fiyat.Text = textBox_fiyat.Text.Replace('.', ',');
            if (!Double.TryParse(textBox_fiyat.Text, out fiyat))
            {
                //double türüne çevirmeye çalışıyoruz çevrilemezse uyarı veriyoruz.
                Mesajlar.UyariMesaji("Geçersiz bir fiyat girdiniz. Lütfen harf yazıp yazmadığınızı ve fazla ayraç kullanmadığınıza dikkat ediniz.", "Geçersiz fiyat!");
                textBox_fiyat.SelectAll();
                textBox_fiyat.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion


        #region Urun Ekleme islemi
        bool UrunEkle(Urun _urun, int _miktar, double _fiyat )
        {
            bool eklendiMi = false;
            try
            {
                string json_kayitliSatilanUrunler = JsonController.GetJsonFromFile(@"SatilanUrunler.json");
                var kayitliSatilanUrunler = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_kayitliSatilanUrunler);

                #region Yeni Pazar olusturma islemi
                ///yeni pazar urunu olusturma islemi
                SatilanUrun yeniSatilanUrun = new SatilanUrun();
                yeniSatilanUrun.urun = _urun;
                yeniSatilanUrun.miktar = _miktar;
                yeniSatilanUrun.fiyat = _fiyat;

                yeniSatilanUrun.saticiID = this.g_kullaniciAdi;
                yeniSatilanUrun.tarih = DateTime.Now;
                yeniSatilanUrun.OlusturPazarID(); //Benzersiz bir ID verir
                #endregion

                kayitliSatilanUrunler.Add(yeniSatilanUrun);
         
                JsonController.SaveJsonToFile(@"SatilanUrunler.json", kayitliSatilanUrunler);
                eklendiMi = true;
            }
            catch (Exception exc)
            {
                //Ekleme islemi yapılırken bir sorunla karsilasilirsa.
                Mesajlar.Hata(exc.Message);
            }
            return eklendiMi;
            
            
        }
        #endregion


        #region Urun Ekleme Onaylama Tiklama Islemi
        private void button_onayla_Click(object sender, EventArgs e)
        {
            double giriliFiyat;
            Urun seciliUrun = null;
            int giriliMiktar = (int)(numericUpDown_miktar.Value);
            if(valid_Fiyat(out giriliFiyat) && valid_SeciliKategori(out seciliUrun))
            {
                bool eklendiMi = UrunEkle(seciliUrun, giriliMiktar, giriliFiyat);
                if (eklendiMi)
                {
                    //Ürün eklendiyse başarılı mesajı ver. Ve pencereyi kapat.
                    Mesajlar.Basarili();
                    this.Close();
                }

             }
        }
        #endregion


    }
}
