
namespace GTO
{
    partial class MailGonderildi
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
            this.mailyazisi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mailyazisi
            // 
            this.mailyazisi.AutoSize = true;
            this.mailyazisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailyazisi.Location = new System.Drawing.Point(453, 84);
            this.mailyazisi.Name = "mailyazisi";
            this.mailyazisi.Size = new System.Drawing.Size(252, 20);
            this.mailyazisi.TabIndex = 0;
            this.mailyazisi.Text = "E-Posta Adresinize Mail Gonderildi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Girise Yonlendir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MailGonderildi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailyazisi);
            this.Name = "MailGonderildi";
            this.Text = "MailGonderildi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mailyazisi;
        private System.Windows.Forms.Button button1;
    }
}