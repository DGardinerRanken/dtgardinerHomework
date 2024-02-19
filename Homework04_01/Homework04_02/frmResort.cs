namespace Homework04_02
{

    //Nights Stayed Nightly Rate

    //1-2 nights $200 per night

    //3-4 nights $180 per night

    //5-7 nights $160 per night

    //8 or more nights $145 per night
    public partial class frmResort : Form
    { 
        decimal[] nightCost = {200.0m, 180.0m, 160.0m, 145.00m};
        string[] numNights = {"One or Two", "Three or Four",
                              "Five to Seven", "Eight or More"};
        public frmResort()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DetermineNightsStayed();
        }
        private void DetermineNightsStayed()
        {
            int nights = 0;

            try
            {
                nights = Convert.ToInt32(txtNightsStayed.Text.Trim());

                if (nights <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                DetermineBill(nights);
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message + "\n\n" + "Nights must be an Integer",
                                "FORMATEXCEPTION");
                ClearAll();
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowErrorMessage("System Message:\t" + aoore.Message + "\n\n" + "Nights must be an Integer > 0",
                                "ARGUMENTOUTOFRANGEEXCEPTION");
                ClearAll();
                return;
            }
        }
        private void DetermineBill(int nights)
        {
            decimal nightlyCost = 0m;
            decimal totalCost   = 0m;
            string numNightsStr = "";

            switch(nights)
            {
                case 1:
                case 2:
                    nightlyCost = nightCost[0];
                    numNightsStr = numNights[0];
                    break;
                case 3:
                case 4:
                    nightlyCost = nightCost[1];
                    numNightsStr = numNights[1];
                    break;
                case 5:
                case 6:
                case 7:
                    nightlyCost = nightCost[2];
                    numNightsStr = numNights[2];
                    break;

                default:
                    nightlyCost = nightCost[3];
                    numNightsStr = numNights[3];
                    break;

            }

            totalCost = nightlyCost * nights;
            txtNightsString.Text = numNightsStr;
            txtTotalCost.Text = totalCost.ToString("c");
            txtNightlyCost.Text = ($"{nightlyCost}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtNightlyCost.Text = string.Empty;
            txtNightsStayed.Text = string.Empty;
            txtNightsString.Text = string.Empty;
            txtTotalCost.Text = string.Empty;
            txtNightsStayed.Focus();
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
