using System;
using System.Windows.Forms;

namespace _324
{
    public partial class Frm_GerhardKlopper : Form
    {
        public Frm_GerhardKlopper()
        {
            InitializeComponent();
        }

        private StatAPI.StatAPI numberholder = new StatAPI.StatAPI();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            numberholder.clearList();
            int n = 0;
            if (int.TryParse(textBox1.Text, out n))
            {
                if (numberholder.checkValidN(n))
                {
                    numberholder.AddNRandomNumbers(n, 0, 50);
                }
                else
                {
                    MessageBox.Show("The entered value is invalid. Please enter a value between 5 and 20.");
                }
                numberholder.AddNRandomNumbers(n, 0, 25);
                lblNumbers.Text = numberholder.PrintNumbers();
            }
            else
            {
                MessageBox.Show("Please enter a integer");
            }
            lblNumbers.Text = numberholder.PrintNumbers();

        }

        private void btnGetMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numberholder.Max().ToString() + " is the max number.");
        }

    }
}
