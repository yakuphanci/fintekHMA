
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guvenliCikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label_bakiye = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_yenile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guvenliCikisToolStripMenuItem});
            this.hesapToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hesapToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.hesapToolStripMenuItem.Text = "[kullanıcı Adı]";
            // 
            // guvenliCikisToolStripMenuItem
            // 
            this.guvenliCikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guvenliCikisToolStripMenuItem.Name = "guvenliCikisToolStripMenuItem";
            this.guvenliCikisToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.guvenliCikisToolStripMenuItem.Text = "Güvenli Çıkış";
            this.guvenliCikisToolStripMenuItem.Click += new System.EventHandler(this.guvenliCikisToolStripMenuItem_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button2);
            this.panel_menu.Controls.Add(this.button_yenile);
            this.panel_menu.Controls.Add(this.label_bakiye);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 24);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(661, 40);
            this.panel_menu.TabIndex = 1;
            // 
            // label_bakiye
            // 
            this.label_bakiye.AutoSize = true;
            this.label_bakiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bakiye.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_bakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label_bakiye.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_bakiye.Location = new System.Drawing.Point(606, 0);
            this.label_bakiye.Name = "label_bakiye";
            this.label_bakiye.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_bakiye.Size = new System.Drawing.Size(55, 30);
            this.label_bakiye.TabIndex = 0;
            this.label_bakiye.Text = "650 ₺";
            this.toolTip1.SetToolTip(this.label_bakiye, "Bakiye yüklemek için tıklayınız.");
            this.label_bakiye.Click += new System.EventHandler(this.label_bakiye_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(564, 512);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 130);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "15512";
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
            // button_yenile
            // 
            this.button_yenile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_yenile.Location = new System.Drawing.Point(4, 3);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(84, 34);
            this.button_yenile.TabIndex = 4;
            this.button_yenile.Text = "Yenile";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(94, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.ClientSize = new System.Drawing.Size(661, 611);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(677, 650);
            this.Name = "Form_Uygulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Uygulama_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guvenliCikisToolStripMenuItem;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label_bakiye;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button_yenile;
        private Button button2;
    }
}