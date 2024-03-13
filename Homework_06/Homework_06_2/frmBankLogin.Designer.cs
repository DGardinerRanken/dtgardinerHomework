namespace Homework_06_2
{
    partial class frmBankLogin
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
            lblAccountNumber = new Label();
            lblPinNumber = new Label();
            txtAccountNumber = new TextBox();
            txtPinNumber = new TextBox();
            btnLogin = new Button();
            txtCustomerInformation = new TextBox();
            lblMakeADeposit = new Label();
            lblMakeAWithdrawal = new Label();
            txtMakeADeposit = new TextBox();
            txtMakeAWithdrawal = new TextBox();
            btnLogOut = new Button();
            btnDeposit = new Button();
            btnWithdrawal = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.BackColor = Color.LightSteelBlue;
            lblAccountNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAccountNumber.ForeColor = Color.Black;
            lblAccountNumber.Location = new Point(41, 35);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(226, 43);
            lblAccountNumber.TabIndex = 9;
            lblAccountNumber.Text = "Account #:";
            lblAccountNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPinNumber
            // 
            lblPinNumber.BackColor = Color.LightSteelBlue;
            lblPinNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblPinNumber.ForeColor = Color.Black;
            lblPinNumber.Location = new Point(41, 114);
            lblPinNumber.Name = "lblPinNumber";
            lblPinNumber.Size = new Size(226, 43);
            lblPinNumber.TabIndex = 10;
            lblPinNumber.Text = "Pin #:";
            lblPinNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtAccountNumber.Location = new Point(316, 38);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(226, 38);
            txtAccountNumber.TabIndex = 0;
            txtAccountNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPinNumber
            // 
            txtPinNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtPinNumber.Location = new Point(316, 117);
            txtPinNumber.Name = "txtPinNumber";
            txtPinNumber.Size = new Size(226, 38);
            txtPinNumber.TabIndex = 1;
            txtPinNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnLogin.Location = new Point(606, 46);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 100);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtCustomerInformation
            // 
            txtCustomerInformation.BackColor = Color.LightSteelBlue;
            txtCustomerInformation.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtCustomerInformation.Location = new Point(41, 190);
            txtCustomerInformation.Multiline = true;
            txtCustomerInformation.Name = "txtCustomerInformation";
            txtCustomerInformation.ReadOnly = true;
            txtCustomerInformation.Size = new Size(755, 205);
            txtCustomerInformation.TabIndex = 11;
            txtCustomerInformation.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMakeADeposit
            // 
            lblMakeADeposit.BackColor = Color.LightSteelBlue;
            lblMakeADeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMakeADeposit.ForeColor = Color.Black;
            lblMakeADeposit.Location = new Point(41, 433);
            lblMakeADeposit.Name = "lblMakeADeposit";
            lblMakeADeposit.Size = new Size(383, 43);
            lblMakeADeposit.TabIndex = 12;
            lblMakeADeposit.Text = "Make a Deposit?";
            lblMakeADeposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMakeAWithdrawal
            // 
            lblMakeAWithdrawal.BackColor = Color.LightSteelBlue;
            lblMakeAWithdrawal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMakeAWithdrawal.ForeColor = Color.Black;
            lblMakeAWithdrawal.Location = new Point(41, 573);
            lblMakeAWithdrawal.Name = "lblMakeAWithdrawal";
            lblMakeAWithdrawal.Size = new Size(383, 43);
            lblMakeAWithdrawal.TabIndex = 13;
            lblMakeAWithdrawal.Text = "Make a Withdrawal?";
            lblMakeAWithdrawal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMakeADeposit
            // 
            txtMakeADeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMakeADeposit.Location = new Point(41, 495);
            txtMakeADeposit.Name = "txtMakeADeposit";
            txtMakeADeposit.Size = new Size(383, 38);
            txtMakeADeposit.TabIndex = 3;
            txtMakeADeposit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMakeAWithdrawal
            // 
            txtMakeAWithdrawal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMakeAWithdrawal.Location = new Point(41, 635);
            txtMakeAWithdrawal.Name = "txtMakeAWithdrawal";
            txtMakeAWithdrawal.Size = new Size(383, 38);
            txtMakeAWithdrawal.TabIndex = 5;
            txtMakeAWithdrawal.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnLogOut.Location = new Point(234, 699);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(190, 100);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "L&ogout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnDeposit.Location = new Point(606, 443);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(190, 90);
            btnDeposit.TabIndex = 4;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdrawal
            // 
            btnWithdrawal.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnWithdrawal.Location = new Point(606, 573);
            btnWithdrawal.Name = "btnWithdrawal";
            btnWithdrawal.Size = new Size(190, 100);
            btnWithdrawal.TabIndex = 6;
            btnWithdrawal.Text = "&Withdrawal";
            btnWithdrawal.UseVisualStyleBackColor = true;
            btnWithdrawal.Click += btnWithdrawal_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(430, 699);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 100);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBankLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(856, 811);
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
            Name = "frmBankLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapter 12 Homework Problem - #2 Bank Login";
            Load += frmBankLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountNumber;
        private Label lblPinNumber;
        private TextBox txtAccountNumber;
        private TextBox txtPinNumber;
        private Button btnLogin;
        private TextBox txtCustomerInformation;
        private Label lblMakeADeposit;
        private Label lblMakeAWithdrawal;
        private TextBox txtMakeADeposit;
        private TextBox txtMakeAWithdrawal;
        private Button btnLogOut;
        private Button btnDeposit;
        private Button btnWithdrawal;
        private Button btnExit;
    }
}
