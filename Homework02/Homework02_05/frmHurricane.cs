using System;
using System.Windows.Forms;

//5. Write a GUI program that estimates the category of a hurricane based on the wind speed (based on the Saffir-Simpson Hurricane Scale):
//●	Category 5 hurricanes have sustained winds of at least 157 miles per hour.
//●	Category 4 hurricanes have sustained winds of at least 130 miles per hour.
//●	Category 3 hurricanes have sustained winds of at least 111 miles per hour.
//●	Category 2 hurricanes have sustained winds of at least 96 miles per hour.
//●	Category 1 hurricanes have sustained winds of at least 74 miles per hour.
//●	Any storm with winds of less than 74 miles per hour is not classified as a hurricane.


namespace Homework02_05
{
    public partial class frmHurricane : Form
    {

        //Declare and Initialize program constants

        const string NWSI   = "No Wind Speed Input";
        const string WSCBN  = "Wind Speed Cannot Be Negative";
        const string EII    = "Error In Input";
        const string CAT    = "Category ";
        const string NOHURR = "NOT A HURRICANE";
        const int CATEGORY1 = 74;
        const int CATEGORY2 = 96;
        const int CATEGORY3 = 111;
        const int CATEGORY4 = 130;
        const int CATEGORY5 = 157;

        //Declare and Initialize class variables

        int windSpeed = 0;
        string category = string.Empty;

        public frmHurricane()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            ValidateWindSpeed();
        }
        private void ValidateWindSpeed()
        {
            bool result;
            string wsStr = txtWindSpeed.Text.Trim();

            //Check for No Input
            if (wsStr == "") 
            {
                ShowErrorMessage(NWSI, EII);
                txtWindSpeed.Focus();
                return;
            }

            //Validate that wind speed input is both numeric and positive

            result = int.TryParse(wsStr, out windSpeed);

            if (!result || windSpeed < 0)
            {
                ShowErrorMessage(WSCBN, EII);             
                txtWindSpeed.Text = string.Empty;
                txtWindSpeed.Focus();
                return;
            }

            DetermineCategoryType();

        }
        private void DetermineCategoryType()
        {
            if (windSpeed >= CATEGORY5)
            {
                category = CAT + "5";
            }

            else if (windSpeed >= CATEGORY4)
            {
                category = CAT + "4";
            }

            else if (windSpeed >= CATEGORY3)
            {
                category = CAT + "3";
            }

            else if (windSpeed >= CATEGORY2)
            {
                category = CAT + "2";
            }

            else if (windSpeed >= CATEGORY1)
            {
                category = CAT + "1";
            }

            else
            {
                category = NOHURR;
            }

            txtCategory.Text = category;
        }


            
        
private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtCategory.Text = "";
            txtWindSpeed.Text = "";
            txtWindSpeed.Focus();
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
