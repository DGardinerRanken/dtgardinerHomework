using System.Diagnostics;
using System.Windows.Forms;

namespace Homework03_03
{
    public partial class frmGradeCalculator : Form
    {

        //Declare and Initialize Program Constants
        const int MINSCORE = 0;
        const int MAXSCORE = 100;
        const string ER    = "EXCEPTION RAISED";

        public frmGradeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateTextBox(txtTest1);

            if (keepGoing)
            {
                keepGoing = ValidateTextBox(txtTest2);
            } else
            {
                return;
            }
            if (keepGoing)
            {
                keepGoing = ValidateTextBox(txtTest3);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateTotalPoints();
            }
        }
        private bool ValidateTextBox(Control control)
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

            isValid = IsTextBoxWithinRange(control);

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
                if(control.Text == "")
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
            catch(FormatException fe)
            {
                ShowErrorMessage(fe.Message + "\n\n" + fe.GetType().ToString() + "\n\n" + fe.StackTrace, ER);
            }
            return true;
        }

        private bool IsTextBoxWithinRange(Control control)
        {
            int score = Convert.ToInt32(control.Text);

            try
            {
                if (score < MINSCORE || score > MAXSCORE)
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
        private void CalculateTotalPoints()
        {
            int testGrade1 = Convert.ToInt32(txtTest1.Text.Trim());
            int testGrade2 = Convert.ToInt32(txtTest1.Text.Trim());
            int testGrade3 = Convert.ToInt32(txtTest1.Text.Trim());

            CalculateAverageAndGrade(testGrade1, testGrade2, testGrade3);
        }
        private void CalculateAverageAndGrade(int testGrade1, int testGrade2, int testGrade3)
        {
            decimal average = ((testGrade1 + testGrade2 + testGrade3) / 3.0m);
            string letterGrade = "";

            if (average >= 90m) 
            {
                letterGrade = "A";
            }
            else if (average >= 80m)
            {
                letterGrade = "B";
            }
            else if (average >= 70m)
            {
                letterGrade = "3";
            }
            else if (average >= 60m)
            {
                letterGrade = "D";
            }
            else if (average >= 0)
            {
                letterGrade = "F";
            }

            txtAvgGrade.Text = ($"{average:n2} = {letterGrade}");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtTest1.Text = string.Empty;
            txtTest2.Text = string.Empty;
            txtTest3.Text = string.Empty;
            txtAvgGrade.Text = string.Empty;
            txtTest1.Focus();
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
