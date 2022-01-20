
namespace GTO
{
    partial class KayitOl
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
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSirketAdi = new System.Windows.Forms.TextBox();
            this.textBoxVergiDairesi = new System.Windows.Forms.TextBox();
            this.textBoxEposta = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxSifreTekrar = new System.Windows.Forms.TextBox();
            this.KayitOlButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(473, 115);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(191, 20);
            this.textBoxKullaniciAdi.TabIndex = 0;
            this.textBoxKullaniciAdi.Text = "Kullanici Adi";
            // 
            // textBoxSirketAdi
            // 
            this.textBoxSirketAdi.Location = new System.Drawing.Point(473, 141);
            this.textBoxSirketAdi.Name = "textBoxSirketAdi";
            this.textBoxSirketAdi.Size = new System.Drawing.Size(191, 20);
            this.textBoxSirketAdi.TabIndex = 1;
            this.textBoxSirketAdi.Text = "Sirket Adi";
            this.textBoxSirketAdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxVergiDairesi
            // 
            this.textBoxVergiDairesi.Location = new System.Drawing.Point(473, 167);
            this.textBoxVergiDairesi.Name = "textBoxVergiDairesi";
            this.textBoxVergiDairesi.Size = new System.Drawing.Size(191, 20);
            this.textBoxVergiDairesi.TabIndex = 2;
            this.textBoxVergiDairesi.Text = "Vergi Dairesi";
            // 
            // textBoxEposta
            // 
            this.textBoxEposta.Location = new System.Drawing.Point(473, 193);
            this.textBoxEposta.Name = "textBoxEposta";
            this.textBoxEposta.Size = new System.Drawing.Size(191, 20);
            this.textBoxEposta.TabIndex = 3;
            this.textBoxEposta.Text = "E-posta";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(473, 219);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(191, 20);
            this.textBoxSifre.TabIndex = 4;
            this.textBoxSifre.Text = "Sifre";
            // 
            // textBoxSifreTekrar
            // 
            this.textBoxSifreTekrar.Location = new System.Drawing.Point(473, 245);
            this.textBoxSifreTekrar.Name = "textBoxSifreTekrar";
            this.textBoxSifreTekrar.Size = new System.Drawing.Size(191, 20);
            this.textBoxSifreTekrar.TabIndex = 5;
            this.textBoxSifreTekrar.Text = "Sifre Tekrari";
            // 
            // KayitOlButon
            // 
            this.KayitOlButon.Location = new System.Drawing.Point(529, 280);
            this.KayitOlButon.Name = "KayitOlButon";
            this.KayitOlButon.Size = new System.Drawing.Size(75, 23);
            this.KayitOlButon.TabIndex = 6;
            this.KayitOlButon.Text = "Kayit ol";
            this.KayitOlButon.UseVisualStyleBackColor = true;
            this.KayitOlButon.Click += new System.EventHandler(this.KayitOlButon_Click);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.KayitOlButon);
            this.Controls.Add(this.textBoxSifreTekrar);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxEposta);
            this.Controls.Add(this.textBoxVergiDairesi);
            this.Controls.Add(this.textBoxSirketAdi);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSirketAdi;
        private System.Windows.Forms.TextBox textBoxVergiDairesi;
        private System.Windows.Forms.TextBox textBoxEposta;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxSifreTekrar;
        private System.Windows.Forms.Button KayitOlButon;
    }
}