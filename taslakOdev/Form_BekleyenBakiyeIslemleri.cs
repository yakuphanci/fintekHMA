using System;
using System.Drawing;
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
  
       
        #region Bakiye Islem Nesnesi Olusturma

        Panel Get_BekleyenBakiyeIslemNesnesi(BakiyeIslemObject islemNesnesi, object Tag)
        {
            //Gerekli olan parametreler asagida kullanilmak uzere gecici degiskenelre alindi.
            bool reddedildiMi = islemNesnesi.reddedildiMi;
            DateTime islemTarihi = islemNesnesi.islemTarihi;
            double miktar = islemNesnesi.degisiklikMiktari;
            string aciklama = islemNesnesi.aciklama;
            uint islemNum = islemNesnesi.ID;

            //Container
            Color BGColor = reddedildiMi ? Renkler.BGKirmizi : Renkler.BGVarsayilan;
            Panel islemContainer = GorselNesneOlustur.BakiyeIslem.Container(BGColor);
            islemContainer.Tag = Tag;

            //İşlem Tarihi
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Tittle());
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Value(islemTarihi));

            //İşlem Açıklama
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.Aciklama(aciklama));

            //İşlem Tarihi
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Tittle());
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemTarihi_Value(islemTarihi));

            //İşlem Miktar
            Color FRColor = (miktar < 0) ? Renkler.Kirmizi : Renkler.Yesil;
            islemContainer.Controls.Add(GorselNesneOlustur.BakiyeIslem.IslemMiktari(miktar.ToString(), "₺", FRColor));


            return islemContainer;
        }

        #endregion


        #region Bakiye Islemlerini Listele
        void Listele_OnayBekleyenIslemler()
        {

            //kullanicinin bekleyen islemlerini ayıklayıp tarihe(islem) göre sıraladık. (En son en başa.)
            var kullanicininBekleyenIslemleri = 
                Veriler.GetKullanicininBekleyenBakiyeIslemleri(this.g_aktifKullanici.KullaniciAdi);

            flowLayoutPanel_bekleyenIslemler.Controls.Clear();
            foreach (var bekleyenIslem in kullanicininBekleyenIslemleri)
            {
                
                //islem Nesnesine gerekli parametreleri verip olusturduk.
                var islemNesne = Get_BekleyenBakiyeIslemNesnesi(bekleyenIslem, bekleyenIslem.ID);
                
                //ekrana yansıttık.
                flowLayoutPanel_bekleyenIslemler.Controls.Add(islemNesne);
            }

        }
        #endregion
    
    }
}
