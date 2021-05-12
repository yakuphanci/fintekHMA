using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taslakOdev
{
    public static class JsonController
    {

        //Parametre olarak aldığı nesneyi json formatına çevirir ve parametre olarak aldığı konuma kaydeder.
        public static void SaveJsonToFile(string filePath, object data)
        {
            File.WriteAllText(filePath, ConvertToJSON(data));
        }


        //Dosya konumu parametre olarak gönderilen JSON veriyi geri döndürür.
        public static string GetJsonFromFile(string filePath)
        {
            try
            {
                //Konumdan dosyayı okur.
                string json = File.ReadAllText(filePath);
                //veriyi geri döndürür.
                return json;
            }
            catch (Exception)
            {

                return string.Empty;
            }

        }


        //JSON veriyi istenilen formata çevirip geri döndürür.
        public static T GetDataFromJSON<T>(string JSON) where T : new()
        {
            //Parametre olarak gönderilen JSON verisini belirtilen T tipine çevirir. 
            //Eğer JSON verisi NULLsa belitilen T tipinde obje oluşturulup geri döndürülür.
            try
            {
                //Eğer hata yoksa ama null ise dosya, istenen türde yeni boş bir data döndür.
                var data = (T)(JsonConvert.DeserializeObject(JSON, typeof(T)) ?? new T());
                return data;
            }
            catch (Exception)
            {
                //Eğer mevcut depolanan veride hata varsa istenen türde yeni boş veri döndür.
                return new T();
            }
            
        }


        //Bir objeyi JSON formatında geri döndürür.
        private static string ConvertToJSON(object kullanicilar)
        {
            return JsonConvert.SerializeObject(kullanicilar);
        }


    }
}
