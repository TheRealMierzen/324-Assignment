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

        private void btnMin_Click(object sender, EventArgs e)
        {


            if (txtN.Text != "")
            {
                StatAPI.StatAPI other = new StatAPI.StatAPI();
                other.AddNRandomNumbers(Convert.ToInt32(txtN.Text), 5, 20);
                MessageBox.Show("The minimum number that was generated is: " + other.min().ToString());
            }
            else
            {
                MessageBox.Show("Please enter a number in the field");
            }

        }

        
    }
}
