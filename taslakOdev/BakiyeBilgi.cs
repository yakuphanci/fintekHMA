using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taslakOdev
{
    public class BakiyeBilgi
    {
        public BakiyeBilgi(string _kullaniciAdi)
        {
            this.kullaniciAdi = _kullaniciAdi;
            this.bakiye = 0;
        }
        public BakiyeBilgi(string _kullaniciAdi, uint _bakiye)
        {
            this.kullaniciAdi = _kullaniciAdi;
            this.bakiye = _bakiye;
        }
        public string kullaniciAdi { get; private set; }
        private uint bakiye;
        public uint Bakiye { get; }
        public void EkleBakiye(uint eklenecekMiktar)
        {
            //Bakiyeye ekleme yapıyor.
            this.bakiye += eklenecekMiktar;
        }
        public bool AzaltBakiye(uint dusulecekMiktar)
        {
            //Yeterli bakiye varsa bakiyeden harcama yapabilecek.
            bool durum = false;
            if(this.bakiye >= dusulecekMiktar)
            {
                this.bakiye -= dusulecekMiktar;
                durum = true;
            }
            return durum;
        }

    }
}
