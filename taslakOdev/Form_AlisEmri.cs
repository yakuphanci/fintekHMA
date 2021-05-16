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
    public partial class Form_AlisEmri : Form
    {
        #region Form Create && aktif Kullanici tutucu
        Kullanici g_aktifKullanici;
        public Form_AlisEmri(Kullanici aktifKullanici)
        {
            InitializeComponent();
            this.g_aktifKullanici = aktifKullanici;
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


       
        private void button_onayla_Click(object sender, EventArgs e)
        {
            if (this.g_seciliUrun != null && numericUpDown_miktar.Value > 0)
            {
                #region Local Degiskenler
                int istenenMiktar = (int)numericUpDown_miktar.Value; //Arzulanan alım miktarı.
                double toplamMaliyet = 0; //Alış emri gerçekleşirse alıcıya mal olacak toplam bedel.
                int alinabilecekMaksMiktar = 0; //Alınmak istenen ürün miktarından ne kadarının alınabileceği bilgisi.
                string aliciID = this.g_aktifKullanici.KullaniciAdi;
                uint alinacakUrunID = this.g_seciliUrun.ID;
                #endregion

                #region Alis icin Onizleme bilgileri cek

                bool yeterliMi = 
                    AlisIslemleri.OnIzleme(aliciID, alinacakUrunID, istenenMiktar, out toplamMaliyet, out alinabilecekMaksMiktar);

                #endregion

                if (alinabilecekMaksMiktar > 0)
                {
                    #region Dialog(Maliyet ve miktar bilgisi + onay Suali) 
                    DialogResult alisOnay =
                        MessageBox.Show(
                               (yeterliMi ? "Yeterli miktarda ürün var.\n" : "Almak istediğin miktarda ürün yok. Alabileceğin tüm miktar ve maliyet:\n") +
                               "Satabileceğimiz toplam " + this.g_seciliUrun.Adi + " miktarı " + alinabilecekMaksMiktar + "kg\n" +
                               "Size mâl olacak toplam bedel: " + toplamMaliyet + " TRY\n",
                               "Onaylyor musunuz?"
                               , MessageBoxButtons.YesNo
                               );
                    #endregion

                    if (alisOnay == DialogResult.Yes)
                    {
                        if (toplamMaliyet <= this.g_aktifKullanici.Bakiye)
                        {
                            AlisIslemleri.AlisYap(aliciID, alinacakUrunID, istenenMiktar);
                            Mesajlar.BilgiMesaji(
                                "Alış işleminiz tamamlandı. Aldığınız ürünleri en kısa sürede sistemde belirttiğiniz adresinize getireceğiz.",
                                "Tamamlandı.");
                            this.Close();
                        }
                        else
                        {
                            #region Yetersiz Bakiye Uyarisi
                            Mesajlar.UyariMesaji(
                                "Üzgünüm hesabınızda almak istediğiniz ürünlerin bedelini karşılayacak kadar bakiye bulunmuyor." +
                                "Eksik bakiye: " + (this.g_aktifKullanici.Bakiye - toplamMaliyet),
                                "Yetersiz Bakiye!"
                                );
                            #endregion
                        }
                    }
                }
                else
                {
                    #region Urun yok uyarisi
                    Mesajlar.UyariMesaji(
                        "Üzgünüz. Çünkü size satabileceğimiz " + this.g_seciliUrun.Adi + " ürünümüz yok." +
                        "\nLütfen bizi affedin ve daha sonra tekrar deneyin.",
                        "Ah olamaz!");
                    #endregion
                }


            }
            else
                Mesajlar.UyariMesaji("Lütfen satın almak istediğiniz ürün türünü seçiniz.", "Eksik Bilgi.");
        }




        #region Alınacak urun seçim işlemi

        //Combobox'tan seçilen ürün burda tutulacak.
        Urun g_seciliUrun = null;
        private void comboBox_kategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comboboxdan seçilen türe göre urun nesnesini oluşturur.
            if (comboBox_kategoriler.SelectedIndex > -1)
            {
                this.g_seciliUrun = new Urun();
                var seciliCmbItem = comboBox_kategoriler.SelectedItem.ToString();
                var splitCmbItem = seciliCmbItem.Split(' ');
                g_seciliUrun.Adi = splitCmbItem[0];
                g_seciliUrun.ID = UInt32.Parse(splitCmbItem[2]);
            }
            else
            {
                this.g_seciliUrun = null;
            }
        }

        #endregion
    }
}
