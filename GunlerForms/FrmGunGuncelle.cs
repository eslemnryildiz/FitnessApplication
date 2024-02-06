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
    public partial class FrmGunGuncelle : Form
    {
        public FrmGunGuncelle()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);
        }
        VeriYonetimiGunler veriYonetimi = new VeriYonetimiGunler();
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtSporcuId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmbPazartesi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbSali.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cmbCarsamba.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cmbPersembe.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmbCuma.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                cmbCumartesi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cmbPazar.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int sporcuID = Convert.ToInt32(txtSporcuId.Text);
            string pazartesi = cmbPazartesi.Text;
            string sali = cmbSali.Text;
            string carsamba = cmbCarsamba.Text;
            string persembe = cmbPersembe.Text;
            string cuma = cmbCuma.Text;
            string cumartesi = cmbCumartesi.Text;
            string pazar = cmbPazar.Text;

            veriYonetimi.VerileriGuncelle(id,sporcuID, pazartesi, sali, carsamba, persembe, cuma, cumartesi, pazar);
            veriYonetimi.VerileriGetir(dataGridView1);  
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
