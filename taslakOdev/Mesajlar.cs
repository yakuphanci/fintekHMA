using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



    }
}
