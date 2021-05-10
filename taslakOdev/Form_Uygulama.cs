using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_Uygulama : Form
    {
        Form_Main g_frm_main;
        Kullanici g_aktifKullanici;
        public Form_Uygulama(Form_Main _frm_main, object _aktifKullanici)
        {
            InitializeComponent();
            this.g_frm_main = _frm_main;
            this.g_aktifKullanici = (Kullanici)_aktifKullanici;
            
            //Giriş kontrol taslak.
            textBox1.Text = "Giriş Yapan kullanıcı:\n\n " + g_aktifKullanici.ToString();
            if (g_aktifKullanici.yetki == Yetki.Admin)
                button1.Visible = true;
        }

        private void Form_Uygulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
