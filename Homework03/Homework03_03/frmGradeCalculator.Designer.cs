namespace Homework03_03
{
    partial class frmGradeCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTest1 = new Label();
            lblTest2 = new Label();
            lblTest3 = new Label();
            lblAvgGrade = new Label();
            txtTest1 = new TextBox();
            txtTest2 = new TextBox();
            txtTest3 = new TextBox();
            txtAvgGrade = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTest1
            // 
            lblTest1.BackColor = Color.Thistle;
            lblTest1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTest1.Location = new Point(163, 50);
            lblTest1.Name = "lblTest1";
            lblTest1.Size = new Size(205, 39);
            lblTest1.TabIndex = 7;
            lblTest1.Text = "Test #1:";
            lblTest1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTest2
            // 
            lblTest2.BackColor = Color.Thistle;
            lblTest2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTest2.Location = new Point(163, 114);
            lblTest2.Name = "lblTest2";
            lblTest2.Size = new Size(205, 39);
            lblTest2.TabIndex = 8;
            lblTest2.Text = "Test #2:";
            lblTest2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTest3
            // 
            lblTest3.BackColor = Color.Thistle;
            lblTest3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTest3.Location = new Point(163, 177);
            lblTest3.Name = "lblTest3";
            lblTest3.Size = new Size(205, 39);
            lblTest3.TabIndex = 9;
            lblTest3.Text = "Test #3:";
            lblTest3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvgGrade
            // 
            lblAvgGrade.BackColor = Color.Thistle;
            lblAvgGrade.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAvgGrade.Location = new Point(163, 240);
            lblAvgGrade.Name = "lblAvgGrade";
            lblAvgGrade.Size = new Size(205, 39);
            lblAvgGrade.TabIndex = 10;
            lblAvgGrade.Text = "Avg / Grade";
            lblAvgGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTest1
            // 
            txtTest1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTest1.Location = new Point(419, 51);
            txtTest1.Name = "txtTest1";
            txtTest1.Size = new Size(205, 38);
            txtTest1.TabIndex = 0;
            txtTest1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTest2
            // 
            txtTest2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTest2.Location = new Point(419, 115);
            txtTest2.Name = "txtTest2";
            txtTest2.Size = new Size(205, 38);
            txtTest2.TabIndex = 1;
            txtTest2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTest3
            // 
            txtTest3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTest3.Location = new Point(419, 178);
            txtTest3.Name = "txtTest3";
            txtTest3.Size = new Size(205, 38);
            txtTest3.TabIndex = 2;
            txtTest3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAvgGrade
            // 
            txtAvgGrade.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtAvgGrade.Location = new Point(419, 241);
            txtAvgGrade.Name = "txtAvgGrade";
            txtAvgGrade.ReadOnly = true;
            txtAvgGrade.Size = new Size(205, 38);
            txtAvgGrade.TabIndex = 6;
            txtAvgGrade.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightPink;
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(94, 343);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 59);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightPink;
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(318, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 59);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightPink;
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(539, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 59);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmGradeCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtAvgGrade);
            Controls.Add(txtTest3);
            Controls.Add(txtTest2);
            Controls.Add(txtTest1);
            Controls.Add(lblAvgGrade);
            Controls.Add(lblTest3);
            Controls.Add(lblTest2);
            Controls.Add(lblTest1);
            Name = "frmGradeCalculator";
            Text = "Homework 3 Problem 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTest1;
        private Label lblTest2;
        private Label lblTest3;
        private Label lblAvgGrade;
        private TextBox txtTest1;
        private TextBox txtTest2;
        private TextBox txtTest3;
        private TextBox txtAvgGrade;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
