using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class FrmOgretmenGuncelle : Form
    {
        public FrmOgretmenGuncelle()
        {
            InitializeComponent();
            DateTime gecici = DateTime.Now;
            OgretmenSporcu ogretmenGecici = new OgretmenSporcu(null, null, gecici, null, null, null, gecici, null, gecici,null);
            ogretmenGecici.VerileriGetir(dataGridView1);

            this.Load += FrmOgretmenGuncelle_Load;

            // DataGridView'daki CellClick olayını dinle
            dataGridView1.CellClick += DataGridView1_CellClick;
        }


        private void FrmOgretmenGuncelle_Load(object sender, EventArgs e)
        {
            ShowImageFromSelectedRow();

        }



        OgretmenSporcu ogretmen;

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dtpDogumTarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cmbCinsiyet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dtpKayitTarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtBrans.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                dtpMezuniyetTarihi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtGorsel.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            }
            catch
            {

            }
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string SporcuId = txtId.Text;
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                DateTime dogumTarihi = dtpDogumTarihi.Value;
                string cinsiyet = cmbCinsiyet.Text;
                string telefon = txtTelefon.Text;
                string mail = txtMail.Text;
                DateTime kayitTarihi = dtpKayitTarihi.Value;
                string brans = txtBrans.Text;
                DateTime mezuniyetTarihi = dtpMezuniyetTarihi.Value;
                string gorsel=txtGorsel.Text; ;

                ogretmen = new OgretmenSporcu(ad, soyad, dogumTarihi, cinsiyet, telefon, mail, kayitTarihi, brans, mezuniyetTarihi,gorsel);

                ogretmen.verileriGuncelle(SporcuId, ogretmen.Ad, ogretmen.Soyad, ogretmen.DoğumTarihi, ogretmen.Cinsiyet, ogretmen.Telefon, ogretmen.Mail, ogretmen.KayıtTarihi,ogretmen.Brans, ogretmen.MezuniyetTarihi,ogretmen.Gorsel);
                ogretmen.VerileriGetir(dataGridView1);
                gorselAcma();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        public void gorselAcma()
        {
            pictureBox1.ImageLocation = txtGorsel.Text;
            pictureBox1.Load();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtGorsel.Text = openFileDialog1.FileName;

            }
        }








        private void ShowImageFromSelectedRow()
        {
            // Seçili satırın 3. sütunundaki görsel yolunu al
            string imagePath = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            // Dosya yolu boş değilse ve dosya mevcut ise
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                try
                {
                    // PictureBox'a resmi göster
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim gösterme hatası: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir resim dosyası yok veya dosya bulunamıyor.");
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowImageFromSelectedRow();
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
