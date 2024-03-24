namespace Homework07_3
{
    partial class frmBankLogin2
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
            btnExit = new Button();
            btnWithdrawal = new Button();
            btnDeposit = new Button();
            btnLogOut = new Button();
            txtMakeAWithdrawal = new TextBox();
            txtMakeADeposit = new TextBox();
            lblMakeAWithdrawal = new Label();
            lblMakeADeposit = new Label();
            txtCustomerInformation = new TextBox();
            btnLogin = new Button();
            txtPinNumber = new TextBox();
            txtAccountNumber = new TextBox();
            lblPinNumber = new Label();
            lblAccountNumber = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(426, 703);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 100);
            btnExit.TabIndex = 22;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawal
            // 
            btnWithdrawal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnWithdrawal.Location = new Point(602, 577);
            btnWithdrawal.Name = "btnWithdrawal";
            btnWithdrawal.Size = new Size(190, 100);
            btnWithdrawal.TabIndex = 20;
            btnWithdrawal.Text = "&Withdrawal";
            btnWithdrawal.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnDeposit.Location = new Point(602, 447);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(190, 90);
            btnDeposit.TabIndex = 18;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnLogOut.Location = new Point(230, 703);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 100);
            btnLogOut.TabIndex = 21;
            btnLogOut.Text = "L&ogout";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // txtMakeAWithdrawal
            // 
            txtMakeAWithdrawal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMakeAWithdrawal.Location = new Point(37, 639);
            txtMakeAWithdrawal.Name = "txtMakeAWithdrawal";
            txtMakeAWithdrawal.Size = new Size(383, 38);
            txtMakeAWithdrawal.TabIndex = 19;
            txtMakeAWithdrawal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMakeADeposit
            // 
            txtMakeADeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMakeADeposit.Location = new Point(37, 499);
            txtMakeADeposit.Name = "txtMakeADeposit";
            txtMakeADeposit.Size = new Size(383, 38);
            txtMakeADeposit.TabIndex = 17;
            txtMakeADeposit.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMakeAWithdrawal
            // 
            lblMakeAWithdrawal.BackColor = Color.LightCoral;
            lblMakeAWithdrawal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMakeAWithdrawal.ForeColor = Color.Black;
            lblMakeAWithdrawal.Location = new Point(37, 577);
            lblMakeAWithdrawal.Name = "lblMakeAWithdrawal";
            lblMakeAWithdrawal.Size = new Size(383, 43);
            lblMakeAWithdrawal.TabIndex = 27;
            lblMakeAWithdrawal.Text = "Make a Withdrawal?";
            lblMakeAWithdrawal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMakeADeposit
            // 
            lblMakeADeposit.BackColor = Color.LightCoral;
            lblMakeADeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMakeADeposit.ForeColor = Color.Black;
            lblMakeADeposit.Location = new Point(37, 437);
            lblMakeADeposit.Name = "lblMakeADeposit";
            lblMakeADeposit.Size = new Size(383, 43);
            lblMakeADeposit.TabIndex = 26;
            lblMakeADeposit.Text = "Make a Deposit?";
            lblMakeADeposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCustomerInformation
            // 
            txtCustomerInformation.BackColor = Color.LightCoral;
            txtCustomerInformation.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtCustomerInformation.Location = new Point(37, 194);
            txtCustomerInformation.Multiline = true;
            txtCustomerInformation.Name = "txtCustomerInformation";
            txtCustomerInformation.ReadOnly = true;
            txtCustomerInformation.Size = new Size(755, 205);
            txtCustomerInformation.TabIndex = 25;
            txtCustomerInformation.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnLogin.Location = new Point(602, 50);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 100);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPinNumber
            // 
            txtPinNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtPinNumber.Location = new Point(312, 121);
            txtPinNumber.Name = "txtPinNumber";
            txtPinNumber.Size = new Size(226, 38);
            txtPinNumber.TabIndex = 15;
            txtPinNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtAccountNumber.Location = new Point(312, 42);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(226, 38);
            txtAccountNumber.TabIndex = 14;
            txtAccountNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPinNumber
            // 
            lblPinNumber.BackColor = Color.LightCoral;
            lblPinNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblPinNumber.ForeColor = Color.Black;
            lblPinNumber.Location = new Point(37, 118);
            lblPinNumber.Name = "lblPinNumber";
            lblPinNumber.Size = new Size(226, 43);
            lblPinNumber.TabIndex = 24;
            lblPinNumber.Text = "Pin #:";
            lblPinNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.BackColor = Color.LightCoral;
            lblAccountNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAccountNumber.ForeColor = Color.Black;
            lblAccountNumber.Location = new Point(37, 39);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(226, 43);
            lblAccountNumber.TabIndex = 23;
            lblAccountNumber.Text = "Account #:";
            lblAccountNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmBankLogin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(828, 819);
            Controls.Add(btnExit);
            Controls.Add(btnWithdrawal);
            Controls.Add(btnDeposit);
            Controls.Add(btnLogOut);
            Controls.Add(txtMakeAWithdrawal);
            Controls.Add(txtMakeADeposit);
            Controls.Add(lblMakeAWithdrawal);
            Controls.Add(lblMakeADeposit);
            Controls.Add(txtCustomerInformation);
            Controls.Add(btnLogin);
            Controls.Add(txtPinNumber);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblPinNumber);
            Controls.Add(lblAccountNumber);
            Name = "frmBankLogin2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnWithdrawal;
        private Button btnDeposit;
        private Button btnLogOut;
        private TextBox txtMakeAWithdrawal;
        private TextBox txtMakeADeposit;
        private Label lblMakeAWithdrawal;
        private Label lblMakeADeposit;
        private TextBox txtCustomerInformation;
        private Button btnLogin;
        private TextBox txtPinNumber;
        private TextBox txtAccountNumber;
        private Label lblPinNumber;
        private Label lblAccountNumber;
    }
}
