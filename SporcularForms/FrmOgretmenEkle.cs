using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace FitnessApplication
{
    public partial class FrmOgretmenEkle : Form
    {
        public FrmOgretmenEkle()
        {
            InitializeComponent();
        }
        OgretmenSporcu ogretmen; 

        string cinsiyet;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                DateTime dogumTarihi = dtpDogumTarihi.Value;
                string telefon = txtTelefon.Text;
                string mail = txtMail.Text;
                DateTime kayitTarihi = dtpKayitTarihi.Value;
                string brans = txtBrans.Text;
                DateTime mezuniyetTarihi = dtpMezuniyetTarihi.Value;
                string gorsel=txtGorsel.Text;

                ogretmen = new OgretmenSporcu(ad, soyad, dogumTarihi, cinsiyet, telefon, mail, kayitTarihi, brans, mezuniyetTarihi,gorsel);
                ogretmen.verileriEkle("Öğretmen",ogretmen.Ad, ogretmen.Soyad, ogretmen.DoğumTarihi, ogretmen.Cinsiyet, ogretmen.Telefon, ogretmen.Mail, ogretmen.KayıtTarihi, ogretmen.Brans, ogretmen.MezuniyetTarihi, ogretmen.Gorsel);
                MessageBox.Show("Öğretmen başarıyla eklendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }
        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }





        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtGorsel.Text = openFileDialog1.FileName;

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FrmSporcuListesi frm = new FrmSporcuListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
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