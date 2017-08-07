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
    public partial class Frm_Louis_van_Rensburg : Form
    {
        public Frm_Louis_van_Rensburg()
        {
            InitializeComponent();
        }

        private void btn_GenNum_Click(object sender, EventArgs e)
        {
            try
            {
                StatAPI.StatAPI statAPI = new StatAPI.StatAPI();
                int n = 0;
                n = int.Parse(textBox_Num.Text);

                statAPI.AddNRandomNumbers(n, 0, 50);
                lbl_Numbers.Text = statAPI.PrintNumbers();

                lbl_StandardDeviation.Text = String.Format("Standard Deviation: {0:N3}", statAPI.StandardDeviation(n));
            }
            catch (FormatException f)
            {
                MessageBox.Show("Entered value is not a number" + f);
                textBox_Num.Clear();
                textBox_Num.Focus();
            }
        }
    }
}
