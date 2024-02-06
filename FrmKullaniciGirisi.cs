using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessApplication
{
    public partial class FrmKullaniciGirisi : Form
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();

        }
        string kullaniciNumarasi;
        string sifre;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciNumarasi = txtKullaniciNumarasi.Text;
            sifre = txtSifre.Text;
            if (IsValidUser(kullaniciNumarasi, sifre))
            {
                try
                {
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.ShowDialog();
                    this.Visible = true;
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!");
            }

        }
        private bool IsValidUser(string kullaniciNumarasi, string sifre)
        {
            return (kullaniciNumarasi == "222923106" && sifre == "eslem123");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtKullaniciNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
