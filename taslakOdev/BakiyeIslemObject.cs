using System;
using System.Linq;

namespace taslakOdev
{
    public static class BakiyeIslemStatics
    {
        //standart durumları tutar.
        public static class stdDurum
        {
            public static string reddedildi { get { return "Red."; } }
            public static string onaylandi { get { return "Onaylandı."; } }
            public static string incelemede { get { return "İncelemede."; } }
            public static string yetersizBakiye { get { return "Yetersiz Bakiye."; } }

        }
    }

    public class BakiyeIslemObject
    {

        public uint ID;
        public string kullaniciAdi;
        public double degisiklikMiktari;
        public DateTime islemTarihi;
        public DateTime gerceklesmeTarihi;
        public string aciklama;
       
        //incelenip karar verilip verilmediğini tutar.
        public bool incelendiMi;
        //incelendiyse, kararın ne yönde verildiğini turar.
        public bool onaylandiMi;
        //işlemin gerçekleşip gerçekleşmediği bilgisini tutar.
        public bool gerceklestiMi;
        //islemin reddedilip edilmediği bilgisini tutar
        public bool reddedildiMi;

        public bool IslemiIsle(bool izin)
        {
            
            this.gerceklesmeTarihi = DateTime.Now;
            //kullanicilar Listesi çekildi
            var kullanicilar = Veriler.GetKullanicilar();

            //değişiklik isteyen kullanıcı seçildi.
            var kullanici = (from k in kullanicilar
                             where k.KullaniciAdi == this.kullaniciAdi
                             select k).ToList()[0];

            this.onaylandiMi = izin;
            if (izin == true)
            {
               
                //Değişiklik sonucu bakiye -'lenecek mi diye bi bakıldı.
                double olasiDurum = kullanici.Bakiye + this.degisiklikMiktari;
                if (olasiDurum >= 0)
                {
                    //bakiye değişikliği gerçekleşti.
                    kullanici.Bakiye += this.degisiklikMiktari;

                    //gerçekleşti olarak isaretlendi
                    this.gerceklestiMi = true;
                }
                else
                {
                    this.reddedildiMi = true;
                }
            
            }
            else
            {
                this.reddedildiMi = true;
            }

            //Dosya kaydedildi.
            Veriler.SaveData(kullanicilar);

            //işlem gerçekleştiyse ya da gerçekleşmesine izin verilmediyse TRUE döndür.
            if ( izin == false || this.gerceklestiMi == true )
                return true;
            //izin verildi fakat  işlem gerçekleşmediyse FALSE döndür.
            else
                return false;

            //FALSE dönmesi için izin verilmiş ama BAKİYEnin yetersiz olması lazım.

        }

        public string redNedeni()
        {
            if (reddedildiMi)
                return GetDegisiklikDurum();
            else
                return "";
        }

        public string GetDegisiklikDurum()
        {
            //Bakiye işleminin anlık durumunu döndürür.

            if(incelendiMi == true)
                if(reddedildiMi == true)
                    if(onaylandiMi == true)
                        return BakiyeIslemStatics.stdDurum.yetersizBakiye;
                    else
                        return BakiyeIslemStatics.stdDurum.reddedildi;
                else
                    return BakiyeIslemStatics.stdDurum.onaylandi;
            else
                return BakiyeIslemStatics.stdDurum.incelemede;

        }

    

    }

}

