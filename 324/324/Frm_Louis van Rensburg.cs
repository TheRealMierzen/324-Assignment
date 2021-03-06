﻿using System;
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
                statAPI.clearList();
                int n = 0;
                n = int.Parse(textBox_Num.Text);

                if (statAPI.checkValidN(n))
                {
                    statAPI.AddNRandomNumbers(n, 0, 50);
                    lbl_Numbers.Text = statAPI.PrintNumbers();

                    MessageBox.Show(String.Format("Standard Deviation: {0:N3}", statAPI.StandardDeviation(n)));
                }
                else
                {
                    MessageBox.Show("The entered value is invalid. Please enter a value between 5 and 20.");
                }
            }
            catch (FormatException f)
            {
                MessageBox.Show("Please enter a integer" + f);
                textBox_Num.Clear();
                textBox_Num.Focus();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
