using Microsoft.VisualBasic.ApplicationServices;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Homework04_01
{

    //Write a GUI application that calculates delivery charges to 10 different zip codes based on the following table. Hint: Use a string array.

    //If the zip is not found, the user should receive a not found message.

    //The associated delivery charge should disappear when a subsequent zip is found.
    //Zip Code Delivery Charge($)

    //63101 20

    //63103 12

    //63105 25

    //63109 15

    //63113 10

    //63118 23

    //63130 18

    //63133 20

    //63136 17

    //63137 12

    
    public partial class frmCalculateDelivery : Form
    {
        string [] zipCodes = {"63101", "63103", "63105", "63109", "63113", "63118", "63130",
                           "63133", "63136", "63137"};

        string [] prices = {"20", "12", "25", "15", "10", "23", "18", "20", "17", "12"};
        public frmCalculateDelivery()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateDeliveryPrice();
        }
        private void CalculateDeliveryPrice()
        {
            int zipCode = 0;

            try
            {
                zipCode = Convert.ToInt32(txtZipCode.Text.Trim());

                if (zipCode <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                DeterminePrice();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message + "\n\n" + "Zip Code must be an Integer",
                                "FORMATEXCEPTION");
                ClearAll();
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowErrorMessage("System Message:\t" + aoore.Message + "\n\n" + "Zip Code must be an Integer > 0",
                                "ARGUMENTOUTOFRANGEEXCEPTION");
                ClearAll();
                return;
            }
        }
        private void DeterminePrice()
        {
            string zipCode = "";
            string price = "";

            zipCode = txtZipCode.Text.Trim();
            
            if (zipCode == zipCodes[0])
            {
                price = prices[0];
            }
            else if (zipCode == zipCodes[1]) 
            {
                price = prices[1];
            }
            else if (zipCode == zipCodes[2])
            {
                price = prices[2];
            }
            else if (zipCode == zipCodes[3])
            {
                price = prices[3];
            }
            else if (zipCode == zipCodes[4])
            {
                price = prices[4];
            } 
            else if (zipCode == zipCodes[5])
            {
                price = prices[5];
            }
            else if (zipCode == zipCodes[6])
            {
                price = prices[6];
            } 
            else if (zipCode == zipCodes[7])
            {
                price = prices[7];
            }
            else if (zipCode == zipCodes[8])
            {
                price = prices[8];
            }
            else if (zipCode == zipCodes[9])
            {
                price = prices[9];
            }
            else
            {
                ShowErrorMessage("Zip Code Not Found.", "ZIP CODE NOT FOUND");
                txtZipCode.Focus();
            }

            txtDeliveryCharge.Text = ($"${price}");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtDeliveryCharge.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtZipCode.Focus();
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
