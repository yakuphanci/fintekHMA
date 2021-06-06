using System;

namespace taslakOdev
{
    public class SatilanUrun
    {
        public uint pazarID;
        public bool pazardaMi { get; set; } //Eğer pazardaki görünüme açılırsa bu true olacak.
        public string saticiID { get; set; }//Satıcının kullanıcı adı.
        public Urun urun { get; set; }
        public int miktar { get; set; }
        public double fiyat { get; set; }
        public DateTime tarih { get; set; }

  
 

        public override string ToString()
        {
            return "Yayın Durumu: " + pazardaMi + Environment.NewLine +
                   "Satıcı: " + saticiID + Environment.NewLine +
                   "Ürün Adı: " + urun.Adi + " Ürün ID: " + urun.ID + Environment.NewLine +
                   "Miktar: " + miktar + Environment.NewLine +
                   "Fiyat: " + fiyat + Environment.NewLine +
                   "Tarih: " + tarih + Environment.NewLine +
                   "Pazar ID: " + pazarID;
        }
    }

}
