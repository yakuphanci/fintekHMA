using System;
using System.Collections.Generic;
using System.Linq;

namespace taslakOdev
{

    public static class Veriler
    {
        public static class stdVeriYollari
        {
            public static string path_Kullanicilar { get { return @"kullanicilar.json"; } }
            public static string path_BakiyeIslemleri { get { return @"bakiyeIslemler.json"; } }
            public static string path_BenzersizIDler { get { return @"benzersizIDler.json"; } }
            public static string path_SatilanUrunler { get { return @"SatilanUrunler.json"; } }
            public static string path_Urunler { get { return @"urunler.json"; } }

        }
     
       
        #region Veri Cekme
     
        public static List<Kullanici> GetKullanicilar()
        {
            var json_kullanicilar = JsonController.GetJsonFromFile(Veriler.stdVeriYollari.path_Kullanicilar);
            var kullanicilar = JsonController.GetDataFromJSON<List<Kullanici>>(json_kullanicilar);
            return kullanicilar;
        }

        public static List<BakiyeIslemObject> GetBakiyeIslemleri()
        {
            var json_bakiyeIslemler = JsonController.GetJsonFromFile(Veriler.stdVeriYollari.path_BakiyeIslemleri);
            var bakiyeIslemler = JsonController.GetDataFromJSON<List<BakiyeIslemObject>>(json_bakiyeIslemler);

            return bakiyeIslemler;
        }

        public static List<SatilanUrun> GetSatilanUrunler()
        {
            var json_pazarlar = JsonController.GetJsonFromFile(Veriler.stdVeriYollari.path_SatilanUrunler);
            var pazarlar = JsonController.GetDataFromJSON<List<SatilanUrun>>(json_pazarlar);
            return pazarlar;
        }

        public static List<Urun> GetUrunTurleri()
        {
            var json_urunler = JsonController.GetJsonFromFile(Veriler.stdVeriYollari.path_Urunler);
            var urunler = JsonController.GetDataFromJSON<List<Urun>>(json_urunler);
            return urunler;
        }

        public static IDTutucu GetBenzersizIDTutucu()
        {
            var json_idTutucu = JsonController.GetJsonFromFile(Veriler.stdVeriYollari.path_BenzersizIDler);
            var idTutucu = JsonController.GetDataFromJSON<IDTutucu>(json_idTutucu);
            return idTutucu;
        }

        #region Ozellestirilmis Veri cekme islemleri
        
