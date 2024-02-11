namespace Homework03_04._5
{
    //I am unsure as to why my program is throwing exceptions when it should be passing through

    public partial class frmOrdersExceptions : Form
    {
        //Declare and intitialize program constants
        int MINNUMBER = 100;
        int MAXNUMBER = 999;
        int MINQUANTITY = 1;
        int MAXQUANTITY = 12;
        int MINDELIVERYDAY = 1;
        int MAXDELIVERYDAY = 30;

        public frmOrdersExceptions()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateItemNumber(txtItemNumber);

            if (keepGoing)
            {
                keepGoing = ValidateItemQuantity(txtQuantity);
                keepGoing = ValidateDeliveryDay(txtEstimatedDelivery);
            } else
            {
                lblResult.Text = "Invalid Order.";
                return;
            }
            if (keepGoing )
            {
                ValidateOrder();
            }
        }
        private bool ValidateItemNumber(Control control)
        {
            bool isValid = IsTextBoxNotEmpty(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxNotNumeric(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxWithinRangeNumber(control);

            if (!isValid )
            {
                return false;
            }

            return true;
        }
        private void ValidateOrder()
        {
            lblResult.Text = "Valid Order.";
        }
        private bool ValidateItemQuantity(Control control)
        {
            bool isValid = IsTextBoxNotEmpty(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxNotNumeric(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxWithinRangeQuantity(control);

            if (!isValid)
            {
                return false;
            }

            return true;
        }
        private bool ValidateDeliveryDay(Control control)
        {
            bool isValid = IsTextBoxNotEmpty(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxNotNumeric(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxWithinRangeNumber(control);

            if (!isValid)
            {
                return false;
            }

            return true;
        }
        private bool IsTextBoxNotEmpty(Control control)
        {
            try
            {
                if (control.Text == "")
                {
                    throw new ArgumentNullException();
                }
                return true;
            }
            catch (ArgumentNullException ane)
            {
                ShowErrorMessage(ane.Message + "\n\n" + ane.GetType().ToString() + "\n\n" + ane.StackTrace, "Exception Raised");
            }
            return true;
        }
        private bool IsTextBoxNotNumeric(Control control)
        {
            bool result;

            try
            {
                result = int.TryParse(control.Text, out _);
                if (!result)
                {
                    throw new FormatException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                ShowErrorMessage(fe.Message + "\n\n" + fe.GetType().ToString() + "\n\n" + fe.StackTrace, "Exception Raised");
            }
            return true;
        }
        private bool IsTextBoxWithinRangeNumber(Control control)
        {
            
            int number = Convert.ToInt32(txtItemNumber.Text);

            try
            {
                if (number > MINNUMBER || number < MAXNUMBER)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }

            catch (ArgumentOutOfRangeException aaae)
            {
                ShowErrorMessage(aaae.Message + "\n\n" + aaae.GetType().ToString() + "\n\n" + aaae.StackTrace, "Exception Raised");
            }
            return true;
        }
        private bool IsTextBoxWithinRangeQuantity(Control control)
        {
            
            int quantity = Convert.ToInt32(txtQuantity.Text);

            try
            {
                if (quantity < MINQUANTITY || quantity > MAXQUANTITY)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }

            catch (ArgumentOutOfRangeException aaae)
            {
                ShowErrorMessage(aaae.Message + "\n\n" + aaae.GetType().ToString() + "\n\n" + aaae.StackTrace, "Exception Raised");
            }
            return true;
        }
        private bool IsTextBoxWithinRangeDay(Control control)
        {
            
            int deliveryDay = Convert.ToInt32(txtEstimatedDelivery.Text);

            try
            {
                if (deliveryDay < MINDELIVERYDAY || deliveryDay > MAXDELIVERYDAY)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }

            catch (ArgumentOutOfRangeException aaae)
            {
                ShowErrorMessage(aaae.Message + "\n\n" + aaae.GetType().ToString() + "\n\n" + aaae.StackTrace, "Exception Raised");
            }
            return true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtEstimatedDelivery.Text = string.Empty;
            txtItemNumber.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtItemNumber.Focus();
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
    }
}
