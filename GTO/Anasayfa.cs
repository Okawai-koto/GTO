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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
 

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CuzdanSayfasi_Click(object sender, EventArgs e)
        {
            CuzdanSayfasi CuzdanSayfasiNesnesi = new CuzdanSayfasi();
            AnaSayfasi.Hide();
            CuzdanSayfasiNesnesi.Show();

           
        }
    }
}
