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
    public partial class FrmSporcuSecimiGuncelle : Form
    {
        public FrmSporcuSecimiGuncelle()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciGuncelle frm = new FrmOgrenciGuncelle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmenGuncelle frm = new FrmOgretmenGuncelle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void FrmSporcuSecimiGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
