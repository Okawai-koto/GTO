
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
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.label2KullaniciAdi = new System.Windows.Forms.Label();
            this.label3Sifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGirisKullaniciAdi
            // 
            this.textBoxGirisKullaniciAdi.Location = new System.Drawing.Point(466, 242);
            this.textBoxGirisKullaniciAdi.Name = "textBoxGirisKullaniciAdi";
            this.textBoxGirisKullaniciAdi.Size = new System.Drawing.Size(238, 20);
            this.textBoxGirisKullaniciAdi.TabIndex = 0;
            // 
            // textBoxGirisSifre
            // 
            this.textBoxGirisSifre.Location = new System.Drawing.Point(466, 288);
            this.textBoxGirisSifre.Name = "textBoxGirisSifre";
            this.textBoxGirisSifre.Size = new System.Drawing.Size(238, 20);
            this.textBoxGirisSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(542, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sifremi unuttum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonGirisYap.FlatAppearance.BorderSize = 0;
            this.buttonGirisYap.Location = new System.Drawing.Point(530, 338);
            this.buttonGirisYap.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(101, 23);
            this.buttonGirisYap.TabIndex = 3;
            this.buttonGirisYap.Text = "Giris Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.buttonGirisYap.MouseLeave += new System.EventHandler(this.buttonGirisYap_MouseLeave);
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.Location = new System.Drawing.Point(530, 410);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(101, 23);
            this.buttonKayitOl.TabIndex = 4;
            this.buttonKayitOl.Text = "Kayit Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = true;
            this.buttonKayitOl.Click += new System.EventHandler(this.button2_Click);
            this.buttonKayitOl.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.buttonKayitOl.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // label2KullaniciAdi
            // 
            this.label2KullaniciAdi.AutoSize = true;
            this.label2KullaniciAdi.Location = new System.Drawing.Point(396, 245);
            this.label2KullaniciAdi.Name = "label2KullaniciAdi";
            this.label2KullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.label2KullaniciAdi.TabIndex = 5;
            this.label2KullaniciAdi.Text = "Kullanici Adi:";
            // 
            // label3Sifre
            // 
            this.label3Sifre.AutoSize = true;
            this.label3Sifre.Location = new System.Drawing.Point(429, 291);
            this.label3Sifre.Name = "label3Sifre";
            this.label3Sifre.Size = new System.Drawing.Size(31, 13);
            this.label3Sifre.TabIndex = 6;
            this.label3Sifre.Text = "Sifre:";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label3Sifre);
            this.Controls.Add(this.label2KullaniciAdi);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGirisSifre);
            this.Controls.Add(this.textBoxGirisKullaniciAdi);
            this.Cursor = System.Windows.Forms.Cursors.Default;
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
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.Label label2KullaniciAdi;
        private System.Windows.Forms.Label label3Sifre;
    }
}