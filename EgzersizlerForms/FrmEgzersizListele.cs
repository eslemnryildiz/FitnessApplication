using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApplication.EgzersizlerForms
{
    public partial class FrmEgzersizListele : Form
    {
        public FrmEgzersizListele()
        {
            InitializeComponent();
            // Form yüklendiğinde olayını (event) dinle
            this.Load += FrmEgzersizListele_Load;

            // DataGridView'daki CellClick olayını dinle
            dataGridView1.CellClick += DataGridView1_CellClick;

        }
        VeriYonetimiEgzersiz egzersiz=new VeriYonetimiEgzersiz();
        private void FrmEgzersizListele_Load(object sender, EventArgs e)
        {
            egzersiz.VerileriGetir(dataGridView1);
            ShowImageFromSelectedRow();
        }



        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtIslev.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtGorsel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string islev = txtIslev.Text;
            string gorsel = txtGorsel.Text;

            egzersiz.verileriEkle( ad, islev, gorsel);
            egzersiz.VerileriGetir(dataGridView1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // DataGridView'daki SporcuID sütunundaki değeri al
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value);

                // Veriyi silme fonksiyonunu çağır
                if (DialogResult.Yes == MessageBox.Show("Silmek İstediginize Emin Misiniz ?", "Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    egzersiz.verileriSil(id);

                // DataGridView'dan seçili satırı kaldır
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string ad = txtAd.Text;
            string islev = txtIslev.Text;
            string gorsel = txtGorsel.Text;

            egzersiz.verileriGuncelle(id, ad, islev, gorsel);

            egzersiz.VerileriGetir(dataGridView1);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            egzersiz.Ara(dataGridView1, txtEgzersizAletAd.Text);
        }


        private void ShowImageFromSelectedRow()
        {
            // Seçili satırın 3. sütunundaki görsel yolunu al
            string imagePath = dataGridView1.CurrentRow.Cells[3].Value.ToString();

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
    }
}
