namespace Homework03_01
{
    public partial class frmPayrollValidation : Form
    {

        //Declare and initialize program constants
        const decimal MAXHOURS = 84.0m;
        const decimal MINHOURS = 0m;
        const decimal MINHRATE = 0.0m;
        const decimal MAXHRATE = 99.99m;
        const decimal MAXNONOT = 40.0m;
        const decimal OTRATE   = 2.0m;

        public frmPayrollValidation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal hoursWorked = 0.0m;
            decimal hourlyRate = 0.0m;
            decimal grossPay = 0.0m;

            if (IsValidData())
            {
                hoursWorked = Convert.ToDecimal(txtHoursWorked.Text.Trim());
                hourlyRate = Convert.ToDecimal(txtHourlyRate.Text.Trim());
                CalculateGrossPay(hoursWorked, hourlyRate, ref grossPay);

                txtGrossPay.Text = ($"{grossPay:c}");
            }
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = string.Empty;

            //Validate the hours worked text box
            errorMessage += IsPresent(txtHoursWorked.Text, "Hours Worked");
            errorMessage += IsDecimal(txtHoursWorked.Text, "Hours Worked"); 
            errorMessage += IsWithinRange(txtHoursWorked.Text, "Hours Worked", MINHOURS, MAXHOURS);

            //Validate the Hourly Rate
            errorMessage += IsPresent(txtHourlyRate.Text, "Hourly Rate");
            errorMessage += IsDecimal(txtHourlyRate.Text, "Hourly Rate");
            errorMessage += IsWithinRange(txtHourlyRate.Text, "Hourly Rate", MINHRATE, MAXHRATE);

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "Entry Error.");
            }

            return success;
        }
        private void CalculateGrossPay(decimal hw, decimal hr, ref decimal gp)
        {
            if (hw <= MAXNONOT)
            {
                // no overtime worked
                gp = hw * hr;
            }
            else
            {
                // worked some overtime
                gp = (MAXNONOT * hr) + ((hw - MAXNONOT) * hr * OTRATE);
            }
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
        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }
            return msg;
        }
        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if(number < MINHOURS || number > MAXHOURS)
                {
                    msg = name + " must be between " + MINHOURS +
                    " and " + MAXHOURS;  
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
            txtGrossPay.Text = string.Empty;
            txtHourlyRate.Text = string.Empty;
            txtHoursWorked.Text = string.Empty;
            txtHoursWorked.Focus();
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
