using System;
using System.Windows.Forms;

//4. Write a GUI program that determines eligibility for college applicants:
//●	Prompt the user for the high-school GPA and admission test score.
//●	Display "Accept" if the student’s GPA is 3.0 or higher and their admission test score is 60 or greater.
//●	Display "Accept" if the student’s GPA is less than 3.0 and their admission test score is 80 or greater.
//●	Otherwise display "Reject"


namespace Homework02_04
{
    public partial class frmCollegeAdmission : Form
    {

        //Declare and initialize program constants

        const decimal MINGPA = 0m;
        const decimal MAXGPA = 4.0m;
        const int MINATS     = 0;
        const int MAXATS     = 100;
        const string MOII    = "MISSING OR INVALID INPUT";
        const string GPACBE = "GPA Cannot Be Empty";
        const string GPAOOR = "GPA Out Of Range";
        const string ATSCBE = "Admin Test Score Cannot Be Empty";
        const string ATSOOR = "Admin Test Score Out Of Range";

        //Declare and Initialize class variables

        decimal GPA = 0m;
        int     ATS = 0;

        public frmCollegeAdmission()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            ValidateGPAAndAdmissionTestScore();
        }

        private void ValidateGPAAndAdmissionTestScore()
        {
            string gpaStr = txtGPA.Text.Trim();
            string atsStr = txtAdmissionTestScore.Text.Trim();
            bool result;

            //Validate that GPA is not empty
            if (gpaStr == "")
            {
                ShowErrorMessage(GPACBE, MOII);
                txtGPA.Focus();
                return;
            }

            //Validate that GPA is numeric and between 0.0 and 4.0
            result = decimal.TryParse(gpaStr, out GPA);

            if (!result || GPA < MINGPA || GPA > MAXGPA) 
            {
                ShowErrorMessage(GPAOOR, MOII);
                txtGPA.Text = string.Empty;
                txtGPA.Focus();
                return;
            }

            //Validate that ATS is not empty
            if (atsStr == "")
            {
                ShowErrorMessage(ATSCBE, MOII);
                txtAdmissionTestScore.Focus();
                return;
            }

            //Validate that ATS is numeric and between 0.0 and 100.0
            result = int.TryParse(atsStr, out ATS);

            if (!result || ATS < MINATS || ATS > MAXATS)
            {
                ShowErrorMessage(ATSOOR, MOII);
                txtAdmissionTestScore.Text = string.Empty;
                txtAdmissionTestScore.Focus();
                return;
            }

            DetermineAcceptOrReject();
        }
        private void DetermineAcceptOrReject()
        {
            string aor = "";

            if (GPA >= 3.0m && ATS >= 60)
            {
                aor = "ACCEPT";
            } else if (GPA < 3.0m && ATS >= 80)
            {
                aor = "ACCEPT";
            } else
            {
                aor = "REJECT";
            }

            lblAcceptOrReject.Text = aor;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdmissionTestScore.Text = string.Empty;
            txtGPA.Text = string.Empty;
            lblAcceptOrReject.Text = string.Empty;
            txtGPA.Focus();
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
