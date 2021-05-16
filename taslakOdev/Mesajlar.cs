using System.Windows.Forms;

namespace taslakOdev
{
    public static class Mesajlar
    {

        public static void BilgiMesaji(string message, string tittle)
        {
            MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void UyariMesaji(string message, string tittle)
        {
            MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Basarili()
        {
            MessageBox.Show("İşlem başarılı bir şekilde tamamlandı.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Uyari()
        {
            MessageBox.Show("İşlem tamamlanamadı.", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Hata()
        {
            MessageBox.Show("Hay aksi! Bir hata meydana geldi.", "Hay aksi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Hata(string message)
        {
            MessageBox.Show("Hay aksi! Bir hata meydana geldi.\nHata mesajı: " + message, "Hay aksi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SadeMesaj(string message, string tittle)
        {
            MessageBox.Show(message, tittle);
        }



    }
}
