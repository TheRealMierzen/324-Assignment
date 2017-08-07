namespace _324
{
    partial class Frm_ZacVdSchyff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBio = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBio.Location = new System.Drawing.Point(12, 9);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(298, 54);
            this.lblBio.TabIndex = 0;
            this.lblBio.Text = "Zac Van Der Schyff 23589418\r\nBorn in Pta on 25 March 1993\r\nLives in Pretoria, stu" +
    "dies BSc IT at the North West University \r\nPotchefstroom campus. ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 72);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(158, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Amount of numbers to generate:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(167, 69);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(55, 20);
            this.txtNum.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(228, 66);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(82, 23);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Generate";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(12, 94);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(297, 221);
            this.lblNumbers.TabIndex = 4;
            this.lblNumbers.Text = ".......................";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(12, 318);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "Sum Total";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Frm_ZacVdSchyff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 364);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblBio);
            this.Name = "Frm_ZacVdSchyff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ZacVdSchyff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnSum;
    }
}