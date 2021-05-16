
namespace taslakOdev
{
    partial class Form_UrunPazar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UrunPazar));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_alisEmri = new System.Windows.Forms.Button();
            this.button_bakiyeIslemleri = new System.Windows.Forms.Button();
            this.button_kullaniciPazari = new System.Windows.Forms.Button();
            this.label_bakiye = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guvenliCikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_pazarlar = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_pazarlar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_urun = new System.Windows.Forms.Panel();
            this.label_tarihValue = new System.Windows.Forms.Label();
            this.label_tarihTittle = new System.Windows.Forms.Label();
            this.label_saticiValue = new System.Windows.Forms.Label();
            this.label_saticiTittle = new System.Windows.Forms.Label();
            this.label_fiyatValue = new System.Windows.Forms.Label();
            this.label_fiyatTittle = new System.Windows.Forms.Label();
            this.label_miktarValue = new System.Windows.Forms.Label();
            this.label_miktarTittle = new System.Windows.Forms.Label();
            this.label_urunAdi = new System.Windows.Forms.Label();
            this.pictureBox_urunResim = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox_pazarlar.SuspendLayout();
            this.flowLayoutPanel_pazarlar.SuspendLayout();
            this.panel_urun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_urunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button_alisEmri);
            this.panel_menu.Controls.Add(this.button_bakiyeIslemleri);
            this.panel_menu.Controls.Add(this.button_kullaniciPazari);
            this.panel_menu.Controls.Add(this.label_bakiye);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel_menu.Size = new System.Drawing.Size(765, 49);
            this.panel_menu.TabIndex = 6;
            // 
            // button_alisEmri
            // 
            this.button_alisEmri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_alisEmri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_alisEmri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_alisEmri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alisEmri.Location = new System.Drawing.Point(428, 8);
            this.button_alisEmri.Name = "button_alisEmri";
            this.button_alisEmri.Size = new System.Drawing.Size(162, 34);
            this.button_alisEmri.TabIndex = 8;
            this.button_alisEmri.Text = "Alış Emri";
            this.button_alisEmri.UseVisualStyleBackColor = false;
            this.button_alisEmri.Click += new System.EventHandler(this.button_alisEmri_Click);
            // 
            // button_bakiyeIslemleri
            // 
            this.button_bakiyeIslemleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_bakiyeIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_bakiyeIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bakiyeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bakiyeIslemleri.Location = new System.Drawing.Point(260, 8);
            this.button_bakiyeIslemleri.Name = "button_bakiyeIslemleri";
            this.button_bakiyeIslemleri.Size = new System.Drawing.Size(162, 34);
            this.button_bakiyeIslemleri.TabIndex = 7;
            this.button_bakiyeIslemleri.Text = "Bakiye İşlemleri";
            this.button_bakiyeIslemleri.UseVisualStyleBackColor = false;
            this.button_bakiyeIslemleri.Click += new System.EventHandler(this.button_bakiyeIslemleri_Click);
            // 
            // button_kullaniciPazari
            // 
            this.button_kullaniciPazari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_kullaniciPazari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_kullaniciPazari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kullaniciPazari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kullaniciPazari.Location = new System.Drawing.Point(92, 8);
            this.button_kullaniciPazari.Name = "button_kullaniciPazari";
            this.button_kullaniciPazari.Size = new System.Drawing.Size(162, 34);
            this.button_kullaniciPazari.TabIndex = 6;
            this.button_kullaniciPazari.Text = "Sahip Olduğum Pazarlar";
            this.button_kullaniciPazari.UseVisualStyleBackColor = false;
            this.button_kullaniciPazari.Click += new System.EventHandler(this.button_kullaniciPazari_Click);
            // 
            // label_bakiye
            // 
            this.label_bakiye.AutoSize = true;
            this.label_bakiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bakiye.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_bakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label_bakiye.ForeColor = System.Drawing.Color.Turquoise;
            this.label_bakiye.Location = new System.Drawing.Point(707, 5);
            this.label_bakiye.Name = "label_bakiye";
            this.label_bakiye.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_bakiye.Size = new System.Drawing.Size(55, 30);
            this.label_bakiye.TabIndex = 0;
            this.label_bakiye.Text = "650 ₺";
            this.label_bakiye.Click += new System.EventHandler(this.button_bakiyeIslemleri_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guvenliCikisToolStripMenuItem});
            this.hesapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hesapToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.hesapToolStripMenuItem.Text = "[kullanıcı Adı]";
            // 
            // guvenliCikisToolStripMenuItem
            // 
            this.guvenliCikisToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guvenliCikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guvenliCikisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guvenliCikisToolStripMenuItem.Name = "guvenliCikisToolStripMenuItem";
            this.guvenliCikisToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.guvenliCikisToolStripMenuItem.Text = "Güvenli Çıkış";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // groupBox_pazarlar
            // 
            this.groupBox_pazarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox_pazarlar.Controls.Add(this.flowLayoutPanel_pazarlar);
            this.groupBox_pazarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox_pazarlar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_pazarlar.Location = new System.Drawing.Point(92, 60);
            this.groupBox_pazarlar.Name = "groupBox_pazarlar";
            this.groupBox_pazarlar.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupBox_pazarlar.Size = new System.Drawing.Size(577, 539);
            this.groupBox_pazarlar.TabIndex = 7;
            this.groupBox_pazarlar.TabStop = false;
            this.groupBox_pazarlar.Text = "[urunAdi] Pazarlari";
            // 
            // flowLayoutPanel_pazarlar
            // 
            this.flowLayoutPanel_pazarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel_pazarlar.AutoScroll = true;
            this.flowLayoutPanel_pazarlar.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_pazarlar.Controls.Add(this.panel_urun);
            this.flowLayoutPanel_pazarlar.Location = new System.Drawing.Point(2, 23);
            this.flowLayoutPanel_pazarlar.Name = "flowLayoutPanel_pazarlar";
            this.flowLayoutPanel_pazarlar.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_pazarlar.Size = new System.Drawing.Size(585, 527);
            this.flowLayoutPanel_pazarlar.TabIndex = 5;
            // 
            // panel_urun
            // 
            this.panel_urun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel_urun.Controls.Add(this.label_tarihValue);
            this.panel_urun.Controls.Add(this.label_tarihTittle);
            this.panel_urun.Controls.Add(this.label_saticiValue);
            this.panel_urun.Controls.Add(this.label_saticiTittle);
            this.panel_urun.Controls.Add(this.label_fiyatValue);
            this.panel_urun.Controls.Add(this.label_fiyatTittle);
            this.panel_urun.Controls.Add(this.label_miktarValue);
            this.panel_urun.Controls.Add(this.label_miktarTittle);
            this.panel_urun.Controls.Add(this.label_urunAdi);
            this.panel_urun.Controls.Add(this.pictureBox_urunResim);
            this.panel_urun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_urun.Location = new System.Drawing.Point(5, 5);
            this.panel_urun.Name = "panel_urun";
            this.panel_urun.Size = new System.Drawing.Size(560, 130);
            this.panel_urun.TabIndex = 1;
            this.panel_urun.Tag = "15512";
            // 
            // label_tarihValue
            // 
            this.label_tarihValue.AutoSize = true;
            this.label_tarihValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label_tarihValue.Location = new System.Drawing.Point(477, 109);
            this.label_tarihValue.Name = "label_tarihValue";
            this.label_tarihValue.Size = new System.Drawing.Size(80, 16);
            this.label_tarihValue.TabIndex = 11;
            this.label_tarihValue.Text = "12.05.2021";
            // 
            // label_tarihTittle
            // 
            this.label_tarihTittle.AutoSize = true;
            this.label_tarihTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_tarihTittle.Location = new System.Drawing.Point(432, 109);
            this.label_tarihTittle.Name = "label_tarihTittle";
            this.label_tarihTittle.Size = new System.Drawing.Size(42, 16);
            this.label_tarihTittle.TabIndex = 10;
            this.label_tarihTittle.Text = "Tarih:";
            // 
            // label_saticiValue
            // 
            this.label_saticiValue.AutoSize = true;
            this.label_saticiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label_saticiValue.Location = new System.Drawing.Point(206, 91);
            this.label_saticiValue.Name = "label_saticiValue";
            this.label_saticiValue.Size = new System.Drawing.Size(61, 16);
            this.label_saticiValue.TabIndex = 7;
            this.label_saticiValue.Text = "ciguli05";
            // 
            // label_saticiTittle
            // 
            this.label_saticiTittle.AutoSize = true;
            this.label_saticiTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_saticiTittle.Location = new System.Drawing.Point(130, 91);
            this.label_saticiTittle.Name = "label_saticiTittle";
            this.label_saticiTittle.Size = new System.Drawing.Size(44, 16);
            this.label_saticiTittle.TabIndex = 6;
            this.label_saticiTittle.Text = "Satıcı:";
            // 
            // label_fiyatValue
            // 
            this.label_fiyatValue.AutoSize = true;
            this.label_fiyatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label_fiyatValue.Location = new System.Drawing.Point(206, 68);
            this.label_fiyatValue.Name = "label_fiyatValue";
            this.label_fiyatValue.Size = new System.Drawing.Size(36, 16);
            this.label_fiyatValue.TabIndex = 5;
            this.label_fiyatValue.Text = "2.17";
            // 
            // label_fiyatTittle
            // 
            this.label_fiyatTittle.AutoSize = true;
            this.label_fiyatTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_fiyatTittle.Location = new System.Drawing.Point(130, 68);
            this.label_fiyatTittle.Name = "label_fiyatTittle";
            this.label_fiyatTittle.Size = new System.Drawing.Size(52, 16);
            this.label_fiyatTittle.TabIndex = 4;
            this.label_fiyatTittle.Text = "Fiyat(₺)";
            // 
            // label_miktarValue
            // 
            this.label_miktarValue.AutoSize = true;
            this.label_miktarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label_miktarValue.Location = new System.Drawing.Point(206, 44);
            this.label_miktarValue.Name = "label_miktarValue";
            this.label_miktarValue.Size = new System.Drawing.Size(40, 16);
            this.label_miktarValue.TabIndex = 3;
            this.label_miktarValue.Text = "1500";
            // 
            // label_miktarTittle
            // 
            this.label_miktarTittle.AutoSize = true;
            this.label_miktarTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_miktarTittle.Location = new System.Drawing.Point(130, 43);
            this.label_miktarTittle.Name = "label_miktarTittle";
            this.label_miktarTittle.Size = new System.Drawing.Size(70, 16);
            this.label_miktarTittle.TabIndex = 2;
            this.label_miktarTittle.Text = "Miktar (kg)";
            // 
            // label_urunAdi
            // 
            this.label_urunAdi.AutoSize = true;
            this.label_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label_urunAdi.Location = new System.Drawing.Point(129, 12);
            this.label_urunAdi.Name = "label_urunAdi";
            this.label_urunAdi.Size = new System.Drawing.Size(61, 20);
            this.label_urunAdi.TabIndex = 1;
            this.label_urunAdi.Text = "Suğan";
            // 
            // pictureBox_urunResim
            // 
            this.pictureBox_urunResim.Image = global::taslakOdev.Properties.Resources.patates1;
            this.pictureBox_urunResim.Location = new System.Drawing.Point(5, 5);
            this.pictureBox_urunResim.Name = "pictureBox_urunResim";
            this.pictureBox_urunResim.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_urunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_urunResim.TabIndex = 0;
            this.pictureBox_urunResim.TabStop = false;
            // 
            // Form_UrunPazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(765, 611);
            this.Controls.Add(this.groupBox_pazarlar);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(677, 650);
            this.Name = "Form_UrunPazar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aktif [urun adı] Pazarları";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_pazarlar.ResumeLayout(false);
            this.flowLayoutPanel_pazarlar.ResumeLayout(false);
            this.panel_urun.ResumeLayout(false);
            this.panel_urun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_urunResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_alisEmri;
        private System.Windows.Forms.Button button_bakiyeIslemleri;
        private System.Windows.Forms.Button button_kullaniciPazari;
        private System.Windows.Forms.Label label_bakiye;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guvenliCikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_pazarlar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_pazarlar;
        private System.Windows.Forms.Panel panel_urun;
        private System.Windows.Forms.Label label_tarihValue;
        private System.Windows.Forms.Label label_tarihTittle;
        private System.Windows.Forms.Label label_saticiValue;
        private System.Windows.Forms.Label label_saticiTittle;
        private System.Windows.Forms.Label label_fiyatValue;
        private System.Windows.Forms.Label label_fiyatTittle;
        private System.Windows.Forms.Label label_miktarValue;
        private System.Windows.Forms.Label label_miktarTittle;
        private System.Windows.Forms.Label label_urunAdi;
        private System.Windows.Forms.PictureBox pictureBox_urunResim;
    }
}