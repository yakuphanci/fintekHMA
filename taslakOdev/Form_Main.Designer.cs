
namespace taslakOdev
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_kayitOl = new System.Windows.Forms.Button();
            this.button_giris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::taslakOdev.Properties.Resources.PNG_images_Wheat_12png;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button_kayitOl);
            this.panel1.Controls.Add(this.button_giris);
            this.panel1.Location = new System.Drawing.Point(192, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 416);
            this.panel1.TabIndex = 0;
            // 
            // button_kayitOl
            // 
            this.button_kayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button_kayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_kayitOl.Location = new System.Drawing.Point(171, 195);
            this.button_kayitOl.Margin = new System.Windows.Forms.Padding(4);
            this.button_kayitOl.Name = "button_kayitOl";
            this.button_kayitOl.Size = new System.Drawing.Size(159, 47);
            this.button_kayitOl.TabIndex = 1;
            this.button_kayitOl.Text = "Kaydol";
            this.button_kayitOl.UseVisualStyleBackColor = false;
            this.button_kayitOl.Click += new System.EventHandler(this.button_kayitOl_Click);
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_giris.Location = new System.Drawing.Point(171, 139);
            this.button_giris.Margin = new System.Windows.Forms.Padding(4);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(159, 47);
            this.button_giris.TabIndex = 0;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(883, 552);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.Text = "Hoşgeldiniz.  - HMA Tarımsal Borsa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_kayitOl;
        private System.Windows.Forms.Button button_giris;
    }
}