        #region Ozellestirilmis kullanici cekme fonksiyonlari
        public static Kullanici GetKullanici(string kullaniciAdi)
        {
            try
            {
                var kullanici = (from k in GetKullanicilar()
                                 where
                                 k.KullaniciAdi == kullaniciAdi
                                 select k).ToList()[0];

                return kullanici;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        #endregion


        #region Ozellestirilmis pazar cekme fonksiyonlari

        /// <summary>
        /// Aktif(Onaylanmis) urun satis pazarlarini dondurur.
        /// </summary>
        public static List<SatilanUrun> GetAktifPazarlar()
        {
            var onayliSatilanUrunler = (from su in GetSatilanUrunler()
                                       where su.pazardaMi == true
                                       orderby su.tarih descending
                                       select su).ToList();
            return onayliSatilanUrunler;
        }

        /// <summary>
        /// Pasif pazarlari geri dondurur.
        /// </summary>
        public static List<SatilanUrun> GetPasifPazarlar()
        {
            var beklemedekiUrunler = (from su in GetSatilanUrunler()
                                     where su.pazardaMi == false
                                     orderby su.tarih descending
                                     select su).ToList();
            return beklemedekiUrunler;
        }
       
        /// <summary>
        /// Kategori ID (urun ID)'ye ait aktif pazarlari dondurur.
        /// </summary>
        /// <param name="kategoriID">Bu degere gore filtrelenecek</param>
        public static List<SatilanUrun> GetAktifPazarlar(uint kategoriID)
        {
            var  onayliSatilanUrunler= (from su in GetSatilanUrunler()
                                        where su.pazardaMi == true &&
                                        su.urun.ID == kategoriID
                                        orderby su.tarih descending
                                        select su).ToList();

            return onayliSatilanUrunler;
        }

        public static List<SatilanUrun> GetUcuzAktifPazarlar()
        {
            var ucuzSatilanUrunler = (from su in GetAktifPazarlar()
                                        orderby su.fiyat, su.tarih ascending
                                        select su).ToList();
            return ucuzSatilanUrunler;
        }
       
        public static List<SatilanUrun> GetUcuzAktifPazarlar(uint kategoriID)
        {
            var ucuzSatilanUrunler = (from su in GetAktifPazarlar(kategoriID)
                                      orderby su.fiyat, su.tarih ascending
                                      select su).ToList();
            return ucuzSatilanUrunler;
        }

        public static List<SatilanUrun> GetUcuzAktifPazarlar(uint kategoriID, List<SatilanUrun> pazarlar)
        {
            var ucuzSatilanUrunler = (from su in pazarlar
                                      where 
                                      su.pazardaMi == true &&
                                      su.urun.ID == kategoriID
                                      orderby su.fiyat ascending
                                      select su).ToList();
            return ucuzSatilanUrunler;
        }

        public static List<SatilanUrun> GetKullaniciAktifPazarlari(string kullaniciAdi)
        {
            var yayindakiUrunler = (from su in GetAktifPazarlar()
                                   where  su.saticiID == kullaniciAdi
                                   orderby su.tarih descending
                                   select su).ToList();
            return yayindakiUrunler;
        }

        public static List<SatilanUrun> GetKullaniciPasifPazarlari(string kullaniciAdi)
        {
            var beklemedekiUrunler = (from su in GetPasifPazarlar()
                                     where su.saticiID == kullaniciAdi
                                     orderby su.tarih descending
                                     select su).ToList();
            return beklemedekiUrunler;
        }

        public static SatilanUrun GetPazar(uint pazarID)
        {
            try
            {
                var pazar = (from su in GetSatilanUrunler()
                             where su.pazarID == pazarID
                             select su).ToList()[0];
                return pazar;
            }
            catch (Exception)
            {
                return null;
            }
          
        }

        public static SatilanUrun GetPazar(uint pazarID, List<SatilanUrun> pazarlar)
        {
            try
            {
                var pazar = (from su in pazarlar
                             where su.pazarID == pazarID
                             select su).ToList()[0];
                return pazar;
            }
            catch (Exception)
            {
                return null;
            }

        }
        #endregion


        #region Ozellestirilmis urun cekme fonksiyonlari
        public static Urun GetUrunTuru(uint urunID)
        {
            try
            {
                var urun = (from u in GetUrunTurleri()
                            where u.ID == urunID
                            select u).ToList()[0];
                return urun;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public static Urun GetUrunTuru(uint urunID, List<Urun> urunler)
        {
            try
            {
                var urun = (from u in urunler
                            where u.ID == urunID
                            select u).ToList()[0];
                return urun;
            }
            catch (Exception)
            {

                return null;
            }

        }

        #endregion


        #region Ozellestirilmis bakiye islemi cekme fonksiyonlari
        public static List<BakiyeIslemObject> GetBekleyenBakiyeIslemleri()
        {
            var bekleyenIslemler = (from bi in GetBakiyeIslemleri()
                                                 where  bi.incelendiMi == false
                                                 orderby bi.islemTarihi descending
                                                 select bi).ToList();
            return bekleyenIslemler;
        }

        public static List<BakiyeIslemObject> GetGecmisBakiyeIslemleri()
        {
            var gecmisIslemler = (from bi in GetBakiyeIslemleri()
                                    where bi.incelendiMi == true
                                    orderby bi.islemTarihi descending
                                    select bi).ToList();
            return gecmisIslemler;
        }

        public static List<BakiyeIslemObject> GetKullanicininBekleyenBakiyeIslemleri(string kullaniciAdi)
        {
            var bekleyenIslemler = (from bi in GetBekleyenBakiyeIslemleri()
                                    where bi.kullaniciAdi == kullaniciAdi
                                    orderby bi.islemTarihi descending
                                    select bi).ToList();
            return bekleyenIslemler;
        }

        public static List<BakiyeIslemObject> GetKullanicininGecmisBakiyeIslemleri(string kullaniciAdi)
        {
            var kullanicininBekleyenIslemleri = (from bi in GetGecmisBakiyeIslemleri()
                                                 where bi.kullaniciAdi == kullaniciAdi
                                                 orderby bi.gerceklesmeTarihi descending
                                                 select bi).ToList();
            return kullanicininBekleyenIslemleri;
        }

        public static BakiyeIslemObject  GetBakiyeIslemi(uint islemID)
        {
            try
            {
                var islem = (from bi in GetBakiyeIslemleri()
                             where bi.ID == islemID
                             select bi).ToList()[0];
                return islem;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static BakiyeIslemObject GetBakiyeIslemi(uint islemID, List<BakiyeIslemObject> bakiyeIslemleri)
        {
            try
            {
                var islem = (from bi in bakiyeIslemleri
                             where bi.ID == islemID
                             select bi).ToList()[0];
                return islem;
            }
            catch (Exception)
            {

                return null;
            }
        }

        #endregion

        #endregion


        #endregion


        #region Veri Kaydetme
        //Yollanılan verinin ilgili bölüme kaydedilme islemini yapar.
        public static bool SaveData(object sender)
        {
            if (sender is List<Kullanici>)
                JsonController.SaveJsonToFile(Veriler.stdVeriYollari.path_Kullanicilar, sender);
            else if (sender is List<BakiyeIslemObject>)
                JsonController.SaveJsonToFile(Veriler.stdVeriYollari.path_BakiyeIslemleri, sender);
            else if (sender is IDTutucu)
                JsonController.SaveJsonToFile(Veriler.stdVeriYollari.path_BenzersizIDler, sender);
            else if (sender is List<SatilanUrun>)
                JsonController.SaveJsonToFile(Veriler.stdVeriYollari.path_SatilanUrunler, sender);
            else if (sender is List<Urun>)
                JsonController.SaveJsonToFile(Veriler.stdVeriYollari.path_Urunler, sender);
            else
                return false;
            //else girerse false döndürür(kaydedilmedi).
            //girmezse true döndürür(kaydedildi).
            return true;
        }
        #endregion
    }
}
