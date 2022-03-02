using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

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
        //Database Değişkenleri
        MySqlConnection db;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void Giris_Load(object sender, EventArgs e)
        {
            db = dBConnection.dBConnect();
            if (db != null)
            {
                db.Open();
                label2.Text = "Veritabanı Bağlantısı: OK";
                label2.ForeColor = Color.BlueViolet;
                db.Close();
            }
            else
            {
                label2.Text = "Veritabanı Bağlantısı: BAD";
                label2.BackColor = Color.DarkRed;
                MessageBox.Show("Veritabanı Bağlantısında Hata İle Karşılaşıldı", "DB PROBLEM");
            }
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

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            db.Open();
            cmd = new MySqlCommand();
            cmd.Connection = db;
            cmd.CommandText = "SELECT * FROM kullanicilar where kullaniciAdi='" + textBoxGirisKullaniciAdi.Text + "' AND sifre='" + textBoxGirisSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();
            }
            db.Close();
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.Show();
            this.Hide();
        }
    }
}
