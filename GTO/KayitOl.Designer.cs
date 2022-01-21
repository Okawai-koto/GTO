
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
            this.textBoxVergiDairesiNo = new System.Windows.Forms.TextBox();
            this.textBoxEposta = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxSifreTekrar = new System.Windows.Forms.TextBox();
            this.KayitOlButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(473, 115);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(191, 20);
            this.textBoxKullaniciAdi.TabIndex = 0;
            this.textBoxKullaniciAdi.Text = "test";
            this.textBoxKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKullaniciAdi_KeyPress);
            // 
            // textBoxSirketAdi
            // 
            this.textBoxSirketAdi.Location = new System.Drawing.Point(473, 141);
            this.textBoxSirketAdi.Name = "textBoxSirketAdi";
            this.textBoxSirketAdi.Size = new System.Drawing.Size(191, 20);
            this.textBoxSirketAdi.TabIndex = 1;
            this.textBoxSirketAdi.Text = "test";
            this.textBoxSirketAdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxSirketAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSirketAdi_KeyPress);
            // 
            // textBoxVergiDairesiNo
            // 
            this.textBoxVergiDairesiNo.Location = new System.Drawing.Point(473, 167);
            this.textBoxVergiDairesiNo.Name = "textBoxVergiDairesiNo";
            this.textBoxVergiDairesiNo.Size = new System.Drawing.Size(191, 20);
            this.textBoxVergiDairesiNo.TabIndex = 2;
            this.textBoxVergiDairesiNo.Text = "1234567890";
            this.textBoxVergiDairesiNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVergiDairesiNo_KeyPress);
            // 
            // textBoxEposta
            // 
            this.textBoxEposta.Location = new System.Drawing.Point(473, 193);
            this.textBoxEposta.Name = "textBoxEposta";
            this.textBoxEposta.Size = new System.Drawing.Size(191, 20);
            this.textBoxEposta.TabIndex = 3;
            this.textBoxEposta.Text = "test@gmail.com";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(473, 219);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(191, 20);
            this.textBoxSifre.TabIndex = 4;
            this.textBoxSifre.Text = "Ttest123T";
            // 
            // textBoxSifreTekrar
            // 
            this.textBoxSifreTekrar.Location = new System.Drawing.Point(473, 245);
            this.textBoxSifreTekrar.Name = "textBoxSifreTekrar";
            this.textBoxSifreTekrar.Size = new System.Drawing.Size(191, 20);
            this.textBoxSifreTekrar.TabIndex = 5;
            this.textBoxSifreTekrar.Text = "Ttest123T";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sifreniz bir kucuk harf, bir buyuk harf, bir rakam ve # @ gibi ozel karakter icer" +
    "melidir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanici Adi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sirket    Adi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vergi Dairesi No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-posta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sifre Tekrar:";
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KayitOlButon);
            this.Controls.Add(this.textBoxSifreTekrar);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxEposta);
            this.Controls.Add(this.textBoxVergiDairesiNo);
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
        private System.Windows.Forms.TextBox textBoxVergiDairesiNo;
        private System.Windows.Forms.TextBox textBoxEposta;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxSifreTekrar;
        private System.Windows.Forms.Button KayitOlButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}