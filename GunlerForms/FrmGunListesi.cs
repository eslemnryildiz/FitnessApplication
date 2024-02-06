using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace FitnessApplication
{
    public partial class FrmGunListesi : Form
    {
        public FrmGunListesi()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);
        }
        VeriYonetimiGunler veriYonetimi=new VeriYonetimiGunler();
        

        

        private void btnGunEkle_Click(object sender, EventArgs e)
        {
            FrmGunEkle frm = new FrmGunEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        
        
        
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGunGuncelle_Click(object sender, EventArgs e)
        {
            FrmGunGuncelle frm=new FrmGunGuncelle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGunSil_Click(object sender, EventArgs e)
        {
            FrmGunSil frm=new FrmGunSil();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sporcuId = txtSporcuId.Text;
            veriYonetimi.Ara(dataGridView1, sporcuId);
        }
    }
}
