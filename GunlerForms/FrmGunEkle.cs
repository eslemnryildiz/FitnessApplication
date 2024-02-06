using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySqlConnector;

namespace FitnessApplication
{
    public partial class FrmGunEkle : Form
    {
        public FrmGunEkle()
        {
            InitializeComponent();
        }
        VeriYonetimiGunler VeriYonetimi=new VeriYonetimiGunler();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            VeriYonetimi.verileriEkle(Convert.ToInt32(txtSporcuId.Text),cmbPazartesi.Text,cmbSali.Text,cmbCarsamba.Text,cmbPersembe.Text,cmbCuma.Text,cmbCumartesi.Text,cmbPazar.Text);
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
