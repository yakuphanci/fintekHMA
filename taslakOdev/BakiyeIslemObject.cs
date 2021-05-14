using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool degisiklikGerceklestir()
        {
            //incelenmediyse ve admin onayı verildiyse bu işlemleri yap. 


            this.gerceklesmeTarihi = DateTime.Now;


            if (this.onaylandiMi == true)
            {
                //kullanicilar Listesi çekildi
                var kullanicilar = JsonController.GetDataFromJSON<List<Kullanici>>(JsonController.GetJsonFromFile(@"kullanicilar.json"));

                //değişiklik isteyen kullanıcı seçildi.
                var kullanici = (from k in kullanicilar
                                 where k.KullaniciAdi == this.kullaniciAdi
                                 select k).ToList()[0];

                //Değişiklik sonucu bakiye -'lenecek mi diye bi bakıldı.
                double olasiDurum = kullanici.Bakiye + this.degisiklikMiktari;
                if (olasiDurum >= 0)
                {
                    //bakiye değişikliği gerçekleşti.
                    kullanici.Bakiye += this.degisiklikMiktari;

                    //gerçekleşti olarak isaretlendi

                    this.gerceklestiMi = true;

                    //Dosya kaydedildi.
                    JsonController.SaveJsonToFile(@"kullanicilar.json", kullanicilar);

                }
            }

            return this.gerceklestiMi;




        }


        public string GetDegisiklikDurum()
        {
            //Bakiye işleminin anlık durumunu döndürür.
            if (incelendiMi == true && onaylandiMi == true && gerceklestiMi == true)
                return BakiyeIslemStatics.stdDurum.onaylandi;
            else if (incelendiMi == true && onaylandiMi == true )
                return BakiyeIslemStatics.stdDurum.yetersizBakiye;
            else if (incelendiMi == true )
                return BakiyeIslemStatics.stdDurum.reddedildi;
            else
                return BakiyeIslemStatics.stdDurum.incelemede;
        }

        public string redNedeni()
        {
            //incelenmesine rağmen işlem gerçekleşmediyse red sebebini açıklamaya ekle.
            if (this.incelendiMi == true && this.gerceklestiMi == false)
                return  " - " + GetDegisiklikDurum();
            else
                return "";

        }

    }

}

