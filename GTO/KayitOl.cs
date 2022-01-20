using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GTO
{
    public partial class KayitOl : Form
    {

        Regex r = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        public KayitOl()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KayitOlButon_Click(object sender, EventArgs e)
        {
            if (r.IsMatch(textBoxEposta.Text))
                MessageBox.Show("Geçerli");
            else
                MessageBox.Show("Hatalı");
        }
    }
}
