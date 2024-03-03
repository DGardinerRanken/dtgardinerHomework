namespace Homework05_03
{
    public partial class frmStudentList : Form
    {
        const string SNF = "Student not found";
        const string N = "Name:\t";
        const string CG = "Course Grade:\t";
        const string C = "Course:\t";
        const string GPA = "GPA:\t";


        string[] studentFirstNames = { "Daniel", "Shane", "John", "Edward", "Ricky" };
        string[] studentLastNames = { "Gardiner", "Haefner", "Doe", "Scissorhands", "Bobby" };
        string[] studentGPAs = { "3.7", "2.9", "3.4", "3.0", "4.0" };
        string[] studentCourse = { "AWD-1100", "ENG-1000", "AWD-1115", "AWD-1000", "ENG-1115" };
        string[] studentCourseGrades = { "96%", "84%", "90%", "100%", "86%" };

       
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void btnSearchByFirst_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInputFirst();
            if (keepGoing)
            {
                SearchFirstNames();
            }

        }
        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInputLast();
            if (keepGoing)
            {
                SearchLastNames();
            }
        }
        private void SearchLastNames()
        {
            string term = txtLastName.Text.Trim();
            bool isFound = false;
            int ind = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < studentLastNames.Length; lcv++)
            {
                //Searching array for a match
                if (studentLastNames[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                }
            }
            //Match was found

            if (isFound)
            {
                outputStr += ($"{N} {studentFirstNames[ind]} {studentLastNames[ind]}\r\t\r\n");
                outputStr += ($"{GPA} {studentGPAs[ind]}\r\n");
                outputStr += ($"{C} {studentCourse[ind]}\r\n");
                outputStr += ($"{CG} {studentCourseGrades[ind]}\r\n");
            }
            else
            {
                outputStr += ($"{SNF}\r\t\r\n");
                outputStr += ($"GPA: {SNF}\r\n");
                outputStr += ($"Course: {SNF}\r\n");
                outputStr += ($"Course Grade: {SNF}\r\n");
            }

            lblResult.Text = outputStr;
        }
        private bool CheckForNoInputFirst()
        {
            bool retVal = true;
            string term = txtFirstName.Text.Trim();

            if (term == "")
            {
                ShowErrorMessage("You Must Enter A Search Term", "SEARCH TERM LEFT EMPTY");

                ClearAll();
                retVal = false;
            }

            return retVal;
        }
        private bool CheckForNoInputLast()
        {
            bool retVal = true;
            string term = txtLastName.Text.Trim();

            if (term == "")
            {
                ShowErrorMessage("You Must Enter A Search Term", "SEARCH TERM LEFT EMPTY");

                ClearAll();
                retVal = false;
            }

            return retVal;
        }
        private void SearchFirstNames()
        {
            string term = txtFirstName.Text.Trim();
            bool isFound = false;
            int ind = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < studentFirstNames.Length; lcv++)
            {
                //Searching array for a match
                if (studentFirstNames[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                }
            }
            //Match was found

            if (isFound)
            {
                outputStr += ($"{N} {studentFirstNames[ind]} {studentLastNames[ind]}\r\t\r\n");
                outputStr += ($"{GPA} {studentGPAs[ind]}\r\n");
                outputStr += ($"{C} {studentCourse[ind]}\r\n");
                outputStr += ($"{CG} {studentCourseGrades[ind]}\r\n");
            }
            else
            {
                outputStr += ($"{SNF}\r\t\r\n");
                outputStr += ($"GPA: {SNF}\r\n");
                outputStr += ($"Course: {SNF}\r\n");
                outputStr += ($"Course Grade: {SNF}\r\n");
            }

            lblResult.Text = outputStr;
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByFirst.PerformClick();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchLast.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Focus();
            lblResult.Text = string.Empty;
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
