
namespace taslakOdev
{
    partial class Form_UrunEkle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_onayla = new System.Windows.Forms.Button();
            this.numericUpDown_miktar = new System.Windows.Forms.NumericUpDown();
            this.label_miktar = new System.Windows.Forms.Label();
            this.label_fiyat = new System.Windows.Forms.Label();
            this.textBox_fiyat = new System.Windows.Forms.TextBox();
            this.label_kategori = new System.Windows.Forms.Label();
            this.comboBox_kategoriler = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_onayla);
            this.panel1.Controls.Add(this.numericUpDown_miktar);
            this.panel1.Controls.Add(this.label_miktar);
            this.panel1.Controls.Add(this.label_fiyat);
            this.panel1.Controls.Add(this.textBox_fiyat);
            this.panel1.Controls.Add(this.label_kategori);
            this.panel1.Controls.Add(this.comboBox_kategoriler);
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 306);
            this.panel1.TabIndex = 0;
            // 
            // button_onayla
            // 
            this.button_onayla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_onayla.Location = new System.Drawing.Point(39, 221);
            this.button_onayla.Name = "button_onayla";
            this.button_onayla.Size = new System.Drawing.Size(210, 35);
            this.button_onayla.TabIndex = 11;
            this.button_onayla.Text = "Onayla";
            this.button_onayla.UseVisualStyleBackColor = true;
            this.button_onayla.Click += new System.EventHandler(this.button_onayla_Click);
            // 
            // numericUpDown_miktar
            // 
            this.numericUpDown_miktar.Location = new System.Drawing.Point(39, 126);
            this.numericUpDown_miktar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_miktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_miktar.Name = "numericUpDown_miktar";
            this.numericUpDown_miktar.Size = new System.Drawing.Size(210, 24);
            this.numericUpDown_miktar.TabIndex = 6;
            this.numericUpDown_miktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_miktar
            // 
            this.label_miktar.AutoSize = true;
            this.label_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_miktar.Location = new System.Drawing.Point(36, 106);
            this.label_miktar.Name = "label_miktar";
            this.label_miktar.Size = new System.Drawing.Size(79, 17);
            this.label_miktar.TabIndex = 9;
            this.label_miktar.Text = "Miktar (kg):";
            // 
            // label_fiyat
            // 
            this.label_fiyat.AutoSize = true;
            this.label_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_fiyat.Location = new System.Drawing.Point(36, 162);
            this.label_fiyat.Name = "label_fiyat";
            this.label_fiyat.Size = new System.Drawing.Size(102, 17);
            this.label_fiyat.TabIndex = 7;
            this.label_fiyat.Text = "Birim Fiyatı (₺):";
            // 
            // textBox_fiyat
            // 
            this.textBox_fiyat.Location = new System.Drawing.Point(39, 182);
            this.textBox_fiyat.Name = "textBox_fiyat";
            this.textBox_fiyat.Size = new System.Drawing.Size(210, 24);
            this.textBox_fiyat.TabIndex = 8;
            // 
            // label_kategori
            // 
            this.label_kategori.AutoSize = true;
            this.label_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_kategori.Location = new System.Drawing.Point(36, 51);
            this.label_kategori.Name = "label_kategori";
            this.label_kategori.Size = new System.Drawing.Size(110, 17);
            this.label_kategori.TabIndex = 5;
            this.label_kategori.Text = "Ürün Kategorisi:";
            // 
            // comboBox_kategoriler
            // 
            this.comboBox_kategoriler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_kategoriler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_kategoriler.FormattingEnabled = true;
            this.comboBox_kategoriler.Location = new System.Drawing.Point(39, 71);
            this.comboBox_kategoriler.Name = "comboBox_kategoriler";
            this.comboBox_kategoriler.Size = new System.Drawing.Size(210, 26);
            this.comboBox_kategoriler.TabIndex = 4;
            // 
            // Form_UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(375, 372);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_UrunEkle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_UrunEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_onayla;
        private System.Windows.Forms.NumericUpDown numericUpDown_miktar;
        private System.Windows.Forms.Label label_miktar;
        private System.Windows.Forms.Label label_fiyat;
        private System.Windows.Forms.TextBox textBox_fiyat;
        private System.Windows.Forms.Label label_kategori;
        private System.Windows.Forms.ComboBox comboBox_kategoriler;
    }
}