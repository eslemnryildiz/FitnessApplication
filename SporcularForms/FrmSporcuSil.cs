using MySqlConnector;
using MySqlX.XDevAPI.Relational;
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
    public partial class FrmSporcuSil : Form
    {
        
        DateTime gecici = DateTime.Now;
        Sporcu sporcu;
        OgrenciSporcu ogrenci;
        public FrmSporcuSil()
        {            
            InitializeComponent();
            sporcu = new Sporcu(null, null, gecici, null, null, null, gecici,null);
            sporcu.VerileriGetir(dataGridView1);
        }
         
        
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            ogrenci = new OgrenciSporcu(null, null, gecici, null, null, null, gecici, null, null,null);
            OgretmenSporcu ogretmen = new OgretmenSporcu(null, null, gecici, null, null, null, gecici, null, gecici,null);
            
                // Seçili satırın indeksini al
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedRowIndex2 = dataGridView1.SelectedRows[0].Index;


                // DataGridView'daki SporcuID sütunundaki değeri al

                int sporcuId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["SporcuId"].Value);
                string sporcuTuru = dataGridView1.Rows[selectedRowIndex2].Cells["sporcuTuru"].Value.ToString();
                if (sporcuId != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Silmek İstediginize Emin Misiniz ?", "Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        sporcu.verileriSil(sporcuId);

                }
                // Veriyi silme fonksiyonunu çağır
                if (sporcuTuru == "Öğrenci")
                {
                    ogrenci.verileriSil(sporcuId);
                }
                else
                {
                ogretmen.verileriSil(sporcuId);
                }
                

                // DataGridView'dan seçili satırı kaldır
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FrmSporcuListesi frm = new FrmSporcuListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
