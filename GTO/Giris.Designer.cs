
namespace GTO
{
    partial class Giris
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
            this.textBoxGirisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxGirisSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGirisKullaniciAdi
            // 
            this.textBoxGirisKullaniciAdi.Location = new System.Drawing.Point(466, 242);
            this.textBoxGirisKullaniciAdi.Name = "textBoxGirisKullaniciAdi";
            this.textBoxGirisKullaniciAdi.Size = new System.Drawing.Size(238, 20);
            this.textBoxGirisKullaniciAdi.TabIndex = 0;
            this.textBoxGirisKullaniciAdi.Text = "Kullanici Adi";
            // 
            // textBoxGirisSifre
            // 
            this.textBoxGirisSifre.Location = new System.Drawing.Point(466, 288);
            this.textBoxGirisSifre.Name = "textBoxGirisSifre";
            this.textBoxGirisSifre.Size = new System.Drawing.Size(238, 20);
            this.textBoxGirisSifre.TabIndex = 1;
            this.textBoxGirisSifre.Text = "Sifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sifremi unuttum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giris Yap";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kayit Ol";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGirisSifre);
            this.Controls.Add(this.textBoxGirisKullaniciAdi);
            this.Name = "Giris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGirisKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxGirisSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}