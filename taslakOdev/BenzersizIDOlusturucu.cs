namespace taslakOdev
{
    //Benzerisz ID'leri tutar. 
    public class IDTutucu
    {
        public uint pazarID;
        public uint urunID;
        public uint bakiyeIslemID;
    }

    public static class BenzersizIDOlusturucu
    {
        //Benzersiz ID'leri tuttugu dosyadan en son kullandıgı id'yi çeker 
        //ve bir sonraki numarayı verir. Kendini güncelleyip kaydeder.
        public static uint GetPazarID()
        {
            var idTutucu = Veriler.GetBenzersizIDTutucu();
            idTutucu.pazarID++;
            Veriler.SaveData(idTutucu);
            return idTutucu.pazarID;
        }
        public static uint GetUrunID()
        {
            var idTutucu = Veriler.GetBenzersizIDTutucu();
            idTutucu.urunID++;
            Veriler.SaveData(idTutucu);
            return idTutucu.urunID;
        }
        public static uint GetBakiyeIslemID()
        {
            var idTutucu = Veriler.GetBenzersizIDTutucu();
            idTutucu.bakiyeIslemID++;
            Veriler.SaveData(idTutucu);
            return idTutucu.bakiyeIslemID;
        }

    }
}
