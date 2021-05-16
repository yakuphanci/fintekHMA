using System;
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
            KategoriDoldur();
        }
        #endregion


        #region Kategori Doldurma islemi
        /// <summary>
        /// Eklenebilir ürünlerin listesini Form ekranındaki comboBox'a doldurur.
        /// </summary>
        void KategoriDoldur()
        {
            comboBox_kategoriler.Items.Clear();
            //Ekleneblable ürünler çekildi.
            var urunler = Veriler.GetUrunTurleri();

            comboBox_kategoriler.Items.Clear();
            foreach (var urun in urunler)
            {
                comboBox_kategoriler.Items.Add(urun.Adi + " - " + urun.ID);
            }
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

                seciliUrun.Adi = splitCmbItem[0];
                seciliUrun.ID = UInt32.Parse(splitCmbItem[2]);
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


        #region Yeni Pazar olusturma islemi
        SatilanUrun GetNewSatilanUrun(Urun _urun, int _miktar, double _fiyat)
        {
            SatilanUrun yeniSatilanUrun = new SatilanUrun();
            yeniSatilanUrun.urun = _urun;
            yeniSatilanUrun.miktar = _miktar;
            yeniSatilanUrun.fiyat = _fiyat;

            yeniSatilanUrun.saticiID = this.g_kullaniciAdi;
            yeniSatilanUrun.tarih = DateTime.Now;
            yeniSatilanUrun.pazarID = BenzersizIDOlusturucu.GetPazarID(); //Benzersiz bir ID verir
            return yeniSatilanUrun;
        }
        #endregion

        
        #region Urun Ekleme islemi
        bool UrunEkle(Urun _urun, int _miktar, double _fiyat )
        {
            bool eklendiMi = false;
            try
            {
                var kayitliSatilanUrunler = Veriler.GetSatilanUrunler();
              
                ///yeni pazar urunu olusturma islemi
                var yeniSatilanUrun = GetNewSatilanUrun(_urun, _miktar, _fiyat);
                kayitliSatilanUrunler.Add(yeniSatilanUrun);  
               
                Veriler.SaveData(kayitliSatilanUrunler);
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
                    Mesajlar.BilgiMesaji("Yeni ürün satışı talebiniz sisteme iletilmiştir.","Talebiniz İletildi.");
                    this.Close();
                }

             }

        }
        #endregion


    }
}
