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
    public partial class FrmVucutOlcuSil : Form
    {
        public FrmVucutOlcuSil()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);
        }
        VeriYonetimiVucutOlcu veriYonetimi=new VeriYonetimiVucutOlcu();

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // DataGridView'daki SporcuID sütunundaki değeri al
                int SporcuId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["SporcuId"].Value);

                // Veriyi silme fonksiyonunu çağır
                veriYonetimi.verileriSil(SporcuId);

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
            FrmVucutOlcuListesi frm = new FrmVucutOlcuListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

    }
}
