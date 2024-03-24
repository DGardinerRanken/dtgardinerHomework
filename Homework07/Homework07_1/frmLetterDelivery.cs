using LetterLibrary;
using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;

namespace Homework07_1
{
    //LB1 Letters
    //Create a GUI application for a letter delivery service.
    //●	Letters cost 50 cents to send.
    //●	Certified letters cost an additional 15 cents to send and include a tracking number.
    //●	The user can send up to 10 letters.
    //●	Every time a letter is sent it is added to the top of the transaction log.
    //●	Store the list of sent letters in a list or array.
    //●	If the letter does not include a tracking number, instantiate a Letter object.
    //●	If the letter includes a tracking number, instantiate a CertifiedLetter object.


    public partial class frmLetterDelivery : Form
    {
        //Declare and Initialize global constant
        const int TOTALELEMENTS = 10;

        //Declare and Initialize class variables
        List<Letter> letters = new List<Letter>(TOTALELEMENTS);
        List<CertifiedLetter> certifiedLetters = new List<CertifiedLetter>(TOTALELEMENTS);
        string[] sentLetters = new string[TOTALELEMENTS];
        int numElements = 0;
        public frmLetterDelivery()
        {
            InitializeComponent();
            lblAdditionalFee.Visible = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateRecipient();

            if (keepGoing)
            {
                keepGoing = ValidateSentDate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = IsThereATrackingNumber();
            }
            else
            {
                return;
            }

            //Is a Valid Letter and Certified
            if (keepGoing)
            {
                lblAdditionalFee.Visible = true;
                IntstantiateACertifiedLetter();
            }
            else //Is a Valid Letter and Not Certified
            {
                lblAdditionalFee.Visible = false;
                IntstantiateALetter();
            }
        }

        private void IntstantiateACertifiedLetter()
        {
            CertifiedLetter cl = new CertifiedLetter(
                                txtRecipient.Text,
                                Convert.ToDateTime(txtSentDate.Text),
                                txtTrackingNumber.Text);

            //Is there room in the array for another letter?
            if (numElements < TOTALELEMENTS)
            {
                certifiedLetters.Add(cl);
                txtResult.Text += cl.ToString() + "\r\n";
                ++numElements;
                ClearAll();
            }
            else
            {
                ShowErrorMessage("Can't Add More Elements", "ELEMENT ARRAY FULL");
            }
        }

        private void IntstantiateALetter()
        {
            Letter l = new Letter(
                                txtRecipient.Text,
                                Convert.ToDateTime(txtSentDate.Text));

            //Is there room in the array for another letter?
            if (numElements < TOTALELEMENTS)
            {
                letters.Add(l);
                txtResult.Text += l.ToString() + "\r\n";
                ++numElements;
                ClearAll();
            }
            else
            {
                ShowErrorMessage("Can't Add More Elements", "ELEMENT ARRAY FULL");
            }
        }

        public bool IsThereATrackingNumber()
        {
            bool retVal = true;

            if (txtTrackingNumber.Text.Trim() == "")
            {
                retVal = false;
            }

            return retVal;
        }

        public bool ValidateSentDate() 
        {
            try
            {
                DateTime.Parse(txtSentDate.Text.Trim());
                return true;
            } 
            catch (Exception ex)             
            {
                ShowErrorMessage(ex.Message + "\n\n" +
                                 ex.GetType().ToString() + "\n\n" +
                                 ex.StackTrace, "INVALID DATE INPUTTED");
                txtSentDate.Text = string.Empty;
                txtSentDate.Focus();
                return false;   
            }
        }

        public bool ValidateRecipient()
        {
            bool retVal = true;

            if (txtRecipient.Text.Trim() == "")
            {
                ShowErrorMessage("Recipient Name Must be Entered\n" + "Please Try Again", "NO RECIPIENT NAME ENTERED");
                txtRecipient.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtRecipient.Text = string.Empty;
            txtSentDate.Text = string.Empty;
            txtTrackingNumber.Text = string.Empty;
            txtRecipient.Focus();
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
