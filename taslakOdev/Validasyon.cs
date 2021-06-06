using System.Linq;
using System.Text.RegularExpressions;

namespace taslakOdev
{
    public static class Validasyon
    {
        #region Validasyon Fonksiyonları
        //Parola geçerlilik testi yapar. İki parolayı kıyaslar eşitmi diye.
        public static bool IsValidPassword(string pwdFirst, string pwdSecond)
        {

            bool onay = (pwdFirst == pwdSecond);
            if (!onay)
                Mesajlar.UyariMesaji("Parolalar eşleşmiyor. Lütfen parolanızı kontrol edin.", "Parolalar eşleşmiyor!");
            return onay;
        }

        //Kullanıcı adının geçerli olup olmadıgını kontrol eder.
        public static bool IsValidNickName(string nickName)
        {
            bool onay = false;
            //Kullanıcı adında BOŞLUK olup olmadıgı kıyaslanıyor.
            onay = !nickName.Contains(' ');
            if (!onay)
                Mesajlar.UyariMesaji("Kullanıcı adınızda lütfen BOŞLUK karakteri kullanmayın.", "Geçersiz Kullanıcı Adı!");


            return onay;
        }

        //EPostanın geçerli olup olmadığına bakar.
        public static bool  IsValidEmail(string email)
        {
            // Email onaylama v1
            //EMail verisi @ sembolü içeriyorsa onaylar. 
            bool onay = email.Contains("@");
            if (!onay)
                Mesajlar.UyariMesaji("Lütfen geçerli bir E-Posta giriniz.", "Geçersiz E-Posta");
            return onay;
        }

        //İsmin geçerli olup olmadıgına bakar.
        public static bool IsValidName(string name)
        {
            //Sadece harf ve boşluk olacak şekilde kontrol edilir.
            Regex kontrol = new Regex(@"[\p{L} ]+$");
            bool onay = kontrol.IsMatch(name);
            if (!onay)
                Mesajlar.UyariMesaji("İsminizde sadece harf ve boşluk olabilir.", "Uygunsuz isim");
            return onay;
        }

        //Tckimlik numarasının geçerli olup olmadıgı kontrol edilir.
        public static bool IsValidTCKNO(string TCKNo)
        {
            bool onay = false;
            onay = !TCKNo.Contains(' ') && TCKNo.Length == 11;
            if (!onay)
                Mesajlar.UyariMesaji("Lütfen 11 Haneli TC Kimlik Numaranızı giriniz.", "Geçersiz TCKNo");
            return onay;
        }

        //Adres bilgisi girilmiş mi diye kontrol edilir. En az üç karakter.
        public static bool IsValidAdres(string adres)
        {
            bool onay = false;
            onay = adres.Length > 3;
            if (!onay)
                Mesajlar.UyariMesaji("Adresinizi eksiksiz giriniz lütfen.", "Eksik Adres");
            return onay;
        }

        //Telefon numarası onaylama işlemi yapar.
        public static bool IsValidTelNum(string telNum)
        {
            bool onay = false;
            onay = !telNum.Contains(' ') && telNum.Length == 10;
            if (!onay)
                Mesajlar.UyariMesaji("Lütfen telefon numaranızı eksiksiz giriniz.", "Hatalı telefon numarası");
            return onay;
        }
        #endregion
    }
}