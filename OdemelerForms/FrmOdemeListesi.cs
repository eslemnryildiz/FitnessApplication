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
    public partial class FrmOdemeListesi : Form
    {
        public FrmOdemeListesi()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);
        }
        VeriYonetimiOdemeler veriYonetimi = new VeriYonetimiOdemeler();

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeEkle frm = new FrmOdemeEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            FrmOdemeSil frm = new FrmOdemeSil();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnOdemeGuncelle_Click(object sender, EventArgs e)
        {
            FrmOdemeGuncelle frm= new FrmOdemeGuncelle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string ad=txtSporcuAd.Text;
            veriYonetimi.Ara(dataGridView1, ad);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 frm=new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void txtSporcuId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
