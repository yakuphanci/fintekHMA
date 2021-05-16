
namespace taslakOdev
{
    partial class Form_AlisEmri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AlisEmri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_onayla = new System.Windows.Forms.Button();
            this.numericUpDown_miktar = new System.Windows.Forms.NumericUpDown();
            this.label_miktar = new System.Windows.Forms.Label();
            this.label_kategori = new System.Windows.Forms.Label();
            this.comboBox_kategoriler = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_onayla);
            this.groupBox1.Controls.Add(this.numericUpDown_miktar);
            this.groupBox1.Controls.Add(this.label_miktar);
            this.groupBox1.Controls.Add(this.label_kategori);
            this.groupBox1.Controls.Add(this.comboBox_kategoriler);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(44, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Alış Emri";
            // 
            // button_onayla
            // 
            this.button_onayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_onayla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_onayla.Location = new System.Drawing.Point(43, 196);
            this.button_onayla.Name = "button_onayla";
            this.button_onayla.Size = new System.Drawing.Size(210, 35);
            this.button_onayla.TabIndex = 18;
            this.button_onayla.Text = "Onayla";
            this.button_onayla.UseVisualStyleBackColor = false;
            this.button_onayla.Click += new System.EventHandler(this.button_onayla_Click);
            // 
            // numericUpDown_miktar
            // 
            this.numericUpDown_miktar.Location = new System.Drawing.Point(43, 156);
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
            this.numericUpDown_miktar.TabIndex = 14;
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
            this.label_miktar.Location = new System.Drawing.Point(40, 136);
            this.label_miktar.Name = "label_miktar";
            this.label_miktar.Size = new System.Drawing.Size(79, 17);
            this.label_miktar.TabIndex = 17;
            this.label_miktar.Text = "Miktar (kg):";
            // 
            // label_kategori
            // 
            this.label_kategori.AutoSize = true;
            this.label_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_kategori.Location = new System.Drawing.Point(40, 81);
            this.label_kategori.Name = "label_kategori";
            this.label_kategori.Size = new System.Drawing.Size(110, 17);
            this.label_kategori.TabIndex = 13;
            this.label_kategori.Text = "Ürün Kategorisi:";
            // 
            // comboBox_kategoriler
            // 
            this.comboBox_kategoriler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_kategoriler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_kategoriler.FormattingEnabled = true;
            this.comboBox_kategoriler.Location = new System.Drawing.Point(43, 101);
            this.comboBox_kategoriler.Name = "comboBox_kategoriler";
            this.comboBox_kategoriler.Size = new System.Drawing.Size(210, 26);
            this.comboBox_kategoriler.TabIndex = 12;
            this.comboBox_kategoriler.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategoriler_SelectedIndexChanged);
            // 
            // Form_AlisEmri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(383, 384);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AlisEmri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Alış Penceresi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_onayla;
        private System.Windows.Forms.NumericUpDown numericUpDown_miktar;
        private System.Windows.Forms.Label label_miktar;
        private System.Windows.Forms.Label label_kategori;
        private System.Windows.Forms.ComboBox comboBox_kategoriler;
    }
}