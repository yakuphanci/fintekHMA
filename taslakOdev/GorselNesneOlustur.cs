using System;
using System.Drawing;
using System.Windows.Forms;

namespace taslakOdev
{
    public class GorselNesneOlustur
    {
        public static bool Ekle_ClickEvent(object sender, EventHandler eventHandlerMethod)
        {
            bool eklendiMi = true;
            if (sender is Button)
                ((Button)sender).Click += new EventHandler(eventHandlerMethod);
            else if (sender is Panel)
                ((Panel)sender).Click += new EventHandler(eventHandlerMethod);
            else if (sender is Label)
                ((Label)sender).Click += new EventHandler(eventHandlerMethod);
            else
                eklendiMi = false;
          
            return eklendiMi;

        }



        public class  BakiyeIslem
        {
            public static Panel Container(Color BGColor)
            {
                // 
                // bakiyeIslemContainer
                // 
                var bakiyeIslemContainer = new Panel();
                bakiyeIslemContainer.BackColor = BGColor;
                bakiyeIslemContainer.Location = new System.Drawing.Point(3, 3);
                bakiyeIslemContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
                bakiyeIslemContainer.Size = new System.Drawing.Size(355, 100);
                return bakiyeIslemContainer;

            }

            public static Label TarihAyrac()
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

            public static Label GerceklesmeTarihi_Tittle()
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

            public static Label GerceklesmeTarihi_Value(DateTime tarih)
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

            public static Label IslemTarihi_Tittle()
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

            public static Label IslemTarihi_Value(DateTime tarih)
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

            public static Label IslemMiktari(string value, string birim, Color FRColor)
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

            public static Label Aciklama(string value)
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
        
        }
    
        public class Pazar
        {
            public static Panel Container(Color BGColor)
            {
                //Satılık  ürün(pazar) Kontainer Paneli
                Panel satilikUrunContainer = new Panel();
                satilikUrunContainer.BackColor = BGColor;
                satilikUrunContainer.Location = new System.Drawing.Point(5, 5);
                satilikUrunContainer.Size = new System.Drawing.Size(560, 130);

                return satilikUrunContainer;
            }

            public static PictureBox Image(Bitmap imgSource)
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

            public static Label UrunAdi(string value)
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

            public static Label UrunMiktar_Tittle(string birim)
            {
                //urunMiktar Tittle
                Label urunMiktarTittle = new Label();
                urunMiktarTittle.AutoSize = true;
                urunMiktarTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
                urunMiktarTittle.Location = new System.Drawing.Point(130, 43);
                urunMiktarTittle.Size = new System.Drawing.Size(70, 16);
                urunMiktarTittle.Text = "Miktar (" + birim + ")";
                return urunMiktarTittle;
            }

            public static Label UrunMiktar_Value(int miktar)
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

            public static Label UrunFiyat_Tittle(string birim)
            {
                //fiyat tittle
                Label urunFiyatTittle = new Label();
                urunFiyatTittle.AutoSize = true;
                urunFiyatTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
                urunFiyatTittle.Location = new System.Drawing.Point(130, 68);
                urunFiyatTittle.Size = new System.Drawing.Size(52, 16);
                urunFiyatTittle.Text = "Fiyat(" + birim + ")";
                return urunFiyatTittle;
            }

            public static Label UrunFiyat_Value(double fiyat, string birim)
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

            public static Label PazarSahibi_Tittle()
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

            public static Label PazarSahibi_Value(string value)
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

            public static Label PazarID_Tittle()
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

            public static Label PazarID_Value(uint value)
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

            public static Label PazarTarihi_Tittle()
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

            public static Label PazarTarihi_Value(DateTime tarih)
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

            public static Button CrossButton(Color BGColor)
            {
                // 
                // çarpı butonu
                // 
                Button btn_yayindanKaldir = new Button();
                btn_yayindanKaldir.BackColor = BGColor;
                btn_yayindanKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_yayindanKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                btn_yayindanKaldir.Location = new System.Drawing.Point(532, 5);
                btn_yayindanKaldir.Size = new System.Drawing.Size(25, 25);
                btn_yayindanKaldir.Text = "X";
                btn_yayindanKaldir.UseVisualStyleBackColor = false;
                return btn_yayindanKaldir;
            }

            public static Label EnDusukFiyat_Tittle(string birim)
            {
                //en dusuk fiyat tittle
                Label urunEnDusukFiyatTittle = new Label();
                urunEnDusukFiyatTittle.AutoSize = true;
                urunEnDusukFiyatTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
                urunEnDusukFiyatTittle.Location = new System.Drawing.Point(130, 73);
                urunEnDusukFiyatTittle.Size = new System.Drawing.Size(53, 16);
                urunEnDusukFiyatTittle.Text = "EDF("+birim+"):";
                return urunEnDusukFiyatTittle;

            }

            public static Label EnDusukFiyat_Value(double value, string birim)
            {

                //en dusuk fiyat value
                Label urunEnDusukFiyatValue = new Label();
                urunEnDusukFiyatValue.AutoSize = true;
                urunEnDusukFiyatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
                urunEnDusukFiyatValue.Location = new System.Drawing.Point(206, 74);
                urunEnDusukFiyatValue.Size = new System.Drawing.Size(36, 16);
                urunEnDusukFiyatValue.Text = value.ToString() + " " + birim;
                return urunEnDusukFiyatValue;

            }

            public static Label KategoriID_Tittle()
            {
                // 
                // kategoriIDTittle
                // 
                Label kategoriIDTittle = new Label();
                kategoriIDTittle.AutoSize = true;
                kategoriIDTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
                kategoriIDTittle.Location = new System.Drawing.Point(433, 107);
                kategoriIDTittle.Size = new System.Drawing.Size(77, 16);
                kategoriIDTittle.Text = "Kategori ID:";
                return kategoriIDTittle;
             
            }

            public static Label KategoriID_Value(uint urunID)
            {
                // 
                // kategoriIDValue
                // 
                Label kategoriIDValue = new Label();
                kategoriIDValue.AutoSize = true;
                kategoriIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
                kategoriIDValue.Location = new System.Drawing.Point(516, 107);
                kategoriIDValue.Size = new System.Drawing.Size(16, 16);
                kategoriIDValue.Text = urunID.ToString();
                return kategoriIDValue;
            }
        }
    
    }
}
