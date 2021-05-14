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
        #region Form Create && aktif kullanıcı tutucu
        Kullanici g_aktifKullanici;
        public Form_Profil(Kullanici aktifKullanici)
        {
            InitializeComponent();
            this.g_aktifKullanici = aktifKullanici;
            TumunuYenile();
        }
        #endregion


        #region RENKLER
        Color KoyuGri()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        }
        Color Yesil()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }
        Color Kirmizi()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        }

        Color BGVarsayilan()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
        }
        Color BGKirmizi()
        {
            return System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
        }
        #endregion


        #region Pazar Nesnesi Olusturma
        #region Pazar Nesnesi Bilesenleri
        Panel Get_PazarContainer(Color BGColor, object Tag)
        {
            //Satılık  ürün(pazar) Kontainer Paneli
            Panel satilikUrunContainer = new Panel();
            satilikUrunContainer.BackColor = BGColor;
            satilikUrunContainer.Location = new System.Drawing.Point(5, 5);
            satilikUrunContainer.Size = new System.Drawing.Size(560, 130);

            return satilikUrunContainer;
        }

        PictureBox Get_PazarImage(Bitmap imgSource)
        {
            //Urun Fotografi
            PictureBox urunResmi = new PictureBox();
            urunResmi.Image = imgSource;
            urunResmi.Location = new System.Drawing.Point(5, 5);
            urunResmi.Size = new System.Drawing.Size(120, 120);
            urunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            urunResmi.TabStop = false;

            return urunResmi;
        }

        Label Get_PazarUrunAdi(string value)
        {
            //Ürün Adı
            Label urunAdi = new Label();
            urunAdi.AutoSize = true;
            urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            urunAdi.Location = new System.Drawing.Point(129, 12);
            urunAdi.Size = new System.Drawing.Size(61, 20);
            urunAdi.Text = value;
            return urunAdi;
        }

        Label Get_PazarMiktarTittle(string birim)
        {
            //urunMiktar Tittle
            Label urunMiktarTittle = new Label();
            urunMiktarTittle.AutoSize = true;
            urunMiktarTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunMiktarTittle.Location = new System.Drawing.Point(130, 43);
            urunMiktarTittle.Size = new System.Drawing.Size(70, 16);
            urunMiktarTittle.Text = "Miktar ("+birim+")";
            return urunMiktarTittle;
        }

        Label Get_PazarMiktarValue(int miktar)
        {
            //urunMiktar Value
            Label urunMiktarValue = new Label();
            urunMiktarValue.AutoSize = true;
            urunMiktarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunMiktarValue.Location = new System.Drawing.Point(206, 44);
            urunMiktarValue.Size = new System.Drawing.Size(40, 16);
            urunMiktarValue.Text = miktar.ToString();
            return urunMiktarValue;
        }

        Label Get_PazarUrunFiyatTittle(string birim)
        {
            //fiyat tittle
            Label urunFiyatTittle = new Label();
            urunFiyatTittle.AutoSize = true;
            urunFiyatTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunFiyatTittle.Location = new System.Drawing.Point(130, 68);
            urunFiyatTittle.Size = new System.Drawing.Size(52, 16);
            urunFiyatTittle.Text = "Fiyat("+birim+")";
            return urunFiyatTittle;
        }

        Label Get_PazarUrunFiyatValue(double fiyat, string birim)
        {
            //fiyat value
            Label urunFiyatValue = new Label();
            urunFiyatValue.AutoSize = true;
            urunFiyatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunFiyatValue.Location = new System.Drawing.Point(206, 68);
            urunFiyatValue.Size = new System.Drawing.Size(36, 16);
            urunFiyatValue.Text = fiyat + " " + birim;
            return urunFiyatValue;
        }

        Label Get_PazarSaticiTittle()
        {
            // satici tittle
            Label urunSaticiTittle = new Label();
            urunSaticiTittle.AutoSize = true;
            urunSaticiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            urunSaticiTittle.Location = new System.Drawing.Point(130, 91);
            urunSaticiTittle.Size = new System.Drawing.Size(44, 16);
            urunSaticiTittle.Text = "Satıcı:";
            return urunSaticiTittle;
        }


        Label Get_PazarSaticiValue(string value)
        {
            // satici value
            Label urunSaticiValue = new Label();
            urunSaticiValue.AutoSize = true;
            urunSaticiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            urunSaticiValue.Location = new System.Drawing.Point(206, 91);
            urunSaticiValue.Size = new System.Drawing.Size(74, 16);
            urunSaticiValue.Text = value;
            return urunSaticiValue;
        }

        Label Get_PazarIDTittle()
        {
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
            return pazarIDTittle;
        }

        Label Get_PazarIDValue(uint value)
        {
            // 
            // pazarIDValue
            // 
            Label pazarIDValue = new Label();
            pazarIDValue.AutoSize = true;
            pazarIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            pazarIDValue.Location = new System.Drawing.Point(477, 91);
            pazarIDValue.Size = new System.Drawing.Size(32, 16);
            pazarIDValue.TabIndex = 16;
            pazarIDValue.Text = value.ToString();
            return pazarIDValue;
        }

        Label Get_PazarTarihTittle()
        {
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
            return pazarTarihTittle;
        }

        Label Get_PazarTarihValue(DateTime tarih)
        {
            // 
            // label_tarihValue
            // 
            Label pazarTarihValue = new Label();
            pazarTarihValue.AutoSize = true;
            pazarTarihValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            pazarTarihValue.Location = new System.Drawing.Point(472, 109);
            pazarTarihValue.Size = new System.Drawing.Size(80, 16);
            pazarTarihValue.TabIndex = 9;
            pazarTarihValue.Text = tarih.ToString("dd/MM/yyyy");
            return pazarTarihValue;
        }

        #endregion
      

        Panel Get_PazarNesnesi(SatilanUrun pazar, object Tag, Color BGColor)
        {
            uint pazarID = pazar.pazarID;
            string urunAdi = pazar.urun.urunAdi;
            string satici = pazar.saticiID;
            double fiyat = pazar.fiyat;
            int miktar = pazar.miktar;
            DateTime tarih = pazar.tarih;
            
            //urunResim varsayılan deger atandı. 
            Bitmap urunResmi = global::taslakOdev.Properties.Resources.patates1;
            Panel pazarNesnesi = Get_PazarContainer(BGColor, Tag);

            //Bilesenleri ekliyoruz.
            pazarNesnesi.Controls.Add( Get_PazarImage(urunResmi) );
            pazarNesnesi.Controls.Add( Get_PazarUrunAdi(urunAdi) );
            pazarNesnesi.Controls.Add( Get_PazarMiktarTittle("kg") );
            pazarNesnesi.Controls.Add( Get_PazarMiktarValue(miktar) );
            pazarNesnesi.Controls.Add( Get_PazarUrunFiyatTittle("kg") );
            pazarNesnesi.Controls.Add( Get_PazarUrunFiyatValue(fiyat,"₺"));
            pazarNesnesi.Controls.Add( Get_PazarSaticiTittle() );
            pazarNesnesi.Controls.Add( Get_PazarSaticiValue(satici));
            pazarNesnesi.Controls.Add( Get_PazarTarihTittle());
            pazarNesnesi.Controls.Add( Get_PazarTarihValue(tarih));
            pazarNesnesi.Controls.Add( Get_PazarIDTittle() );
            pazarNesnesi.Controls.Add( Get_PazarIDValue(pazarID));

            return pazarNesnesi;
        }
        #endregion


        Button Get_PazarCrossButton(object Tag)
        {
            // 
            // çarpı butonu
            // 
            Button btn_yayindanKaldir = new Button();
            btn_yayindanKaldir.BackColor = KoyuGri();
            btn_yayindanKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_yayindanKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btn_yayindanKaldir.Location = new System.Drawing.Point(532, 5);
            btn_yayindanKaldir.Size = new System.Drawing.Size(25, 25);
            btn_yayindanKaldir.TabIndex = 14;
            btn_yayindanKaldir.Text = "X";
            btn_yayindanKaldir.UseVisualStyleBackColor = false;
            btn_yayindanKaldir.Tag = Tag;
            return btn_yayindanKaldir;
        }

        /// <summary>
        /// Belirtilen objeye Click eventi ekler.
        /// </summary>
        /// <param name="sender">Click olayı eklenecek nesne.</param>
        /// <param name="eventHandlerMethod">Click olduğunda tetiklenecek method</param>
        void AddEvent_Click(Button sender, EventHandler eventHandlerMethod)
        {
            (sender).Cursor = Cursors.Hand;
            (sender).Click += new EventHandler(eventHandlerMethod);
        }

        #region Yayindan Kaldırma Islemleri
        private void btn_yayindanKaldir_Click(object sender, EventArgs e)
        {
            //Yayından kaldırılmak istenen ürün pazarının ID'sini çektik
            uint tiklananPazarID = (uint)((Button)sender).Tag;

            //Onaylayıp onaylamadığını sorduk.
            DialogResult onaySorgu = new DialogResult();
            onaySorgu = MessageBox.Show(" [ " + tiklananPazarID + " ] Pazar numaralı ürünü sistemden kaldırmak istiyor musunuz?", "Pazar Onaylama", MessageBoxButtons.YesNo);

            //Onayladıysa veriyi güncelledik.
            if (onaySorgu == DialogResult.Yes)
            {
                SistemdenKaldir(tiklananPazarID);
                Mesajlar.Basarili();//Başarılı mesajı.
                
                //Listeyi yeniledik.
                TumunuYenile();
            }

           
        }

        private void SistemdenKaldir(uint tiklananPazarID)
        {
            var sistemdeSatilanUrunler = GetSatilanUrunler();
            var kaldirilacakPazar = (from su in sistemdeSatilanUrunler
                                     where su.pazarID == tiklananPazarID
                                     select su).ToList()[0];
            sistemdeSatilanUrunler.Remove(kaldirilacakPazar);
            JsonController.SaveJsonToFile(@"SatilanUrunler.json", sistemdeSatilanUrunler);
        }
        #endregion

      
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

        List<Kullanici> GetKullanicilar()
        {
            var json_kullanicilar = JsonController.GetJsonFromFile(@"kullanicilar.json");
            var kullanicilar = JsonController.GetDataFromJSON<List<Kullanici>>(json_kullanicilar);
            return kullanicilar;
        }

       
        #region Listeleme Fonksiyonları
        void yayindakiUrunlerListele()
        {
            flowLayoutPanel_yayindakiUrunler.Controls.Clear();

            var kayitliSatilanUrunler = GetSatilanUrunler();

            //Pazara çıkması onaylanmış ve yayına alınmış ürünler filtreler/sıralar.
            var yayindakiUrunler = from su in kayitliSatilanUrunler
                                   where su.pazardaMi == true
                                   && su.saticiID == this.g_aktifKullanici.KullaniciAdi
                                   orderby su.tarih ascending
                                   select su;

            foreach (var satilanUrun in yayindakiUrunler)
            {
                Panel pazarNesnesi = Get_PazarNesnesi(satilanUrun, satilanUrun.pazarID, BGVarsayilan());
                
                //Kaldırma butonunu dahil et.
                Button kaldirmaButonu = Get_PazarCrossButton(satilanUrun.pazarID);
                AddEvent_Click(kaldirmaButonu, btn_yayindanKaldir_Click);//Kaldırma butonunun tıklandıgında çalışacak fonksiyonu.
                pazarNesnesi.Controls.Add(kaldirmaButonu);

                flowLayoutPanel_yayindakiUrunler.Controls.Add(pazarNesnesi);
            }

        }

        void beklemedekiUrunlerListele()
        {

            flowLayoutPanel_beklemedekiUrunler.Controls.Clear();

            var kayitliSatilanUrunler = GetSatilanUrunler();

            //Henüz pazara çıkmayı bekleyen, onaylanmamış ürünleri filtreler/sıralar.
            var beklemedekiUrunler = from su in kayitliSatilanUrunler
                                     where su.pazardaMi == false
                                     && su.saticiID == this.g_aktifKullanici.KullaniciAdi
                                     orderby su.tarih ascending
                                     select su;


            foreach (var satilanUrun in beklemedekiUrunler)
            {
                Panel pazarNesnesi = Get_PazarNesnesi(satilanUrun, satilanUrun.pazarID, BGVarsayilan());

                //Kaldırma butonunu dahil et.
                Button kaldirmaButonu = Get_PazarCrossButton(satilanUrun.pazarID);
                AddEvent_Click(kaldirmaButonu, btn_yayindanKaldir_Click);//Kaldırma butonunun tıklandıgında çalışacak fonksiyonu.
                pazarNesnesi.Controls.Add(kaldirmaButonu);

                flowLayoutPanel_beklemedekiUrunler.Controls.Add(pazarNesnesi);
            }
        }
        #endregion


        #region Yeni Urun Ekle Butonu Tıklama Olayı
        /// <summary>
        /// Urun Ekleme Butonu Tıklama Olayı.
        /// Kullanıcının Eklenebilir ürün kategorilerinden ürün seçip yükleyebileceği pencere açılır.
        /// </summary>
        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            Form_UrunEkle frm_UrunEkle = new Form_UrunEkle(this.g_aktifKullanici.KullaniciAdi);
            frm_UrunEkle.ShowDialog();
            button_yenile.PerformClick();
        }
        #endregion


        #region Yenileme İslemleri
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
            beklemedekiUrunlerListele();
            yayindakiUrunlerListele();
            BakiyeYenile();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            TumunuYenile();
        }
        #endregion


        #region Bekleyenler/Yayındakiler listesi görünüm geçiş buton olayları
        
        #region Show/Hide Panels
        void Show_Panel(object sender)
        {
            ((Panel)sender).Visible = true;
        }

        void Hide_Panel(object sender)
        {
            ((Panel)sender).Visible = false;
        }
        #endregion

        #region aktive/deAktive Buttons
        void aktive_Button(object sender)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
            ((Button)sender).Cursor = Cursors.Default;
        }
        void deAktive_Button(object sender)
        {
            ((Button)sender).FlatStyle = FlatStyle.Popup;
            ((Button)sender).Cursor = Cursors.Hand;

        }
        #endregion

        private void button_satistakiUrunler_Click(object sender, EventArgs e)
        {
            //Tıkladığımız butonun tasarımını seçilmiş gibi yaptık.
            aktive_Button(sender);

            //Beklemedeki ürünler butonunu seçilmemiş gibi gösterdik.
            deAktive_Button(button_bekleyenUrunler);

            //Beklemedeki ürünleri gizledik.
            Hide_Panel(flowLayoutPanel_beklemedekiUrunler);

            //Satıştaki ürünleri gösterdik.
            Show_Panel(flowLayoutPanel_yayindakiUrunler);

        }

        private void button_bekleyenUrunler_Click(object sender, EventArgs e)
        {
            //Tıkladığımız butonun tasarımını seçilmiş gibi yaptık.
            aktive_Button(sender);

            //Satıştaki ürünler butonunu seçilmemiş gibi gösterdik.
            deAktive_Button(button_satistakiUrunler);

            //Satıştaki ürünleri gizledik.
            Hide_Panel(flowLayoutPanel_yayindakiUrunler);

            //Beklemedeki ürünleri gösterdik.
            Show_Panel(flowLayoutPanel_beklemedekiUrunler);

        }

        #endregion


        #region Bakiye Islemleri Butonu Tıklama Olayı
        private void button_bakiyeIslemleri_Click(object sender, EventArgs e)
        {
            Form_BakiyeIslem frm_bakiyeIslem = new Form_BakiyeIslem(this.g_aktifKullanici);
            frm_bakiyeIslem.ShowDialog();
            //işlem yapıldıktan sonra bakiye bilgisini yeniden çek.
            TumunuYenile();
        }
        #endregion
   
    }
}
