
namespace taslakOdev
{


    public class Kullanici
    {
        public string Adi;
        public string Soyadi;
        public string TCKNo;
        public string Adres;
         
        public string KullaniciAdi;
        public string Parola;
        public string TelefonNum;
        public string EPosta;

        public Yetki yetki;
        public Kullanici()
        {
            this.yetki = Yetki.Kullanici;
        }

        public override string ToString()
        {
            return
                "Adı: " + Adi +
                "\nSoyadı: " + Soyadi +
                "\nTC Kimlik Numarası: " + TCKNo +
                "\nAdres: " + Adres +
                "\nKullanıcı Adı: " + KullaniciAdi +
                "\nParola: " + Parola +
                "\nTelefon Numarası: " + TelefonNum +
                "\nE-Posta: " + EPosta;
        }
    }
        
}
