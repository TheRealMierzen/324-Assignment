using System;
using System.Windows.Forms;

namespace _324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerhard_Click(object sender, EventArgs e)
        {
            Frm_GerhardKlopper gkform = new Frm_GerhardKlopper();
            gkform.Show();
        }

        private void btnZac_Click(object sender, EventArgs e)
        {

        }

        private void btnStefan_Click(object sender, EventArgs e)
        {
            frmStefanMalan smform = new frmStefanMalan();
            smform.Show();
        }

        private void btnDylan_Click(object sender, EventArgs e)
        {

        }

        private void btnLouis_Click(object sender, EventArgs e)
        {

        }

        private void btnMarco_Click(object sender, EventArgs e)
        {
            frmMarco mForm = new frmMarco();
            mForm.Show();
        }
    }
}
