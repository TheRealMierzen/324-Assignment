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
                if (stat.checkValidN(n))
                {
                    stat.AddNRandomNumbers(n, 0, 50);
                    label1.Text = stat.PrintNumbers();

                    n = Convert.ToInt32(txtN.Text);
                    ave = stat.Average(n);
                    MessageBox.Show("The average of the numbers is: " + ave.ToString());
                }
                else
                {
                    MessageBox.Show("The entered value is invalid. Please enter a value between 5 and 20.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
            
            
        }
    }
}
