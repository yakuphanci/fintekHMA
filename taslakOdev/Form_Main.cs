using System;
using System.Windows.Forms;

namespace taslakOdev
{
    public partial class Form_Main : Form
    {
        #region Form Create
        public Form_Main()
        {
            InitializeComponent();
        }
        #endregion


        #region Giris Ekranina yonlendirme
        private void button_giris_Click(object sender, EventArgs e)
        {
            Form_Giris frm_giris = new Form_Giris(this);
            frm_giris.ShowDialog();
            
        }
        #endregion


        #region Kaydolma Ekranina yonlendirme
        private void button_kayitOl_Click(object sender, EventArgs e)
        {
            Form_Kaydol frm_kaydol = new Form_Kaydol();
            frm_kaydol.ShowDialog();
            
        }
        #endregion
    
    }
}
