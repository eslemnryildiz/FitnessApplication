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
    public partial class FrmOdemeGuncelle : Form
    {
        public FrmOdemeGuncelle()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);
        }
        VeriYonetimiOdemeler veriYonetimi = new VeriYonetimiOdemeler();
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOdemeId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtSporcuId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dtpTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtMiktar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int odemeId = Convert.ToInt32(txtOdemeId.Text);
            int sporcuID = Convert.ToInt32(txtSporcuId.Text);
            string ad = txtAd.Text;
            DateTime tarih = dtpTarih.Value;
            int miktar = Convert.ToInt32(txtMiktar.Text);
            string aciklama = txtAciklama.Text;

            veriYonetimi.verileriGuncelle(odemeId, sporcuID, ad, tarih, miktar, aciklama);

            veriYonetimi.VerileriGetir(dataGridView1);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FrmOdemeListesi frm = new FrmOdemeListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
