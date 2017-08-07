using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _324
{
    public partial class frmStefanMalan : Form
    {
        public frmStefanMalan()
        {
            InitializeComponent();
        }

        private StatAPI.StatAPI stat = new StatAPI.StatAPI();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int n = 0;
            double ave = 0.0;
            n = Convert.ToInt32(txtN.Text);
            stat.AddNRandomNumbers(n, 0, 50);
            ave = stat.Average(n);
            lblAverage.Text = ave.ToString();
            label1.Text = stat.PrintNumbers();
        }
    }
}
