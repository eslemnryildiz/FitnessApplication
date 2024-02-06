using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;

namespace FitnessApplication
{
    public partial class FrmOgrenciEkle : Form
    {
        
        public FrmOgrenciEkle()
        {
            InitializeComponent();
        }
        OgrenciSporcu ogrenci;
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                DateTime dogumTarihi = dtpDogumTarihi.Value;
                string telefon = txtTelefon.Text;
                string mail = txtMail.Text;
                DateTime kayitTarihi = DateTime.Now;
                string sinif = cmbSinif.Text;
                string bolum = txtBolum.Text;
                string gorsel=txtGorsel.Text;

                ogrenci = new OgrenciSporcu(ad, soyad, dogumTarihi, cinsiyet, telefon, mail, kayitTarihi, sinif, bolum,gorsel);
                ogrenci.verileriEkle("Öğrenci",ogrenci.Ad, ogrenci.Soyad, ogrenci.DoğumTarihi, ogrenci.Cinsiyet, ogrenci.Telefon, ogrenci.Mail, ogrenci.KayıtTarihi, ogrenci.Sinif, ogrenci.Bolum,ogrenci.Gorsel);
                MessageBox.Show("Öğrenci başarıyla eklendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }



        }

        string cinsiyet;

        private void rbKadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FrmSporcuListesi frm = new FrmSporcuListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtGorsel.Text = openFileDialog1.FileName;

            }
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
    }

