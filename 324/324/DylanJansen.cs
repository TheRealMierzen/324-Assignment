using System;
using System.Windows.Forms;

namespace _324
{
    public partial class DylanJansen : Form
    {
        public DylanJansen()
        {
            InitializeComponent();
        }
        private StatAPI.StatAPI numb = new StatAPI.StatAPI();

        private void button1_Click(object sender, EventArgs e)
        {
            numb.clearList();
            int n = 0;
            if (int.TryParse(textBox1.Text, out n))
            {
                if (numb.checkValidN(n))
                {
                    numb.AddNRandomNumbers(n, 0, 50);
                    label3.Text = numb.PrintNumbers();
                }
                else
                {
                    MessageBox.Show("The entered value is invalid. Please enter a value between 5 and 20.");
                }
            }
            else
            {
                MessageBox.Show("Not a number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numb.GetMedian().ToString() + " is the median number.");
        }
    }
}
