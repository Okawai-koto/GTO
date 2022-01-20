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

       

        private void CuzdanSayfasi_Click(object sender, EventArgs e)
        {
            CuzdanSayfasi CuzdanSayfasiNesnesi = new CuzdanSayfasi();
            CuzdanSayfasiNesnesi.Show();
            this.Hide();

           
        }

        private void BankaSayfasi_Click(object sender, EventArgs e)
        {
            BankaSayfasi BankaSayfasiNesnesi = new BankaSayfasi();
            BankaSayfasiNesnesi.Show();
            this.Hide();
        }

        private void GiderlerSayfasi_Click(object sender, EventArgs e)
        {
            GiderlerSayfasi GiderlerSayfasiNesnesi = new GiderlerSayfasi();
            GiderlerSayfasiNesnesi.Show();
            this.Hide();
        }

        private void GelirlerSayfasi_Click(object sender, EventArgs e)
        {
            GelirlerSayfasi GelirlerSayfasiNesnesi = new GelirlerSayfasi();
            GelirlerSayfasiNesnesi.Show();
            this.Hide();
        }

        private void KisilerSayfasi_Click(object sender, EventArgs e)
        {
            KisilerSayfasi KisilerSayfasiNesnesi = new KisilerSayfasi();
            KisilerSayfasiNesnesi.Show();
            this.Hide();
        }

        private void TakvimSayfasi_Click(object sender, EventArgs e)
        {
            TakvimSayfasi TakvimSayfasiNesnesi = new TakvimSayfasi();
            TakvimSayfasiNesnesi.Show();
            this.Hide();

        }

        private void PersonelSayfasi_Click(object sender, EventArgs e)
        {
            PersonelSayfasi PersonelSayfasiNesnesi = new PersonelSayfasi();
            PersonelSayfasiNesnesi.Show();
            this.Hide();

        }

        private void AyarlarSayfasi_Click(object sender, EventArgs e)
        {
            AyarlarSayfasi AyarlarSayfasiNesnesi = new AyarlarSayfasi();
            AyarlarSayfasiNesnesi.Show();
            this.Hide();

        }

        private void FiyatlarSayfasi_Click(object sender, EventArgs e)
        {
            FiyatlarSayfasi FiyatlarSayfasiNesnesi = new FiyatlarSayfasi();
            FiyatlarSayfasiNesnesi.Show();
            this.Hide();
        }

        private void KarZararSayfasi_Click(object sender, EventArgs e)
        {
            KarZararSayfasi KarZararSayfasiNesnesi = new KarZararSayfasi();
            KarZararSayfasiNesnesi.Show();
            this.Hide();
        }

        private void TicariMalSayfasi_Click(object sender, EventArgs e)
        {
            TicariMalSayfasi TicariMalSayfasiNesnesi = new TicariMalSayfasi();
            TicariMalSayfasiNesnesi.Show();
            this.Hide();

        }
    }
}
