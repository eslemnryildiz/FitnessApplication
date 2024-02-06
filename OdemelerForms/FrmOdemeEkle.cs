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
    public partial class FrmOdemeEkle : Form
    {
        public FrmOdemeEkle()
        {
            InitializeComponent();
        }

        VeriYonetimiOdemeler veriYonetimi=new VeriYonetimiOdemeler();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sporcuID = Convert.ToInt32(txtSporcuId.Text);
            string ad = veriYonetimi.AdBilgisiniGetir(sporcuID);
            DateTime tarih = dtpTarih.Value;
            int miktar = Convert.ToInt32(txtMiktar.Text);
            string aciklama = txtAciklama.Text;

            veriYonetimi.verileriEkle(sporcuID, ad, tarih, miktar, aciklama);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FrmOdemeListesi frm = new FrmOdemeListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
