using System;
using System.Windows.Forms;

namespace _324
{
    public partial class Frm_ZacVdSchyff : Form
    {
        public Frm_ZacVdSchyff()
        {
            InitializeComponent();
        }

        private StatAPI.StatAPI myList = new StatAPI.StatAPI();

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n = 0;           
            if (int.TryParse(txtNum.Text, out n))
            {
                if (myList.checkValidN(n))
                {
                    myList.AddNRandomNumbers(n, 0, 25);
                    lblNumbers.Text = myList.PrintNumbers();
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

        private void btnSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The sum total of the numbers is: " + myList.SumTotal());
        }
    }
}
