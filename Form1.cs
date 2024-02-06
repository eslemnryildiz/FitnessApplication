using FitnessApplication.EgzersizlerForms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSporcular_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSporcuListesi frm = new FrmSporcuListesi();
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
            catch { }
            
        }

        

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOdemeListesi frm = new FrmOdemeListesi();
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
            catch
            { }
            
        }

        private void btnVucutOlculeri_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVucutOlcuListesi frm = new FrmVucutOlcuListesi();
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
            catch
            { }
            
        }

        private void btnEgzersizler_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEgzersizListele frm = new FrmEgzersizListele();
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }catch { }
            
        }

        private void btnGunler_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGunListesi frm = new FrmGunListesi();
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
            catch { }
            
        }
    }
}
