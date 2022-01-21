using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTO
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SifremiUnuttum deneme = new SifremiUnuttum();
            deneme.Show();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfaNesne = new Anasayfa();
            anasayfaNesne.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttonGirisYap.BackColor = Color.Tomato;
            
        }

        private void buttonGirisYap_MouseLeave(object sender, EventArgs e)
        {
            buttonGirisYap.BackColor = Color.Gray;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            buttonKayitOl.BackColor = Color.Tomato;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            buttonKayitOl.BackColor = Color.Gray;
        }
    }
}
