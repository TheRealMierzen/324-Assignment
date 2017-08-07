using System;
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

            stat.clearList();
            int n = 0;
            double ave = 0.0;

            if (int.TryParse(txtN.Text, out n))
            {
                stat.AddNRandomNumbers(n, 5, 20);
                lblNumbers.Text = stat.PrintNumbers();

                n = Convert.ToInt32(txtN.Text);
                stat.AddNRandomNumbers(n, 0, 50);
                ave = stat.Average(n);
                lblAverage.Text = ave.ToString();
                label1.Text = stat.PrintNumbers();
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
            
            
        }
    }
}
