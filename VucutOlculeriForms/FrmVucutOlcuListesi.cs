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
    public partial class FrmVucutOlcuListesi : Form
    {
        public FrmVucutOlcuListesi()
        {
            InitializeComponent();
            veriYonetimi.VerileriGetir(dataGridView1);
        }
        VeriYonetimiVucutOlcu veriYonetimi = new VeriYonetimiVucutOlcu();
        private void btnOlcuEkle_Click(object sender, EventArgs e)
        {
            FrmVucutOlcuEkle frm = new FrmVucutOlcuEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            FrmVucutOlcuSil frm= new FrmVucutOlcuSil();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnOlcuGuncelle_Click(object sender, EventArgs e)
        {
            FrmVucutOlcuGuncelle frm=new FrmVucutOlcuGuncelle();
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            string ad = txtSporcuAd.Text;
            veriYonetimi.Ara(dataGridView1, ad);
        }

        
    }
}
