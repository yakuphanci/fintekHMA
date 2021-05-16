using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taslakOdev
{
    class AlisIslemleri
    {
        /// <summary>
        /// Alış işleminin toplam maliyeti ve alınabilecek toplam ürün miktarı bilgisini önizler.
        /// </summary>
        /// <param name="aliciID">Alış işlemini yapacak kişi</param>
        /// <param name="kategoriID">Alış işlemi yapılacak ürün ID</param>
        /// <param name="istenenMiktar">Ne miktarda alış yapılmak isteniyor</param>
        /// <param name="toplamMaliyet">Tüm bu ürünleri alabilmek için toplam maliyet hesabı döndürür.</param>
        /// <param name="maksAlimMiktari">İstediği miktardan maksimum alabileceği kapasiteyi döndürür.</param>
        /// <returns>Sistemde istenen miktarda ürün olup olmadığı bilgisi döndürür.</returns>
        public static bool OnIzleme(string aliciID, uint kategoriID, int istenenMiktar, out double toplamMaliyet, out int maksAlimMiktari)
        {
            var alinabilirUrunler = Veriler.GetUcuzAktifPazarlar(kategoriID);
            toplamMaliyet = 0;
            maksAlimMiktari = 0;

            foreach (var alinabilirUrun in alinabilirUrunler)
            {
                if(alinabilirUrun.saticiID != aliciID)
                {
                    int dusulecekMiktar = 0;

                    //saticidan ne kadar urun alacagimizi hesapliyoruz.
                    if (alinabilirUrun.miktar <= istenenMiktar)
                        dusulecekMiktar = alinabilirUrun.miktar;
                    else
                        dusulecekMiktar = istenenMiktar;

                    //toplam maliyet hesabı için her satıcıdan alınan miktar ve birim fiyatı çarpılıp ekleniyor.
                    toplamMaliyet += dusulecekMiktar * (alinabilirUrun.fiyat);
                    maksAlimMiktari += dusulecekMiktar;
                    istenenMiktar -= dusulecekMiktar;
                }

                //Eger sistemde istedigimiz miktarda urun varsa TRUE dondur.
                if (istenenMiktar == 0)
                    break;
            }


            //Eger sistemde istenenMiktarda urun bulunmuyorsa FALSE döndür.
            //Eger sistemde istedigimiz miktarda urun varsa TRUE dondur.
            if (istenenMiktar == 0)
                return true;
            else
                return false;
        }
      
      
        /// <summary>
        /// Alıcı ile satıcılar arasındaki alışverişi gerçekler.
        /// </summary>
        /// <param name="aliciID">Alış işlemini yapan kullanıcı adı</param>
        /// <param name="kategoriID">Alış işlemi yapılacak ürün ID si</param>
        /// <param name="istenenMiktar">Ne miktarda ürün alınacagı bilgisi</param>
        /// <returns>İstenen miktarda ürün alıp alınamadığı bilgisini döndürür.</returns>
        public static bool AlisYap(string aliciID, uint kategoriID, int istenenMiktar)
        {
            
            var tumPazarlar = Veriler.GetSatilanUrunler();
            var alinabilirUrunler = Veriler.GetUcuzAktifPazarlar(kategoriID,tumPazarlar);

            foreach (var alinabilirUrun in alinabilirUrunler)
            {
                if(alinabilirUrun.saticiID != aliciID)
                {
                    int dusulecekMiktar = 0;
                    double devredilecekBakiye = 0;
                    //saticidan ne kadar urun alacagimizi hesapliyoruz.
                    if (alinabilirUrun.miktar <= istenenMiktar)
                        dusulecekMiktar = alinabilirUrun.miktar;
                    else
                        dusulecekMiktar = istenenMiktar;

                    istenenMiktar -= dusulecekMiktar;
                    devredilecekBakiye = alinabilirUrun.fiyat * dusulecekMiktar;
                    
                    //saticinin pazarindan miktari dustuk.
                    alinabilirUrun.miktar -= dusulecekMiktar;

                    //Alıcı ile satıcı arasındaki swap işlemi gerçekleşti.
                    Satis_Swap(aliciID, alinabilirUrun.saticiID, devredilecekBakiye);
                }

                //Eğer bir pazardaki tüm ürünler tamamen satıldıysa, o pazarı sistemden kaldır.
                if(alinabilirUrun.miktar == 0)
                {
                    tumPazarlar.Remove(alinabilirUrun);
                }

                if (istenenMiktar == 0)
                    break;
            }

            //Degisikligi kaydettik.
            Veriler.SaveData(tumPazarlar);

            //Eger sistemde istenenMiktarda urun bulunmuyorsa FALSE döndür.
            //Eger sistemde istedigimiz miktarda urun varsa TRUE dondur.
            if (istenenMiktar == 0)
                return true;
            else
                return false;
        }


        #region Bakiye Islem Kayit Olaylari
        private static BakiyeIslemObject Get_YeniBakiyeIslemi(string ilgiliKullanici, double miktar, short islem)
        {
            //yeni işlem oluştur.
            var yeniBakiyeIslem = new BakiyeIslemObject();
           
            //yeni işlem bilgileri doldur.
            yeniBakiyeIslem.ID = BenzersizIDOlusturucu.GetBakiyeIslemID();
            yeniBakiyeIslem.kullaniciAdi = ilgiliKullanici;
            yeniBakiyeIslem.islemTarihi = DateTime.Now;
            yeniBakiyeIslem.aciklama = (islem == +1) ? BakiyeIslemStatics.stdAciklama.Satis : BakiyeIslemStatics.stdAciklama.Alis;
            yeniBakiyeIslem.degisiklikMiktari = (miktar * islem);

            //Alış ve satış işlemi admine bağlı olmadan anlık gerçekleşsin.
            yeniBakiyeIslem.incelendiMi = true;
            yeniBakiyeIslem.IslemiIsle(true);

            return yeniBakiyeIslem;
        }

        private static void Save_yeniBakiyeIslemi(BakiyeIslemObject yeniBakiyeIslem)
        {
            var bakiyeIslemler = Veriler.GetBakiyeIslemleri();
            bakiyeIslemler.Add(yeniBakiyeIslem);
            Veriler.SaveData(bakiyeIslemler);
        }
        #endregion

        #region SATIS ve ALIS fonksiyonlari
        //Bakiye ekleme işlemi.
        private static void Yeni_SatisIslemi(string ilgiliKullanici , double bakiyeDegisimMiktari)
        {
            var yeniBakiyeIslemi = Get_YeniBakiyeIslemi(ilgiliKullanici, bakiyeDegisimMiktari, +1);
            Save_yeniBakiyeIslemi(yeniBakiyeIslemi);
        }


        //Bakiyeden çekme işlemi.
        private static void Yeni_AlisIslemi(string ilgiliKullanici, double bakiyeDegisimMiktari)
        {
            var yeniBakiyeIslemi = Get_YeniBakiyeIslemi(ilgiliKullanici, bakiyeDegisimMiktari, -1);
            Save_yeniBakiyeIslemi(yeniBakiyeIslemi);
        }

        private static void Satis_Swap(string aliciID, string saticiID, double bakiyeDegisimMiktari)
        {
            //Alıcıya alış işlemini, satıcıya satış işlemini yaptırıp
            //Bakiyelerinde değişikliği gerçekleştirdin.
            Yeni_AlisIslemi(aliciID, bakiyeDegisimMiktari);
            Yeni_SatisIslemi(saticiID, bakiyeDegisimMiktari);
        }

        #endregion


    }
}
