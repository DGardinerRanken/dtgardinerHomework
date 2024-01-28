namespace Homework02_02
{
    partial class Form1
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
            txtChicken1 = new TextBox();
            txtChicken2 = new TextBox();
            txtChicken3 = new TextBox();
            txtChicken4 = new TextBox();
            lblEnterNumber = new Label();
            lblDisplayResult = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtChicken1
            // 
            txtChicken1.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            txtChicken1.Location = new Point(26, 98);
            txtChicken1.Name = "txtChicken1";
            txtChicken1.Size = new Size(169, 39);
            txtChicken1.TabIndex = 0;
            txtChicken1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtChicken2
            // 
            txtChicken2.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            txtChicken2.Location = new Point(218, 98);
            txtChicken2.Name = "txtChicken2";
            txtChicken2.Size = new Size(169, 39);
            txtChicken2.TabIndex = 1;
            txtChicken2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtChicken3
            // 
            txtChicken3.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            txtChicken3.Location = new Point(411, 98);
            txtChicken3.Name = "txtChicken3";
            txtChicken3.Size = new Size(169, 39);
            txtChicken3.TabIndex = 2;
            txtChicken3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtChicken4
            // 
            txtChicken4.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            txtChicken4.Location = new Point(604, 98);
            txtChicken4.Name = "txtChicken4";
            txtChicken4.Size = new Size(169, 39);
            txtChicken4.TabIndex = 3;
            txtChicken4.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEnterNumber
            // 
            lblEnterNumber.BackColor = SystemColors.ActiveCaption;
            lblEnterNumber.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblEnterNumber.Location = new Point(83, 22);
            lblEnterNumber.Name = "lblEnterNumber";
            lblEnterNumber.Size = new Size(646, 59);
            lblEnterNumber.TabIndex = 4;
            lblEnterNumber.Text = "Enter Number Of Eggs Laid By Each Chicken:";
            lblEnterNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDisplayResult
            // 
            lblDisplayResult.BackColor = SystemColors.ActiveCaption;
            lblDisplayResult.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblDisplayResult.Location = new Point(106, 253);
            lblDisplayResult.Name = "lblDisplayResult";
            lblDisplayResult.Size = new Size(567, 59);
            lblDisplayResult.TabIndex = 5;
            lblDisplayResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(312, 164);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(173, 59);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(106, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(173, 59);
            btnClear.TabIndex = 7;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(500, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 59);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblDisplayResult);
            Controls.Add(lblEnterNumber);
            Controls.Add(txtChicken4);
            Controls.Add(txtChicken3);
            Controls.Add(txtChicken2);
            Controls.Add(txtChicken1);
            Name = "Form1";
            Text = "Chicken Farmer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtChicken1;
        private TextBox txtChicken2;
        private TextBox txtChicken3;
        private TextBox txtChicken4;
        private Label lblEnterNumber;
        private Label lblDisplayResult;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
