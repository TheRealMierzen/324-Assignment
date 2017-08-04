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
    public partial class Frm_GerhardKlopper : Form
    {
        public Frm_GerhardKlopper()
        {
            InitializeComponent();
        }

        private StatAPI.StatAPI numberholder = new StatAPI.StatAPI();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(textBox1.Text, out n))
            {
                numberholder.AddNRandomNumbers(n, 0, 25);
                lblNumbers.Text = numberholder.PrintNumbers();
            }
            else
            {
                MessageBox.Show("Not a number");
            }

        }

        private void btnGetMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numberholder.Max().ToString() + " is the max number.");
        }
    }
}
