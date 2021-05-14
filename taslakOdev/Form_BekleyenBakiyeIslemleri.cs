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
    public partial class Form_BekleyenBakiyeIslemleri : Form
    {
        #region Form Create &&  aktif Kullanıcı tutucu
        Kullanici g_aktifKullanici;
        public Form_BekleyenBakiyeIslemleri(Kullanici aktifKullanici)
        {
            InitializeComponent();
            this.g_aktifKullanici = aktifKullanici;
            Listele_OnayBekleyenIslemler();
        }
        #endregion


        /// <summary>
        /// Bakiye İşlemlerinin tutulduğu dosyadan bakiye işlemlerini çeker.
        /// </summary>
        /// <returns>Bir BakiyeKontrol türünde liste döndürür.</returns>
        List<BakiyeIslemObject> GetBakiyeIslemlerFromFile()
        {
            var json_bakiyeIslemler = JsonController.GetJsonFromFile(@"bakiyeIslemler.json");
            var bakiyeIslemler = JsonController.GetDataFromJSON<List<BakiyeIslemObject>>(json_bakiyeIslemler);

            return bakiyeIslemler;
        }

        #region RENKLER
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

        #region Bakiye Islem Nesnesi Olusturma

        #region Bakiye Islem Nesnesi Bilesenleri
        Panel Get_BakiyeIslemContainer(Color BGColor, object Tag)
        {
            // 
            // bakiyeIslemContainer
            // 
            var bakiyeIslemContainer = new Panel();
            bakiyeIslemContainer.BackColor = BGColor;
            bakiyeIslemContainer.Location = new System.Drawing.Point(3, 3);
            bakiyeIslemContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            bakiyeIslemContainer.Size = new System.Drawing.Size(355, 100);
            bakiyeIslemContainer.Tag = Tag;
            return bakiyeIslemContainer;


        }

        Label Get_tarihAyrac()
        {
            // 
            // lbl_tarihAyrac
            // 
            var lbl_tarihAyrac = new Label();
            lbl_tarihAyrac.AutoSize = true;
            lbl_tarihAyrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            lbl_tarihAyrac.Location = new System.Drawing.Point(149, 11);
            lbl_tarihAyrac.Size = new System.Drawing.Size(10, 13);
            lbl_tarihAyrac.Text = "-";
            return lbl_tarihAyrac;
        }

        Label Get_gerceklesmeTarihiTittle()
        {
            // 
            // lbl_gerceklesmeTarihiTittle
            // 
            var lbl_gerceklesmeTarihiTittle = new Label();
            lbl_gerceklesmeTarihiTittle.AutoSize = true;
            lbl_gerceklesmeTarihiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            lbl_gerceklesmeTarihiTittle.Location = new System.Drawing.Point(165, 11);
            lbl_gerceklesmeTarihiTittle.Size = new System.Drawing.Size(97, 13);
            lbl_gerceklesmeTarihiTittle.Text = "Gerçekleşme Tarihi:";
            return lbl_gerceklesmeTarihiTittle;
        }

        Label Get_gerceklesmeTarihiValue(DateTime tarih)
        {
            // 
            // lbl_gerceklesmeTarihiValue
            // ***tarih
            var lbl_gerceklesmeTarihiValue = new Label();
            lbl_gerceklesmeTarihiValue.AutoSize = true;
            lbl_gerceklesmeTarihiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbl_gerceklesmeTarihiValue.Location = new System.Drawing.Point(267, 11);
            lbl_gerceklesmeTarihiValue.Size = new System.Drawing.Size(69, 13);
            lbl_gerceklesmeTarihiValue.Text = tarih.ToString("dd MMM yyyy");
            return lbl_gerceklesmeTarihiValue;
        }

        Label Get_islemTarihiTittle()
        {
            // 
            // lbl_islemTarihiTittle
            // 
            var lbl_islemTarihiTittle = new Label();
            lbl_islemTarihiTittle.AutoSize = true;
            lbl_islemTarihiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            lbl_islemTarihiTittle.Location = new System.Drawing.Point(12, 11);
            lbl_islemTarihiTittle.Size = new System.Drawing.Size(61, 13);
            lbl_islemTarihiTittle.Text = "İşlem Tarihi:";
            return lbl_islemTarihiTittle;

        }

        Label Get_islemTarihiValue(DateTime tarih)
        {
            // 
            // lbl_islemTarihiValue
            // ***tarih
            var lbl_islemTarihiValue = new Label();
            lbl_islemTarihiValue.AutoSize = true;
            lbl_islemTarihiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lbl_islemTarihiValue.Location = new System.Drawing.Point(74, 11);
            lbl_islemTarihiValue.Size = new System.Drawing.Size(69, 13);
            lbl_islemTarihiValue.Text = tarih.ToString("dd MMM yyyy");
            return lbl_islemTarihiValue;
        }

        Label Get_islemMiktari(string value, string birim, Color FRColor)
        {
            // 
            // lbl_islemMiktari
            // ***Renk ***miktar
            var lbl_islemMiktari = new Label();
            lbl_islemMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            lbl_islemMiktari.ForeColor = FRColor;
            lbl_islemMiktari.Location = new System.Drawing.Point(181, 74);
            lbl_islemMiktari.Size = new System.Drawing.Size(170, 22);
            lbl_islemMiktari.Text = value + " " + birim;
            lbl_islemMiktari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            return lbl_islemMiktari;
        }

        Label Get_islemAciklama(string value)
        {
            // 
            // lbl_islemAciklama
            // ***aciklama
            var lbl_islemAciklama = new Label();
            lbl_islemAciklama.AutoSize = true;
            lbl_islemAciklama.Location = new System.Drawing.Point(12, 42);
            lbl_islemAciklama.Size = new System.Drawing.Size(148, 18);
            lbl_islemAciklama.Text = value;
            return lbl_islemAciklama;
        }
        #endregion

        Panel Get_BakiyeIslemNesnesi(BakiyeIslemObject islemNesnesi, object Tag)
        {
            //Gerekli olan parametreler asagida kullanilmak uzere gecici degiskenelre alindi.
            bool reddedildiMi = (islemNesnesi.GetDegisiklikDurum() == BakiyeIslemStatics.stdDurum.reddedildi)
                        || (islemNesnesi.GetDegisiklikDurum() == BakiyeIslemStatics.stdDurum.yetersizBakiye);
            bool incelendiMi = !(islemNesnesi.GetDegisiklikDurum() == BakiyeIslemStatics.stdDurum.incelemede);
            DateTime islemTarihi = islemNesnesi.islemTarihi;
            DateTime gerceklesmeTarihi = islemNesnesi.gerceklesmeTarihi;
            double miktar = islemNesnesi.degisiklikMiktari;
            //Eğer reddedildiyse sebebini sonuna ekle.
            string aciklama = islemNesnesi.aciklama + islemNesnesi.redNedeni();




            //Container
            Color BGColor = reddedildiMi ? BGKirmizi() : BGVarsayilan();
            Panel islemContainer = Get_BakiyeIslemContainer(BGColor, Tag);

            //İşlem Tarihi
            islemContainer.Controls.Add(Get_islemTarihiTittle());
            islemContainer.Controls.Add(Get_islemTarihiValue(islemTarihi));

            //Eger incelendiyse gerçekleşleşme tarihi vardır. İncelenemdiyse bunu ekleme.
            if (incelendiMi)
            {
                //Ayraç
                islemContainer.Controls.Add(Get_tarihAyrac());

                //Gerçekleşme Tarihi
                islemContainer.Controls.Add(Get_gerceklesmeTarihiTittle());
                islemContainer.Controls.Add(Get_gerceklesmeTarihiValue(gerceklesmeTarihi));
            }


            //İşlem Açıklama
            islemContainer.Controls.Add(Get_islemAciklama(aciklama));

            //İşlem Miktar
            Color FRColor = (miktar < 0) ? Kirmizi() : Yesil();
            islemContainer.Controls.Add(Get_islemMiktari(miktar.ToString(), "₺", FRColor));


            return islemContainer;
        }

        #endregion


        #region Bakiye Islemlerini Listele
        void Listele_OnayBekleyenIslemler()
        {
            var bakiyeIslemler = GetBakiyeIslemlerFromFile();

            //kullanicinin bekleyen islemlerini ayıklayıp tarihe(islem) göre sıraladık. (En son en başa.)
            var kullanicininBekleyenIslemleri = (from bi in bakiyeIslemler
                                                where bi.kullaniciAdi == this.g_aktifKullanici.KullaniciAdi
                                                && bi.incelendiMi == false
                                                orderby bi.islemTarihi descending
                                                select bi).ToList();

            flowLayoutPanel_bekleyenIslemler.Controls.Clear();
            foreach (var bekleyenIslem in kullanicininBekleyenIslemleri)
            {
                
                //islem Nesnesine gerekli parametreleri verip olusturduk.
                var islemNesne = Get_BakiyeIslemNesnesi(bekleyenIslem, bekleyenIslem.ID);
                
                //ekrana yansıttık.
                flowLayoutPanel_bekleyenIslemler.Controls.Add(islemNesne);
            }

        }
        #endregion
    
    }
}
