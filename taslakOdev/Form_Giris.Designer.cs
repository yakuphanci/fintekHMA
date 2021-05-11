
namespace taslakOdev
{
    partial class Form_Giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_giris = new System.Windows.Forms.Panel();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.label_parola = new System.Windows.Forms.Label();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.panel_giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_giris
            // 
            this.panel_giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_giris.Controls.Add(this.textBox_parola);
            this.panel_giris.Controls.Add(this.button_giris);
            this.panel_giris.Controls.Add(this.label_parola);
            this.panel_giris.Controls.Add(this.label_kullaniciAdi);
            this.panel_giris.Controls.Add(this.textBox_kullaniciAdi);
            this.panel_giris.Location = new System.Drawing.Point(37, 161);
            this.panel_giris.Name = "panel_giris";
            this.panel_giris.Size = new System.Drawing.Size(359, 215);
            this.panel_giris.TabIndex = 22;
            // 
            // textBox_parola
            // 
            this.textBox_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_parola.Location = new System.Drawing.Point(29, 106);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(304, 24);
            this.textBox_parola.TabIndex = 2;
            this.textBox_parola.Text = "123";
            this.textBox_parola.UseSystemPasswordChar = true;
            this.textBox_parola.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity);
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_giris.Location = new System.Drawing.Point(29, 140);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(304, 34);
            this.button_giris.TabIndex = 3;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_parola.Location = new System.Drawing.Point(26, 87);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(54, 16);
            this.label_parola.TabIndex = 23;
            this.label_parola.Text = "Parola: ";
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullaniciAdi.Location = new System.Drawing.Point(26, 38);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(83, 16);
            this.label_kullaniciAdi.TabIndex = 19;
            this.label_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(29, 57);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(304, 24);
            this.textBox_kullaniciAdi.TabIndex = 1;
            this.textBox_kullaniciAdi.Text = "yakuphanci";
            this.textBox_kullaniciAdi.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity);
            // 
            // Form_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 518);
            this.Controls.Add(this.panel_giris);
            this.Name = "Form_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giriş Yap";
            this.panel_giris.ResumeLayout(false);
            this.panel_giris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_giris;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.TextBox textBox_parola;
    }
}