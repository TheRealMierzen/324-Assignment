using System;
using System.Windows.Forms;

namespace _324
{
    public partial class frmMarco : Form
    {
        public frmMarco()
        {
            InitializeComponent();
        }

        StatAPI.StatAPI other = new StatAPI.StatAPI();

        private void btnMin_Click(object sender, EventArgs e)
        {

            if (txtN.Text != "")
            {          
                MessageBox.Show("The minimum number that was generated is: " + other.min().ToString());
            }
            else
            {
                MessageBox.Show("Please enter a number in the field");
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            other.clearList();
            int n = 0;
            if (int.TryParse(txtN.Text, out n))
            {
                other.AddNRandomNumbers(n, 5, 20);
                lblNumbers.Text = other.PrintNumbers();
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            other.clearList();
        }
    }
}
