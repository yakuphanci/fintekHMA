using System;
using System.Drawing;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_BakiyeIslemGecmisi : Form
    {
        #region Form Create && aktif kullanici tutucu
        Kullanici g_aktifKullanici;
        public Form_BakiyeIslemGecmisi(Kullanici aktifKullanici)
        {
            InitializeComponent();
            this.g_aktifKullanici = aktifKullanici;
            Listele_GecmisIslemler();
        }
        #endregion


        #region Islem Nesnesi Olusturma
      
        Panel Get_BakiyeIslemNesnesi(BakiyeIslemObject islemNesnesi, object Tag)
        {
            //Gerekli olan parametreler asagida kullanilmak uzere gecici degiskenelre alindi.
            bool reddedildiMi = islemNesnesi.reddedildiMi;
          

            DateTime islemTarihi = islemNesnesi.islemTarihi;
            DateTime gerceklesmeTarihi = islemNesnesi.gerceklesmeTarihi;
            double miktar = islemNesnesi.degisiklikMiktari;
            uint islemNum = islemNesnesi.ID;
            string aciklama = islemNesnesi.aciklama;
            //Eğer reddedildiyse sebebini sonuna ekle.
            if (reddedildiMi)
                aciklama += " - " + islemNesnesi.redNedeni();

            //Container
            Color BGColor = reddedildiMi ? Renkler.BGKirmizi : Renkler.BGVarsayilan;
            Panel islemContainer = GorselNesneOlustur.BakiyeIslem.Container(BGColor);
            islemContainer.Tag = Tag;

            //İşlem Tarihi
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Tittle());
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Value(islemTarihi));
            
            //Ayraç
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.TarihAyrac());

            //Gerçekleşme Tarihi
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.GerceklesmeTarihi_Tittle());
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.GerceklesmeTarihi_Value(gerceklesmeTarihi));
            
            //İşlem Açıklama
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.Aciklama(aciklama));
            
            //islemTalepNum
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.TalepNum_Tittle());
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.TalepNum_Value(islemNum));

            //İşlem Miktar
            Color FRColor = (miktar < 0) ? Renkler.Kirmizi : Renkler.Yesil;
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemMiktari(miktar.ToString(), "₺", FRColor));

            return islemContainer;
        }

        #endregion


        #region Bakiye Islemleri Listele
        void Listele_GecmisIslemler()
        {
            //kullanicinin bekleyen islemlerini ayıklayıp tarihe(gerceklesme) göre sıraladık. (En son en başa.)
            var kullanicininGecmisIslemleri = 
                Veriler.GetKullanicininGecmisBakiyeIslemleri(this.g_aktifKullanici.KullaniciAdi);

            flowLayoutPanel_islemGecmisi.Controls.Clear();
            foreach (var gecmisIslem in kullanicininGecmisIslemleri)
            {

                //islem Nesnesine gerekli parametreleri verip olusturduk.
                var islemNesne = Get_BakiyeIslemNesnesi(gecmisIslem, gecmisIslem.ID);

                //ekrana yansıttık.
                flowLayoutPanel_islemGecmisi.Controls.Add(islemNesne);
            }
    
        }
        #endregion

    }
}
