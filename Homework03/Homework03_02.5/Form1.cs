namespace Homework03_02._5
{
    public partial class frmBMIExceptions : Form
    {
        //Declare program constants
        const decimal UNDERWEIGHT = 18.49m;
        const decimal OPTIMALWEIGHT = 24.99m;
        const decimal OVERWEIGHT = 29.99m;
        const decimal OBESE = 30m;
        const decimal MINHEIGHT = 12m;
        const decimal MAXHEIGHT = 96m;
        const decimal MINWEIGHT = 1m;
        const decimal MAXWEIGHT = 777m;
        const string ER = "Exception Raised";
        public frmBMIExceptions()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

            bool keepGoing = ValidateWeight(txtWeight);

            if (keepGoing)
            {
                keepGoing = ValidateHeight(txtHeight);
            } else
            {
                return;
            }
            if (keepGoing) 
            {
                CalculateBMI();
            }


        }
        private bool ValidateWeight(Control control)
        {
            bool isValid = IsTextBoxNotEmptyWeight(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxNotNumericWeight(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxWithinRangeWeight(control);

            if (!isValid)
            {
                return false;
            }
            return true;
        }
        private bool ValidateHeight(Control control)
        {
            bool isValid = IsTextBoxNotEmptyHeight(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxNotNumericHeight(control);

            if (!isValid)
            {
                return false;
            }

            isValid = IsTextBoxWithinRangeHeight(control);

            if (!isValid)
            {
                return false;
            }
            return true;
        }
        private void CalculateBMI()
        {
            decimal weight = 0m;
            decimal height = 0m;
            decimal BMI = 0m;

            weight = Convert.ToDecimal(txtWeight.Text.Trim());
            height = Convert.ToDecimal(txtHeight.Text.Trim());

            BMI = ((weight / (height * height)) * 703);

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
        private bool IsTextBoxNotEmptyWeight(Control control)
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
                ShowErrorMessage(ane.Message + "\n\n" + ane.GetType().ToString() + "\n\n" + ane.StackTrace, ER);
            }
            return true;
        }
        private bool IsTextBoxNotNumericWeight(Control control)
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
                ShowErrorMessage(fe.Message + "\n\n" + fe.GetType().ToString() + "\n\n" + fe.StackTrace, ER);
            }
            return true;
        }
        private bool IsTextBoxWithinRangeWeight(Control control)
        {
            int score = Convert.ToInt32(control.Text);

            try
            {
                if (score < MINWEIGHT || score > MAXWEIGHT)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }

            catch (ArgumentOutOfRangeException aaae)
            {
                ShowErrorMessage(aaae.Message + "\n\n" + aaae.GetType().ToString() + "\n\n" + aaae.StackTrace, ER);
            }
            return true;
        }
        private bool IsTextBoxNotEmptyHeight(Control control)
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
                ShowErrorMessage(ane.Message + "\n\n" + ane.GetType().ToString() + "\n\n" + ane.StackTrace, ER);
            }
            return true;
        }
        private bool IsTextBoxNotNumericHeight(Control control)
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
                ShowErrorMessage(fe.Message + "\n\n" + fe.GetType().ToString() + "\n\n" + fe.StackTrace, ER);
            }
            return true;
        }
        private bool IsTextBoxWithinRangeHeight(Control control)
        {
            int score = Convert.ToInt32(control.Text);

            try
            {
                if (score < MINHEIGHT || score > MAXHEIGHT)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }

            catch (ArgumentOutOfRangeException aaae)
            {
                ShowErrorMessage(aaae.Message + "\n\n" + aaae.GetType().ToString() + "\n\n" + aaae.StackTrace, ER);
            }
            return true;
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
