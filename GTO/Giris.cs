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

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
