using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;

namespace FitnessApplication
{
    public partial class FrmSporcuListesi : Form
    {

        public FrmSporcuListesi()
        {
            InitializeComponent();
        }

        Sporcu sporcu;
        private void FrmSporcuListesi_Load(object sender, EventArgs e)
        {
            DateTime gecici = DateTime.Now;
            sporcu = new Sporcu(null, null, gecici, null, null, null, gecici,null);
            sporcu.VerileriGetir(dataGridView1);
        }

        private void btnSporcuEkle_Click(object sender, EventArgs e)
        {
            FrmSporcuSecimiEkle frm = new FrmSporcuSecimiEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnSporcuSil_Click(object sender, EventArgs e)
        {
            FrmSporcuSil frm = new FrmSporcuSil();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnSporcuGuncelle_Click(object sender, EventArgs e)
        {
            FrmSporcuSecimiGuncelle frm = new FrmSporcuSecimiGuncelle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        

        private void btnAra_Click(object sender, EventArgs e)
        {
            DateTime gecici=DateTime.Now;
            sporcu = new Sporcu(null,null,gecici,null,null,null,gecici,null);
            sporcu.ara(dataGridView1, txtAd);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        
    }
}
