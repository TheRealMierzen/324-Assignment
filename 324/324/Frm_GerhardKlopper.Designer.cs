namespace _324
{
    partial class Frm_GerhardKlopper
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnGetMax = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBio
            // 
            this.lblBio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBio.Location = new System.Drawing.Point(9, 7);
            this.lblBio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(540, 65);
            this.lblBio.TabIndex = 0;
            this.lblBio.Text = "Gerhard Klopper\r\n\r\nLives in Kuruman in the Northern Cape. Went to school in Kroon" +
    "stad. Goes to NWU Potchefstroom and is now a 3rd year IT student.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(9, 79);
            this.lblRandom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(213, 13);
            this.lblRandom.TabIndex = 2;
            this.lblRandom.Text = "Input a number for random number creation:";
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(9, 125);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(540, 177);
            this.lblNumbers.TabIndex = 3;
            this.lblNumbers.Text = "::numbers::";
            // 
            // btnGetMax
            // 
            this.btnGetMax.Location = new System.Drawing.Point(458, 304);
            this.btnGetMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetMax.Name = "btnGetMax";
            this.btnGetMax.Size = new System.Drawing.Size(90, 42);
            this.btnGetMax.TabIndex = 4;
            this.btnGetMax.Text = "Get Max";
            this.btnGetMax.UseVisualStyleBackColor = true;
            this.btnGetMax.Click += new System.EventHandler(this.btnGetMax_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(453, 83);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 30);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Numbers";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Frm_GerhardKlopper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 355);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnGetMax);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_GerhardKlopper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_GerhardKlopper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnGetMax;
        private System.Windows.Forms.Button btnCreate;
    }
}