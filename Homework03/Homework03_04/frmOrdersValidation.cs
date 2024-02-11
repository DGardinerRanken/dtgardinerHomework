namespace Homework03_04
{
    public partial class frmOrdersValidation : Form
    {
        //Declare and intitialize program constants
        int MINNUMBER = 100;
        int MAXNUMBER = 999;
        int MINQUANTITY = 1;
        int MAXQUANTITY = 12;
        int MINDELIVERYDAY = 1;
        int MAXDELIVERYDAY = 30;

        public frmOrdersValidation()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            int number = 0;
            int quantity = 0;
            int deliveryday = 0;

            if (IsValidData())
            {
                number = Convert.ToInt32(txtItemNumber.Text.Trim());
                quantity = Convert.ToInt32(txtQuantity.Text.Trim());
                deliveryday = Convert.ToInt32(txtEstimatedDelivery.Text.Trim());

                lblResult.Text = "Order Valid.";
            } else
            {
                lblResult.Text = "Order Invalid.";
            }
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = string.Empty;

            //Validate the Item Number Text box
            errorMessage += IsPresent(txtItemNumber.Text, "Item Number");
            errorMessage += IsInt32(txtItemNumber.Text, "Item Number");
            errorMessage += IsWithinRange(txtItemNumber.Text, "Item Number", MINNUMBER, MAXNUMBER);

            //Validate the Quantity Text box
            errorMessage += IsPresent(txtQuantity.Text, "Quantity");
            errorMessage += IsInt32(txtQuantity.Text, "Quantity");
            errorMessage += IsWithinRange(txtQuantity.Text, "Quantity", MINQUANTITY, MAXQUANTITY);

            //Validate the Estimated Delivery Day Text box
            errorMessage += IsPresent(txtEstimatedDelivery.Text, "Estimated Delivery Day");
            errorMessage += IsInt32(txtEstimatedDelivery.Text, "Estimated Delivery Day");
            errorMessage += IsWithinRange(txtEstimatedDelivery.Text, "Estimated Delivery Day",
                            MINDELIVERYDAY, MAXDELIVERYDAY);

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "Entry Error");
            }
            
                return success;
            
        }
  
        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }
            return msg;
        }
        private string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = name + " must be a valid integer value.\n";
            }
            return msg;
        }
        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " + min +
                    " and " + max;
                }
            }
            return msg;
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
