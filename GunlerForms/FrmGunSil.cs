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
    public partial class FrmGunSil : Form
    {
        public FrmGunSil()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);
        }
        VeriYonetimiGunler veriYonetimi=new VeriYonetimiGunler();
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // DataGridView'daki odemeıd sütunundaki değeri al
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value);

                // Veriyi silme fonksiyonunu çağır
                veriYonetimi.GunSil(id);

                // DataGridView'dan seçili satırı kaldır
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FrmGunListesi frm = new FrmGunListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
