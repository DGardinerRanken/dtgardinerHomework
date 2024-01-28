//Write a GUI program that converts distances between miles and kilometers:
//●	Declares a named constant named KM_PER_MILE which holds the number of kilometers in a mile (1.6 km per mile).
//●	Prompts the user for a distance in miles or kilometers.
//●	The user can convert miles to kilometers.
//●	The user can convert kilometers to miles.
//●	The program displays the distance in both kilometers and miles. For example: "3.0 miles is 4.8 kilometers"

using System.Reflection.Metadata;

namespace Homework02_01
{

    public partial class DistanceConverter : Form
    {

        //Declare and initialize program constants
        const decimal KM_PER_MILE = 1.6m;
        const decimal MILES_PER_KM = 0.621m;
        const string  FCBN = "Field Must Be Numerical And Not Negative";
        const string  EII = "Error In Input";

        //Declare and initialize class variables
        decimal miles = 0m;
        decimal kilos = 0m;
        public DistanceConverter()
        {
            InitializeComponent();
        }

        private void btnConvertToKm_Click(object sender, EventArgs e)
        {
            bool result;
            string milesStr = txtDistanceInMiles.Text.Trim();

            //Check for no input
            if (milesStr == "")
            {
                return;
            }

            //Validate the input; make sure the input is numeric and positive

            result = decimal.TryParse(milesStr, out miles);
            if (!result || miles < 0) 
            {
                ShowErrorMessage(FCBN, EII);
                txtDistanceInMiles.Text = string.Empty;
                txtDistanceInMiles.Focus();
                return;
            }

            //Convert Miles to Kilometers

            kilos = miles * KM_PER_MILE;

            //Print Value
            lblResult.Text = ($"{miles:n2} miles = {kilos:n2} kilometers");
        }

        private void btnConvertToMiles_Click(object sender, EventArgs e)
        {
            bool result;
            string kilosStr = txtDistanceInKilos.Text.Trim();

            //Check for no input
            if (kilosStr == "")
            {
                return;
            }

            //Validate the input; make sure the input is numeric and positive

            result = decimal.TryParse(kilosStr, out kilos);
            if (!result || kilos < 0)
            {
                ShowErrorMessage(FCBN, EII);
                txtDistanceInKilos.Text = string.Empty;
                txtDistanceInKilos.Focus();
                return;
            }

            //Convert Miles to Kilometers

            miles = kilos * MILES_PER_KM;

            //Print Value
            lblResult.Text = ($"{kilos:n2} kilos = {miles:n2} miles");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtDistanceInKilos.Text = string.Empty;
            txtDistanceInMiles.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtDistanceInMiles.Focus();
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
