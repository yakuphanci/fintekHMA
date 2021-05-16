using System;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_Giris : Form
    {
        #region Form Create & Main Form tutucu
        Form_Main g_frm_main;
        public Form_Giris(Form_Main _frm_main)
        {
            InitializeComponent();
            this.g_frm_main = _frm_main;
        }
        #endregion


        #region Buton Giris
        private void button_giris_Click(object sender, EventArgs e)
        {

            var kullanicilar = Veriler.GetKullanicilar();
            var girisKullanici = Veriler.GetKullanici(textBox_kullaniciAdi.Text);
           
            //girilen bilgilere uygun kullanıcı varsa giriş işlemini gerçekleştir.
            if(girisKullanici != null && girisKullanici.Parola == textBox_parola.Text)
            {
                g_frm_main.Hide();
                this.Hide();
                this.Close();
                #region Adminse..
                if (girisKullanici.yetki == Yetki.Admin)
                {
                    Form_AdminPanel frm_adminPanel = new Form_AdminPanel(g_frm_main, girisKullanici);
                    frm_adminPanel.Show();
                }
                #endregion
                #region Degilse...
                else
                { 
                    Form_Uygulama frm_uygulama = new Form_Uygulama(g_frm_main, girisKullanici);
                    frm_uygulama.Show();
                }
                #endregion

                
            }
            else
                Mesajlar.UyariMesaji(
                    "Kullanıcı Adınız veya parolanızı hatalı girdiniz. Lütfen gözden geçirip tekrar deneyiniz. Eğer sisteme kayıtlı değilseniz lütfen kayıt olunuz.",
                    "Geçersiz Kullanıcı Adı veya Parola");


        }
        #endregion


        #region Tum TextBoxlar dolduysa butonu aktif etme
        private void textBoxes_IsAllNotEmpity(object sender, EventArgs e)
        {
            if (textBox_kullaniciAdi.Text.Length > 0 && textBox_parola.Text.Length > 0)
                button_giris.Enabled = true;
            else
                button_giris.Enabled = false;
        }
        #endregion

    }
}
