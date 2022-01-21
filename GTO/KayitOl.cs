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
using MySql.Data.MySqlClient;

namespace GTO
{
    public partial class KayitOl : Form
    {
        //kontrol icin kullanilacak nesne uretimleri
        Regex kullaniciAdiKontrol = new Regex(@"^+[\w-]{4,10}$");

        Regex sirketAdiKontrol = new Regex(@"^+[\w-]{4,10}$");

        Regex vergiDairesiNoKontrol = new Regex(@"^+[\w-]{10,10}$");

        Regex emailKontrol = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

        Regex sifreKontrol = new Regex(@"^([a-zA-Z0-9@*#]{8,15})$");

        string kullaniciAdi = null;
        string sirketAdi = null;
        string vergiDairesiNo = null;
        string ePosta = null;
        string sifre = null;
        


        public KayitOl()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KayitOlButon_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (kullaniciAdiKontrol.IsMatch(textBoxKullaniciAdi.Text))
            {
                 kullaniciAdi = textBoxKullaniciAdi.Text;
            }
            else
            {
                MessageBox.Show("Kullanici adi gerekli kriterlere sahip degil");
                check = false;
            }


            if (sirketAdiKontrol.IsMatch(textBoxSirketAdi.Text))
            {
                 sirketAdi = textBoxKullaniciAdi.Text;
            }
            else
            {
                MessageBox.Show("sirket adi gerekli kriterlere sahip degil");
                check = false;
            }

            if (vergiDairesiNoKontrol.IsMatch(textBoxVergiDairesiNo.Text))
            {
                vergiDairesiNo = textBoxVergiDairesiNo.Text;
            }
            else
            {
                MessageBox.Show("vergi no gerekli kriterlere sahip degil");
                check = false;
            }



            if (emailKontrol.IsMatch(textBoxEposta.Text))
            {
                ePosta = textBoxEposta.Text;
            }
                
            else
            {
                MessageBox.Show("Hatalı E-posta");
                check = false;
            }
                

            if (sifreKontrol.IsMatch(textBoxSifre.Text))
            {
                if (textBoxSifre.Text == textBoxSifreTekrar.Text)
                {
                    sifre = textBoxSifre.Text;
                }
                else
                {
                    MessageBox.Show("Sifreler ayni degil");
                    check = false;
                }
            }
            else
            {
                MessageBox.Show("Sifre kurallara uygun degil lutfen yeniden yaziniz");
                check = false;
            }

            if (check == true)
            {
                db.Open();
                cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "INSERT INTO kullanicilar (kullaniciAdi,sifre,sirketAdi,vergiNo,ePosta) VALUES('" + kullaniciAdi + "','" + sifre + "','" + sirketAdi + "','" + vergiDairesiNo + "','" + ePosta + "')";
                cmd.ExecuteNonQuery();
            }
        }

        private void textBoxKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)  || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }            
        }

        private void textBoxSirketAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxVergiDairesiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Database Değişkenleri
        MySqlConnection db;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void KayitOl_Load(object sender, EventArgs e)
        {
            db = dBConnection.dBConnect();
            if (db != null)
            {
                db.Open();
                db.Close();
            }
            else
            {
                MessageBox.Show("Veritabanı Bağlantısında Hata İle Karşılaşıldı", "DB PROBLEM");
            }
        }
    }
}
