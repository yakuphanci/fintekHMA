using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taslakOdev
{
    public class IDTutucu
    {
        public uint pazarID;
        public uint urunID;

    }

    public static class BenzersizIDOlusturucu
    {
        public static uint GetPazarID()
        {
            var idTutucu = JsonController.GetDataFromJSON<IDTutucu>(JsonController.GetJsonFromFile(@"benzersizIDler.json"));
            idTutucu.pazarID++;
            JsonController.SaveJsonToFile(@"benzersizIDler.json", idTutucu);
            return idTutucu.pazarID;
        }
        public static uint GetUrunID()
        {
            var idTutucu = JsonController.GetDataFromJSON<IDTutucu>(JsonController.GetJsonFromFile(@"benzersizIDler.json"));
            idTutucu.urunID++;
            JsonController.SaveJsonToFile(@"benzersizIDler.json", idTutucu);
            return idTutucu.urunID;
        }


    }
}
