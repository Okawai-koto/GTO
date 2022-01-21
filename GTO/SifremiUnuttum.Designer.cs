
namespace GTO
{
    partial class SifremiUnuttum
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
            this.textBoxSifremiUnuttum_Eposta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSifremiUnuttum_Eposta
            // 
            this.textBoxSifremiUnuttum_Eposta.Location = new System.Drawing.Point(470, 206);
            this.textBoxSifremiUnuttum_Eposta.Name = "textBoxSifremiUnuttum_Eposta";
            this.textBoxSifremiUnuttum_Eposta.Size = new System.Drawing.Size(227, 20);
            this.textBoxSifremiUnuttum_Eposta.TabIndex = 0;
            this.textBoxSifremiUnuttum_Eposta.Text = "E-posta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mail Gonder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSifremiUnuttum_Eposta);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSifremiUnuttum_Eposta;
        private System.Windows.Forms.Button button1;
    }
}