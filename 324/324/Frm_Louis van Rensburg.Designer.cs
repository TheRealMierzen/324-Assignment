namespace _324
{
    partial class Frm_Louis_van_Rensburg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Louis_van_Rensburg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Numbers = new System.Windows.Forms.Label();
            this.lbl_StandardDeviation = new System.Windows.Forms.Label();
            this.btn_GenNum = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter amount of numbers generated";
            // 
            // lbl_Numbers
            // 
            this.lbl_Numbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Numbers.Location = new System.Drawing.Point(12, 159);
            this.lbl_Numbers.Name = "lbl_Numbers";
            this.lbl_Numbers.Size = new System.Drawing.Size(658, 193);
            this.lbl_Numbers.TabIndex = 2;
            // 
            // lbl_StandardDeviation
            // 
            this.lbl_StandardDeviation.AutoSize = true;
            this.lbl_StandardDeviation.Location = new System.Drawing.Point(12, 381);
            this.lbl_StandardDeviation.Name = "lbl_StandardDeviation";
            this.lbl_StandardDeviation.Size = new System.Drawing.Size(0, 13);
            this.lbl_StandardDeviation.TabIndex = 3;
            // 
            // btn_GenNum
            // 
            this.btn_GenNum.Location = new System.Drawing.Point(12, 122);
            this.btn_GenNum.Name = "btn_GenNum";
            this.btn_GenNum.Size = new System.Drawing.Size(75, 23);
            this.btn_GenNum.TabIndex = 4;
            this.btn_GenNum.Text = "Generate Numbers";
            this.btn_GenNum.UseVisualStyleBackColor = true;
            this.btn_GenNum.Click += new System.EventHandler(this.btn_GenNum_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(595, 381);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(194, 88);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(100, 20);
            this.textBox_Num.TabIndex = 6;
            // 
            // Frm_Louis_van_Rensburg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 416);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.btn_GenNum);
            this.Controls.Add(this.lbl_StandardDeviation);
            this.Controls.Add(this.lbl_Numbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Louis_van_Rensburg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Louis_van_Rensburg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Numbers;
        private System.Windows.Forms.Label lbl_StandardDeviation;
        private System.Windows.Forms.Button btn_GenNum;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_Num;
    }
}