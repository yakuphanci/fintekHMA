
namespace taslakOdev
{
    partial class Form_KayıtOl
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_kayitSecond = new System.Windows.Forms.Panel();
            this.textBox_tckNo = new System.Windows.Forms.MaskedTextBox();
            this.textBox_telefonNo = new System.Windows.Forms.MaskedTextBox();
            this.button_kayitGeri = new System.Windows.Forms.Button();
            this.button_kayitTamamla = new System.Windows.Forms.Button();
            this.label_adres = new System.Windows.Forms.Label();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.label_telefonNo = new System.Windows.Forms.Label();
            this.label_tckNo = new System.Windows.Forms.Label();
            this.label_soyisim = new System.Windows.Forms.Label();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.label_isim = new System.Windows.Forms.Label();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.panel_kayitFirst = new System.Windows.Forms.Panel();
            this.textBox_ePosta = new System.Windows.Forms.TextBox();
            this.button_kayitDevam = new System.Windows.Forms.Button();
            this.label_reParola = new System.Windows.Forms.Label();
            this.textBox_reParola = new System.Windows.Forms.TextBox();
            this.label_parola = new System.Windows.Forms.Label();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label_ePosta = new System.Windows.Forms.Label();
            this.label_kullaniciAdi = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel_kayitSecond.SuspendLayout();
            this.panel_kayitFirst.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.groupBox1.Controls.Add(this.panel_kayitSecond);
            this.groupBox1.Controls.Add(this.panel_kayitFirst);
            this.groupBox1.Location = new System.Drawing.Point(25, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel_kayitSecond
            // 
            this.panel_kayitSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_kayitSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel_kayitSecond.Controls.Add(this.textBox_tckNo);
            this.panel_kayitSecond.Controls.Add(this.textBox_telefonNo);
            this.panel_kayitSecond.Controls.Add(this.button_kayitGeri);
            this.panel_kayitSecond.Controls.Add(this.button_kayitTamamla);
            this.panel_kayitSecond.Controls.Add(this.label_adres);
            this.panel_kayitSecond.Controls.Add(this.textBox_adres);
            this.panel_kayitSecond.Controls.Add(this.label_telefonNo);
            this.panel_kayitSecond.Controls.Add(this.label_tckNo);
            this.panel_kayitSecond.Controls.Add(this.label_soyisim);
            this.panel_kayitSecond.Controls.Add(this.textBox_soyisim);
            this.panel_kayitSecond.Controls.Add(this.label_isim);
            this.panel_kayitSecond.Controls.Add(this.textBox_isim);
            this.panel_kayitSecond.Location = new System.Drawing.Point(7, 13);
            this.panel_kayitSecond.Name = "panel_kayitSecond";
            this.panel_kayitSecond.Size = new System.Drawing.Size(359, 415);
            this.panel_kayitSecond.TabIndex = 23;
            this.panel_kayitSecond.Visible = false;
            // 
            // textBox_tckNo
            // 
            this.textBox_tckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_tckNo.Location = new System.Drawing.Point(29, 110);
            this.textBox_tckNo.Mask = "00000000000";
            this.textBox_tckNo.Name = "textBox_tckNo";
            this.textBox_tckNo.PromptChar = ' ';
            this.textBox_tckNo.Size = new System.Drawing.Size(304, 24);
            this.textBox_tckNo.TabIndex = 7;
            this.textBox_tckNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBox_tckNo.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_Second);
            // 
            // textBox_telefonNo
            // 
            this.textBox_telefonNo.BeepOnError = true;
            this.textBox_telefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_telefonNo.Location = new System.Drawing.Point(29, 159);
            this.textBox_telefonNo.Mask = "(999) 000-0000";
            this.textBox_telefonNo.Name = "textBox_telefonNo";
            this.textBox_telefonNo.PromptChar = ' ';
            this.textBox_telefonNo.Size = new System.Drawing.Size(304, 24);
            this.textBox_telefonNo.TabIndex = 8;
            this.textBox_telefonNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBox_telefonNo.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_Second);
            // 
            // button_kayitGeri
            // 
            this.button_kayitGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_kayitGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kayitGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kayitGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_kayitGeri.Location = new System.Drawing.Point(29, 338);
            this.button_kayitGeri.Name = "button_kayitGeri";
            this.button_kayitGeri.Size = new System.Drawing.Size(106, 34);
            this.button_kayitGeri.TabIndex = 28;
            this.button_kayitGeri.Text = "Geri";
            this.button_kayitGeri.UseVisualStyleBackColor = false;
            this.button_kayitGeri.Click += new System.EventHandler(this.button_kayitGeri_Click);
            // 
            // button_kayitTamamla
            // 
            this.button_kayitTamamla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_kayitTamamla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kayitTamamla.Enabled = false;
            this.button_kayitTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kayitTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_kayitTamamla.Location = new System.Drawing.Point(141, 338);
            this.button_kayitTamamla.Name = "button_kayitTamamla";
            this.button_kayitTamamla.Size = new System.Drawing.Size(192, 34);
            this.button_kayitTamamla.TabIndex = 10;
            this.button_kayitTamamla.Text = "Kaydı Tamamla";
            this.button_kayitTamamla.UseVisualStyleBackColor = false;
            this.button_kayitTamamla.Click += new System.EventHandler(this.button_kayitTamamla_Click);
            // 
            // label_adres
            // 
            this.label_adres.AutoSize = true;
            this.label_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_adres.Location = new System.Drawing.Point(26, 192);
            this.label_adres.Name = "label_adres";
            this.label_adres.Size = new System.Drawing.Size(47, 16);
            this.label_adres.TabIndex = 27;
            this.label_adres.Text = "Adres:";
            // 
            // textBox_adres
            // 
            this.textBox_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_adres.Location = new System.Drawing.Point(29, 211);
            this.textBox_adres.Multiline = true;
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(304, 121);
            this.textBox_adres.TabIndex = 9;
            this.textBox_adres.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_Second);
            // 
            // label_telefonNo
            // 
            this.label_telefonNo.AutoSize = true;
            this.label_telefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_telefonNo.Location = new System.Drawing.Point(26, 139);
            this.label_telefonNo.Name = "label_telefonNo";
            this.label_telefonNo.Size = new System.Drawing.Size(60, 16);
            this.label_telefonNo.TabIndex = 25;
            this.label_telefonNo.Text = "Telefon: ";
            // 
            // label_tckNo
            // 
            this.label_tckNo.AutoSize = true;
            this.label_tckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tckNo.Location = new System.Drawing.Point(26, 87);
            this.label_tckNo.Name = "label_tckNo";
            this.label_tckNo.Size = new System.Drawing.Size(91, 16);
            this.label_tckNo.TabIndex = 23;
            this.label_tckNo.Text = "TC. Kimlik No:";
            // 
            // label_soyisim
            // 
            this.label_soyisim.AutoSize = true;
            this.label_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_soyisim.Location = new System.Drawing.Point(181, 38);
            this.label_soyisim.Name = "label_soyisim";
            this.label_soyisim.Size = new System.Drawing.Size(59, 16);
            this.label_soyisim.TabIndex = 21;
            this.label_soyisim.Text = "Soyisim:";
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_soyisim.Location = new System.Drawing.Point(184, 57);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(149, 24);
            this.textBox_soyisim.TabIndex = 6;
            this.textBox_soyisim.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_Second);
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_isim.Location = new System.Drawing.Point(26, 38);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(38, 16);
            this.label_isim.TabIndex = 19;
            this.label_isim.Text = "İsim: ";
            // 
            // textBox_isim
            // 
            this.textBox_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_isim.Location = new System.Drawing.Point(29, 57);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(149, 24);
            this.textBox_isim.TabIndex = 5;
            this.textBox_isim.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_Second);
            // 
            // panel_kayitFirst
            // 
            this.panel_kayitFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_kayitFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel_kayitFirst.Controls.Add(this.textBox_ePosta);
            this.panel_kayitFirst.Controls.Add(this.button_kayitDevam);
            this.panel_kayitFirst.Controls.Add(this.label_reParola);
            this.panel_kayitFirst.Controls.Add(this.textBox_reParola);
            this.panel_kayitFirst.Controls.Add(this.label_parola);
            this.panel_kayitFirst.Controls.Add(this.textBox_parola);
            this.panel_kayitFirst.Controls.Add(this.label_ePosta);
            this.panel_kayitFirst.Controls.Add(this.label_kullaniciAdi);
            this.panel_kayitFirst.Controls.Add(this.textBox_kullaniciAdi);
            this.panel_kayitFirst.Location = new System.Drawing.Point(7, 13);
            this.panel_kayitFirst.Name = "panel_kayitFirst";
            this.panel_kayitFirst.Size = new System.Drawing.Size(359, 415);
            this.panel_kayitFirst.TabIndex = 22;
            // 
            // textBox_ePosta
            // 
            this.textBox_ePosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_ePosta.Location = new System.Drawing.Point(25, 134);
            this.textBox_ePosta.Name = "textBox_ePosta";
            this.textBox_ePosta.Size = new System.Drawing.Size(304, 24);
            this.textBox_ePosta.TabIndex = 1;
            this.textBox_ePosta.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_First);
            // 
            // button_kayitDevam
            // 
            this.button_kayitDevam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_kayitDevam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kayitDevam.Enabled = false;
            this.button_kayitDevam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kayitDevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_kayitDevam.Location = new System.Drawing.Point(25, 272);
            this.button_kayitDevam.Name = "button_kayitDevam";
            this.button_kayitDevam.Size = new System.Drawing.Size(304, 34);
            this.button_kayitDevam.TabIndex = 4;
            this.button_kayitDevam.Text = "Devam";
            this.button_kayitDevam.UseVisualStyleBackColor = false;
            this.button_kayitDevam.Click += new System.EventHandler(this.button_kayitDevam_Click);
            // 
            // label_reParola
            // 
            this.label_reParola.AutoSize = true;
            this.label_reParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_reParola.Location = new System.Drawing.Point(22, 212);
            this.label_reParola.Name = "label_reParola";
            this.label_reParola.Size = new System.Drawing.Size(86, 16);
            this.label_reParola.TabIndex = 19;
            this.label_reParola.Text = "Parola Onay:";
            // 
            // textBox_reParola
            // 
            this.textBox_reParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_reParola.Location = new System.Drawing.Point(25, 231);
            this.textBox_reParola.Name = "textBox_reParola";
            this.textBox_reParola.Size = new System.Drawing.Size(304, 24);
            this.textBox_reParola.TabIndex = 3;
            this.textBox_reParola.UseSystemPasswordChar = true;
            this.textBox_reParola.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_First);
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_parola.Location = new System.Drawing.Point(22, 164);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(51, 16);
            this.label_parola.TabIndex = 17;
            this.label_parola.Text = "Parola:";
            // 
            // textBox_parola
            // 
            this.textBox_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_parola.Location = new System.Drawing.Point(25, 183);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(304, 24);
            this.textBox_parola.TabIndex = 2;
            this.textBox_parola.UseSystemPasswordChar = true;
            this.textBox_parola.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_First);
            // 
            // label_ePosta
            // 
            this.label_ePosta.AutoSize = true;
            this.label_ePosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ePosta.Location = new System.Drawing.Point(22, 118);
            this.label_ePosta.Name = "label_ePosta";
            this.label_ePosta.Size = new System.Drawing.Size(59, 16);
            this.label_ePosta.TabIndex = 15;
            this.label_ePosta.Text = "E-Posta:";
            // 
            // label_kullaniciAdi
            // 
            this.label_kullaniciAdi.AutoSize = true;
            this.label_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullaniciAdi.Location = new System.Drawing.Point(22, 68);
            this.label_kullaniciAdi.Name = "label_kullaniciAdi";
            this.label_kullaniciAdi.Size = new System.Drawing.Size(83, 16);
            this.label_kullaniciAdi.TabIndex = 13;
            this.label_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(25, 87);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(304, 24);
            this.textBox_kullaniciAdi.TabIndex = 0;
            this.textBox_kullaniciAdi.TextChanged += new System.EventHandler(this.textBoxes_IsAllNotEmpity_First);
            // 
            // Form_KayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(423, 551);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_KayıtOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kayıt Ol";
            this.groupBox1.ResumeLayout(false);
            this.panel_kayitSecond.ResumeLayout(false);
            this.panel_kayitSecond.PerformLayout();
            this.panel_kayitFirst.ResumeLayout(false);
            this.panel_kayitFirst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_kayitSecond;
        private System.Windows.Forms.MaskedTextBox textBox_tckNo;
        private System.Windows.Forms.MaskedTextBox textBox_telefonNo;
        private System.Windows.Forms.Button button_kayitGeri;
        private System.Windows.Forms.Button button_kayitTamamla;
        private System.Windows.Forms.Label label_adres;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Label label_telefonNo;
        private System.Windows.Forms.Label label_tckNo;
        private System.Windows.Forms.Label label_soyisim;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.Label label_isim;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.Panel panel_kayitFirst;
        private System.Windows.Forms.TextBox textBox_ePosta;
        private System.Windows.Forms.Button button_kayitDevam;
        private System.Windows.Forms.Label label_reParola;
        private System.Windows.Forms.TextBox textBox_reParola;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label_ePosta;
        private System.Windows.Forms.Label label_kullaniciAdi;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
    }
}

