
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_giris = new System.Windows.Forms.Button();
            this.button_kayitOl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::taslakOdev.Properties.Resources.PNG_images_Wheat_12png;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button_kayitOl);
            this.panel1.Controls.Add(this.button_giris);
            this.panel1.Location = new System.Drawing.Point(211, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 303);
            this.panel1.TabIndex = 0;
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_giris.Location = new System.Drawing.Point(132, 92);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(106, 34);
            this.button_giris.TabIndex = 0;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // button_kayitOl
            // 
            this.button_kayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_kayitOl.Location = new System.Drawing.Point(132, 132);
            this.button_kayitOl.Name = "button_kayitOl";
            this.button_kayitOl.Size = new System.Drawing.Size(106, 34);
            this.button_kayitOl.TabIndex = 0;
            this.button_kayitOl.Text = "Kaydol";
            this.button_kayitOl.UseVisualStyleBackColor = true;
            this.button_kayitOl.Click += new System.EventHandler(this.button_kayitOl_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_kayitOl;
        private System.Windows.Forms.Button button_giris;
    }
}