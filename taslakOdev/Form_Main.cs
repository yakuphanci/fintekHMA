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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            Form_Giris frm_giris = new Form_Giris(this);
            frm_giris.ShowDialog();
            
        }

        private void button_kayitOl_Click(object sender, EventArgs e)
        {
            Form_KayıtOl frm_kaydol = new Form_KayıtOl();
            frm_kaydol.ShowDialog();
            
        }
    }
}
