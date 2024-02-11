namespace Homework03_01
{
    partial class frmPayrollValidation
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
            lblHoursWorked = new Label();
            lblHourlyRate = new Label();
            lblGrossPay = new Label();
            txtHoursWorked = new TextBox();
            txtHourlyRate = new TextBox();
            txtGrossPay = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.BackColor = Color.LightCyan;
            lblHoursWorked.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHoursWorked.Location = new Point(86, 78);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(256, 50);
            lblHoursWorked.TabIndex = 0;
            lblHoursWorked.Text = "Hours Worked (0-84):";
            lblHoursWorked.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.BackColor = Color.LightCyan;
            lblHourlyRate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHourlyRate.Location = new Point(86, 167);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(256, 50);
            lblHourlyRate.TabIndex = 1;
            lblHourlyRate.Text = "Hourly Rate (0-99):";
            lblHourlyRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrossPay
            // 
            lblGrossPay.BackColor = Color.LightCyan;
            lblGrossPay.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblGrossPay.Location = new Point(86, 251);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(256, 50);
            lblGrossPay.TabIndex = 2;
            lblGrossPay.Text = "Gross Pay:";
            lblGrossPay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHoursWorked.Location = new Point(453, 85);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(256, 38);
            txtHoursWorked.TabIndex = 3;
            txtHoursWorked.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHourlyRate.Location = new Point(453, 174);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(256, 38);
            txtHourlyRate.TabIndex = 4;
            txtHourlyRate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrossPay
            // 
            txtGrossPay.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtGrossPay.Location = new Point(453, 258);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.Size = new Size(256, 38);
            txtGrossPay.TabIndex = 5;
            txtGrossPay.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.PowderBlue;
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(65, 348);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(164, 59);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PowderBlue;
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(318, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 59);
            btnClear.TabIndex = 7;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PowderBlue;
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(564, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(164, 59);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmPayrollValidation
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtGrossPay);
            Controls.Add(txtHourlyRate);
            Controls.Add(txtHoursWorked);
            Controls.Add(lblGrossPay);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblHoursWorked);
            Name = "frmPayrollValidation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homework 3 - Payroll Validation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoursWorked;
        private Label lblHourlyRate;
        private Label lblGrossPay;
        private TextBox txtHoursWorked;
        private TextBox txtHourlyRate;
        private TextBox txtGrossPay;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
