
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.groupBox1.Controls.Add(this.textBox_parola);
            this.groupBox1.Controls.Add(this.button_giris);
            this.groupBox1.Controls.Add(this.label_kullaniciAdi);
            this.groupBox1.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(24, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox_parola
            // 
            this.textBox_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_parola.Location = new System.Drawing.Point(21, 146);
            this.textBox_parola.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(315, 24);
            this.textBox_parola.TabIndex = 21;
            this.textBox_parola.Text = "123";
            this.textBox_parola.UseSystemPasswordChar = true;
            this.textBox_parola.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity);
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_giris.Location = new System.Drawing.Point(21, 193);
            this.button_giris.Margin = new System.Windows.Forms.Padding(4);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(317, 47);
            this.button_giris.TabIndex = 22;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullaniciAdi.Location = new System.Drawing.Point(16, 52);
            this.label_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(83, 16);
            this.label_kullaniciAdi.TabIndex = 23;
            this.label_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(21, 78);
            this.textBox_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(315, 24);
            this.textBox_kullaniciAdi.TabIndex = 20;
            this.textBox_kullaniciAdi.Text = "muro5759";
            this.textBox_kullaniciAdi.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity);
            // 
            // Form_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(407, 499);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giriş Yap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
    }
}