using System.Drawing.Imaging;

//3. Write a GUI program to calculate projected raises (Done earlier Console app):
//●	Declares a named constant PERCENT_RAISE and assign it a value of 4% (or 1.04)
//●	Prompts the user for the names and salaries of three employees.
//●	Displays the projected salaries for these three employees over the next 2 years in a table, assuming that they get a 4% raise every year.


namespace Homework02_03
{
    public partial class frmPayrollProjections : Form
    {

        //Declare and intitialize program constants

        const decimal PERCENT_RAISE = 1.04m;

        //Declare and initialize class variables

        decimal Emp1Salary = 0m;
        decimal Emp2Salary = 0m;
        decimal Emp3Salary = 0m;
        decimal Emp1Salary2 = 0m;
        decimal Emp2Salary2 = 0m;
        decimal Emp3Salary2 = 0m;
        decimal Emp1Salary3 = 0m;
        decimal Emp2Salary3 = 0m;
        decimal Emp3Salary3 = 0m;
        string Emp1Name = string.Empty;
        string Emp2Name = string.Empty;
        string Emp3Name = string.Empty;

        public frmPayrollProjections()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Emp1Name = txtEmp1Name.Text;
            Emp2Name = txtEmp2Name.Text;
            Emp3Name = txtEmp3Name.Text;

            //Convert textbox strings to decimal

            Emp1Salary = Convert.ToDecimal(txtEmp1Salary.Text);
            Emp2Salary = Convert.ToDecimal(txtEmp2Salary.Text);
            Emp3Salary = Convert.ToDecimal(txtEmp3Salary.Text);

            //Calculate the Next 2 Years:

            Emp1Salary2 = (Emp1Salary * PERCENT_RAISE);
            Emp2Salary2 = (Emp2Salary * PERCENT_RAISE);
            Emp3Salary2 = (Emp3Salary * PERCENT_RAISE);

            Emp1Salary3 = (Emp1Salary2 * PERCENT_RAISE);
            Emp2Salary3 = (Emp2Salary2 * PERCENT_RAISE);
            Emp3Salary3 = (Emp3Salary2 * PERCENT_RAISE);

            DisplayNumbers();
        }

        private void DisplayNumbers()
        {
            lblDisplayEmp1Name.Text = Emp1Name;
            lblDisplayEmp2Name.Text = Emp2Name;
            lblDisplayEmp3Name.Text = Emp3Name;

            lblEmp1Year1.Text = ($"${Emp1Salary}");
            lblEmp2Year1.Text = ($"${Emp2Salary}");
            lblEmp3Year1.Text = ($"${Emp3Salary}");

            lblEmp1Year2.Text = ($"${Emp1Salary2}");
            lblEmp2Year2.Text = ($"${Emp2Salary2}");
            lblEmp3Year2.Text = ($"${Emp3Salary2}");

            lblEmp1Year3.Text = ($"${Emp1Salary3}");
            lblEmp2Year3.Text = ($"${Emp2Salary3}");
            lblEmp3Year3.Text = ($"${Emp3Salary3}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtEmp1Name.Text = string.Empty;
            txtEmp2Name.Text = string.Empty;
            txtEmp3Name.Text = string.Empty;
            lblDisplay.Text = string.Empty;
            lblDisplayEmp1Name.Text = string.Empty;
            lblDisplayEmp2Name.Text = string.Empty;
            lblDisplayEmp3Name.Text = string.Empty;
            lblEmp1Year1.Text = string.Empty;
            lblEmp1Year2.Text = string.Empty;
            lblEmp1Year3.Text = string.Empty;
            lblEmp2Year1.Text = string.Empty;
            lblEmp2Year2.Text = string.Empty;
            lblEmp2Year3.Text = string.Empty;
            lblEmp3Year1.Text = string.Empty;
            lblEmp3Year2.Text = string.Empty;
            lblEmp3Year3.Text = string.Empty;
            txtEmp1Salary.Text = string.Empty;
            txtEmp2Salary.Text = string.Empty;
            txtEmp3Salary.Text = string.Empty;
            txtEmp1Name.Focus();

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


    }
}
