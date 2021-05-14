
using System.Windows.Forms;

namespace taslakOdev
{
    partial class Form_Uygulama
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
            this.components = new System.ComponentModel.Container();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_kullaniciPazari = new System.Windows.Forms.Button();
            this.label_bakiye = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guvenliCikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_kategoriler = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_kategoriIDValue = new System.Windows.Forms.Label();
            this.label_kategoriIDTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel_kategoriler.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button1);
            this.panel_menu.Controls.Add(this.button_kullaniciPazari);
            this.panel_menu.Controls.Add(this.label_bakiye);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 24);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(707, 40);
            this.panel_menu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(208, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bakiye İşlemleri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_bakiyeIslemleri_Click);
            // 
            // button_kullaniciPazari
            // 
            this.button_kullaniciPazari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_kullaniciPazari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_kullaniciPazari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kullaniciPazari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kullaniciPazari.Location = new System.Drawing.Point(40, 3);
            this.button_kullaniciPazari.Name = "button_kullaniciPazari";
            this.button_kullaniciPazari.Size = new System.Drawing.Size(162, 34);
            this.button_kullaniciPazari.TabIndex = 6;
            this.button_kullaniciPazari.Text = "Sahip Olduklarım ve Profilim";
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
            this.label_bakiye.Location = new System.Drawing.Point(652, 0);
            this.label_bakiye.Name = "label_bakiye";
            this.label_bakiye.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_bakiye.Size = new System.Drawing.Size(55, 30);
            this.label_bakiye.TabIndex = 0;
            this.label_bakiye.Text = "650 ₺";
            this.toolTip1.SetToolTip(this.label_bakiye, "Bakiye yüklemek için tıklayınız.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(130, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "EDF(₺):";
            this.toolTip1.SetToolTip(this.label2, "En Düşük Fiyat (TRY)");
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
            this.hesapToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
            this.hesapToolStripMenuItem.DropDownOpened += new System.EventHandler(this.ToolStripMenuItem_DropDownOpened);
            // 
            // guvenliCikisToolStripMenuItem
            // 
            this.guvenliCikisToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guvenliCikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guvenliCikisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guvenliCikisToolStripMenuItem.Name = "guvenliCikisToolStripMenuItem";
            this.guvenliCikisToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.guvenliCikisToolStripMenuItem.Text = "Güvenli Çıkış";
            this.guvenliCikisToolStripMenuItem.Click += new System.EventHandler(this.guvenliCikisToolStripMenuItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.groupBox1.Controls.Add(this.flowLayoutPanel_kategoriler);
            this.groupBox1.Location = new System.Drawing.Point(63, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 530);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel_kategoriler
            // 
            this.flowLayoutPanel_kategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel_kategoriler.AutoScroll = true;
            this.flowLayoutPanel_kategoriler.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_kategoriler.Controls.Add(this.panel1);
            this.flowLayoutPanel_kategoriler.Location = new System.Drawing.Point(1, 11);
            this.flowLayoutPanel_kategoriler.Name = "flowLayoutPanel_kategoriler";
            this.flowLayoutPanel_kategoriler.Size = new System.Drawing.Size(583, 515);
            this.flowLayoutPanel_kategoriler.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label_kategoriIDValue);
            this.panel1.Controls.Add(this.label_kategoriIDTittle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 130);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "15512";
            // 
            // label_kategoriIDValue
            // 
            this.label_kategoriIDValue.AutoSize = true;
            this.label_kategoriIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label_kategoriIDValue.Location = new System.Drawing.Point(516, 107);
            this.label_kategoriIDValue.Name = "label_kategoriIDValue";
            this.label_kategoriIDValue.Size = new System.Drawing.Size(16, 16);
            this.label_kategoriIDValue.TabIndex = 11;
            this.label_kategoriIDValue.Text = "4";
            // 
            // label_kategoriIDTittle
            // 
            this.label_kategoriIDTittle.AutoSize = true;
            this.label_kategoriIDTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_kategoriIDTittle.Location = new System.Drawing.Point(433, 107);
            this.label_kategoriIDTittle.Name = "label_kategoriIDTittle";
            this.label_kategoriIDTittle.Size = new System.Drawing.Size(77, 16);
            this.label_kategoriIDTittle.TabIndex = 10;
            this.label_kategoriIDTittle.Text = "Kategori ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(206, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "2.17";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(206, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "1500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(130, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Miktar (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(129, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Suğan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::taslakOdev.Properties.Resources.patates1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Uygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(707, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(677, 650);
            this.Name = "Form_Uygulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Uygulama_FormClosing);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel_kategoriler.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label_bakiye;
        private ToolTip toolTip1;
        private Button button_kullaniciPazari;
        private ToolStripMenuItem hesapToolStripMenuItem;
        private ToolStripMenuItem guvenliCikisToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yenileToolStripMenuItem;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel_kategoriler;
        private Panel panel1;
        private Label label_kategoriIDValue;
        private Label label_kategoriIDTittle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button1;
    }
}