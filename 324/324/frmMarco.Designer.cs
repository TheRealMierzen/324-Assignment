﻿namespace _324
{
    partial class frmMarco
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
            this.txtBio = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBio
            // 
            this.txtBio.Enabled = false;
            this.txtBio.Location = new System.Drawing.Point(26, 44);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(479, 39);
            this.txtBio.TabIndex = 0;
            this.txtBio.Text = "Friend of animals everywhere. General baconaholic. Evil explorer. Coffee-aholic. " +
    "Gamer. \r\nCoder. Hardcore introvert. Devoted coffee ninja.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Marco Taljaard 26694379";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the number of random numbers to generate:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(26, 103);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(246, 102);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(100, 21);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "Calculate min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(131, 101);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 22);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Generate Numbers";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(26, 131);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(480, 153);
            this.lblNumbers.TabIndex = 5;
            this.lblNumbers.Text = "::numbers::";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(352, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 21);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 299);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBio);
            this.Name = "frmMarco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnClear;
    }
}