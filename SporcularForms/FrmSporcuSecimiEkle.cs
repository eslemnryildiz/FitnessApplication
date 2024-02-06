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
    public partial class FrmSporcuSecimiEkle : Form
    {
        public FrmSporcuSecimiEkle()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciEkle frm = new FrmOgrenciEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmenEkle frm=new FrmOgretmenEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
