namespace Homework_06_2
{
    public partial class frmBankLogin : Form
    {
        //Declare class variables
        List<Account> accounts = new List<Account>();
        string currentAccountNumber = string.Empty;
        string currentPinNumber = string.Empty;
        int accountNumberLocation = 0;
        int pinNumberLocation = 0;
        bool youAreLoggedIn = false;
        public frmBankLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AttemptToLogin();
        }

        private void AttemptToLogin()
        {
            bool keepGoing = ValidateAccountNumber();

            if (keepGoing )
            {
                keepGoing = ValidatePinNumber();
            }
            else
            {
                return;
            }

            if ((accountNumberLocation == -1) ||
                (pinNumberLocation == -1) ||
                (accountNumberLocation != pinNumberLocation))
            {
                youAreLoggedIn = false;
                ShowErrorMessage("Account Number or PIN Number Error", "ACCT OR PIN NUMBER ERROR");
                txtAccountNumber.Text = string.Empty;
                txtPinNumber.Text = string.Empty;
                txtAccountNumber.Focus();
                
                return;
            }

            //Inputted a valid account number and pin number that matches each other,
            //Show the customer welcome information.
            DisplayCustomerInformation();

        }
            
       
        private bool ValidatePinNumber()
        {
            string pinNumber = txtPinNumber.Text.Trim();

            if (string.IsNullOrEmpty(pinNumber))
            {
                ShowErrorMessage("You Must Enter A Pin Number.", "NO PIN NUMBER INPUTTED");

                txtPinNumber.Focus();
                return false;
            }

            //Look through all existing customers attempting to find a matching acct number
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (pinNumber == accounts[lcv].GetPinNumber())
                {
                    currentAccountNumber = pinNumber;
                    pinNumberLocation = lcv;
                    return true;
                }
            }

            ShowErrorMessage("That Pin Does Not Exist", "INVALID PIN NUMBER");
            txtPinNumber.Text = "";
            txtPinNumber.Focus();
            pinNumberLocation = -1;
            return false;
        }

        private bool ValidateAccountNumber()
        {
            string acctNum = txtAccountNumber.Text.Trim();

            if (string.IsNullOrEmpty(acctNum))
            {
                ShowErrorMessage("You Must Enter An Account Number.", "NO ACCOUNT NUMBER INPUTTED");

                txtAccountNumber.Focus();
                return false;
            }

            //Look through all existing customers attempting to find a matching acct number
            for (int lcv =  0; lcv < accounts.Count; lcv++)
            {
                if (acctNum == accounts[lcv].GetAccountNumber())
                {
                    currentAccountNumber = acctNum;
                    accountNumberLocation = lcv;
                    return true;
                }
            }

            ShowErrorMessage("That Account Number Does Not Exist.", "INVALID ACCOUNT NUMBER");
            txtAccountNumber.Text = "";
            txtAccountNumber.Focus();
            accountNumberLocation = -1;
            return false;
        }

        private void DisplayCustomerInformation()
        {
            int local = accountNumberLocation;
            string outputStr = string.Empty;

            outputStr += "\r\nWelcome " + " " + accounts[local].GetTitle() + " " + 
                                                accounts[local].GetFirstName() + " " + 
                                                accounts[local].GetLastName() + "\r\n\r\n" + 
                                                "Your Current Balance Is: " + 
                                                accounts[local].GetBalance().ToString("c");

            txtCustomerInformation.Text = outputStr;
            SetPostLoginControls();
        }

        private void SetPreLoginControls()
        {
            youAreLoggedIn = false;
            btnLogin.Enabled = true;
            btnLogOut.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdrawal.Enabled = false;
            currentAccountNumber = string.Empty;
            currentPinNumber = string.Empty;
            accountNumberLocation = -1;
            pinNumberLocation = -1;
        }

        private void SetPostLoginControls()
        {
            youAreLoggedIn = true;
            btnLogin.Enabled = false;
            btnLogOut.Enabled = true;
            btnDeposit.Enabled = true;
            btnWithdrawal.Enabled = true;
            //ClearTextBoxes();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            TryToDeposit();
        }

        private void TryToDeposit()
        {
            bool result;
            decimal deposit = 0.00m;
            string depositStr = txtMakeADeposit.Text.Trim();
            int location = accountNumberLocation;

            //CheckForNoInput
            if (string.IsNullOrEmpty(depositStr))
            {
                ShowErrorMessage("You Must Enter A Number > 0", "NO DEPOSIT AMOUNT WAS ENTERED");
                return;
            }

            try
            {
                result = decimal.TryParse(depositStr, out deposit);
                //There was non numeric input
                if (!result)
                {
                    throw new FormatException();
                }

                accounts[location].MakeDeposit(deposit);
                DisplayCustomerInformation();
                txtMakeADeposit.Text = string.Empty;
                txtMakeADeposit.Focus();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message +
                                "\n\n" + "Non-Numeric Deposit Inputted", "ILLEGAL DEPOSIT VALUE");
                return;
            }
        }
        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            TryToWithdrawal();
        }

        private void TryToWithdrawal()
        {
            bool result;
            decimal withdrawal = 0.00m;
            string withdrawalStr = txtMakeAWithdrawal.Text.Trim();
            int location = accountNumberLocation;

            //CheckForNoInput
            if (string.IsNullOrEmpty(withdrawalStr))
            {
                ShowErrorMessage("You Must Enter A Number > 0", "NO WITHDRAWAL AMOUNT WAS ENTERED");
                return;
            }

            try
            {
                result = decimal.TryParse(withdrawalStr, out withdrawal);
                //There was non numeric input
                if (!result)
                {
                    throw new FormatException();
                }

                accounts[location].MakeWithdrawal(withdrawal);
                DisplayCustomerInformation();
                txtMakeAWithdrawal.Text = string.Empty;
                txtMakeAWithdrawal.Focus();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message +
                                "\n\n" + "Non-Numeric Withdrawal Inputted", "ILLEGAL WITHDRAWAL VALUE");
                return;
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SetPreLoginControls();
            txtCustomerInformation.Text = string.Empty;
            txtAccountNumber.Focus();
            txtAccountNumber.Text = string.Empty;
            txtPinNumber.Text = string.Empty;
            btnLogin.Enabled = true;
            btnLogOut.Enabled = false;
            txtMakeADeposit.Text = string.Empty;
            txtMakeAWithdrawal.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Are You Sure You Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void frmBankLogin_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account("Mr.", "Jeffrey", "Scott", "123-45-6789", "1234", 10000.00m));
            accounts.Add(new Account("Mr.", "Evan", "Gudmestad", "234-56-7890", "2345", 2587.00m));
            accounts.Add(new Account("Mr.", "Doug", "Geggleman", "345-67-8901", "3456", 7654.00m));
            accounts.Add(new Account("Mr.", "James", "Kaufmann", "456-78-9012", "4567", 87654.00m));
            accounts.Add(new Account("Ms.", "Shannon", "Brueggemann", "567-89-0123", "5678", 782.00m));

            SetPreLoginControls();
        }
    }
}
