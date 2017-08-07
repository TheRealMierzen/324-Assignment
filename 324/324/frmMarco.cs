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
            other.AddNRandomNumbers(Convert.ToInt32(txtN.Text), 5, 20);

            int n = 0;
            int.TryParse(txtN.Text, out n); other.AddNRandomNumbers(n, 0, 25);
            lblNumbers.Text = other.PrintNumbers();

            //if (int.TryParse(textBox1.Text, out n))
            //{
            //    numberholder.AddNRandomNumbers(n, 0, 25);
            //    lblNumbers.Text = numberholder.PrintNumbers();
            //}
            //else
            //{
            //    MessageBox.Show("Not a number");
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            other.clearList();
        }
    }
}
