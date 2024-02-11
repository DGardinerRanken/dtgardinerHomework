using System.CodeDom;

namespace Homework03_02
{
    public partial class frmBMIValidation : Form
    {
        //Declare and Initialize program constants
        const decimal UNDERWEIGHT = 18.49m;
        const decimal OPTIMALWEIGHT = 24.99m;
        const decimal OVERWEIGHT = 29.99m;
        const decimal OBESE = 30m;
        const decimal MINHEIGHT = 12m;
        const decimal MAXHEIGHT = 96m;
        const decimal MINWEIGHT = 1m;
        const decimal MAXWEIGHT = 777m;

        public frmBMIValidation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal weight = 0m;
            decimal height = 0m;
            decimal BMI = 0m;


            if (IsValidData()){
                weight = Convert.ToDecimal(txtWeight.Text.Trim());
                height = Convert.ToDecimal(txtHeight.Text.Trim());

                CalculateBMI(weight, height, ref BMI);
            }


        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = string.Empty;

            //Validate the hours worked text box
            errorMessage += IsPresent(txtWeight.Text, "Weight");
            errorMessage += IsInt32(txtWeight.Text, "Weight");
            errorMessage += IsWithinRange(txtWeight.Text, "Weight", MINWEIGHT, MAXWEIGHT);

            //Validate the Hourly Rate
            errorMessage += IsPresent(txtHeight.Text, "Height");
            errorMessage += IsInt32(txtHeight.Text, "Height");
            errorMessage += IsWithinRange(txtHeight.Text, "Height", MINHEIGHT, MAXHEIGHT);

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "Entry Error.");
            }

            return success;
        }
        private void CalculateBMI(decimal w, decimal h, ref decimal BMI)
        {
            BMI = ((w / (h * h)) * 703);

            if (BMI <= UNDERWEIGHT)
            {
                txtBMI.Text = ($"{BMI:n2}");
                txtCategory.Text = "Underweight";
            }
            else if (BMI <= OPTIMALWEIGHT)
            {
                txtBMI.Text = ($"{BMI:n2}");
                txtCategory.Text = "Optimal Weight";
            }
            else if (BMI <= OVERWEIGHT)
            {
                txtBMI.Text = ($"{BMI:n2}");
                txtCategory.Text = "Over Weight";
            }
            else
            {
                txtBMI.Text = ($"{BMI:n2}");
                txtCategory.Text = "Obese";
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
            if (Int32.TryParse(value, out Int32 number))
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
            txtBMI.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtWeight.Focus();
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
