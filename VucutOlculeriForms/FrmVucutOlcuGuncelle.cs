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
    public partial class FrmVucutOlcuGuncelle : Form
    {
        public FrmVucutOlcuGuncelle()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);

        }
        VeriYonetimiVucutOlcu veriYonetimi=new VeriYonetimiVucutOlcu();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sporcuID = Convert.ToInt32(txtSporcuId.Text);
            string ad = veriYonetimi.AdBilgisiniGetir(sporcuID);
            int kilo = Convert.ToInt32(txtKilo.Text);
            int boy = Convert.ToInt32(txtBoy.Text);
            int gogusCevresi = Convert.ToInt32(txtGogusCevresi.Text);
            int belCevresi = Convert.ToInt32(txtBelCevresi.Text);
            int kalcaCevresi = Convert.ToInt32(txtKalcaCevresi.Text);
            DateTime olcuTarihi = dtpOlcumTarihi.Value;

            veriYonetimi.verileriGuncelle(sporcuID, kilo, boy, gogusCevresi, belCevresi, kalcaCevresi, olcuTarihi);

            veriYonetimi.VerileriGetir(dataGridView1);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOlcuId.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtSporcuId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtKilo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtBoy.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtGogusCevresi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtBelCevresi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtKalcaCevresi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dtpOlcumTarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FrmVucutOlcuListesi frm = new FrmVucutOlcuListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGogusCevresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBelCevresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKalcaCevresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
