using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FitnessApplication
{
    public partial class FrmVucutOlcuEkle : Form
    {
        public FrmVucutOlcuEkle()
        {
            InitializeComponent();
        }
        VeriYonetimiVucutOlcu veriYonetimi = new VeriYonetimiVucutOlcu();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sporcuID = Convert.ToInt32(txtSporcuId.Text);
            string ad = veriYonetimi.AdBilgisiniGetir(sporcuID);
            int kilo = Convert.ToInt32(txtKilo.Text);
            int boy = Convert.ToInt32(txtBoy.Text);
            int gogusCevresi = Convert.ToInt32(txtGogusCevresi.Text);
            int belCevresi = Convert.ToInt32(txtBelCevresi.Text);
            int kalcaCevresi = Convert.ToInt32(txtKalcaCevresi.Text);
            DateTime olcuTarihi = dtpOlcumTarihi.Value;

            veriYonetimi.verileriEkle(sporcuID,ad, kilo,  boy, gogusCevresi,  belCevresi,  kalcaCevresi,  olcuTarihi);
        }
       // OgrenciSporcu ogrenci = new OgrenciSporcu();

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
