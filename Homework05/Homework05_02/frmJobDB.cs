namespace Homework05_02
{

    /*
        Create a GUI application to search for job openings.
    1.	Program must contain at least 5 industries.
    2.	Program must contain information about at least 5 jobs.
    3.	ListBox must be populated programmatically.
    4.	ListBox must allow multiple industries to be selected.
    5.	Clicking the search button will show the search results in a new window.
    6.	Search results must be populated programmatically.
    7.	Create a Job class that contains all of the information about a single job.
    8.	Create a Industry class that contains the name of the industry and an array of jobs.
    */
    public partial class frmJobDB : Form
    {
        int selection;
        string[] Industries = {"Information Technology", "Mechanical Engineering",
                               "Chemical Engineering", "HVAC", "Automotive"};

        string[] InformationTechonolgy = {"Tech Support - Level 1", "Quality Engineer - Level 1", "Software Architect"};
        string[] MechanicalEngineering = {"Mechanical Engineer - Entry Level", "Structural Engineer" };
        string[] ChemicalEngineering = {"Manufacturing Process Engineer", "Quality Control Specialist"};
        string[] HVAC = {"HVAC Service Installer", "HVAC Maintenance Specialist" };
        string[] Automotive = {"Dealership Technician", "Performance Shop Specialist"};
        public frmJobDB(string value)
        {
            InitializeComponent();
        }
        public frmJobDB()
        {
            InitializeComponent();
        }
        private void frmJobDB_Load(object sender, EventArgs e)
        {
            for (int lcv = 0; lcv < Industries.Length; lcv++)
            {
                lbIndustries.Items.Add(Industries[lcv]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i = lbIndustries.SelectedIndex;

            this.Hide();
            frmJobDBResultPage f2 = new frmJobDBResultPage(i.ToString());
            f2.ShowDialog();
            this.Close();

            
        }
        private void FindDatabaseResults()
        {
            int selection = lbIndustries.SelectedIndex;

            if (lbIndustries.SelectedIndex == -1)
            {
                ShowMessage("Please Select a Job Industry", "NO INDUSTRY SELECTED");
            }

            switch (selection)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    FillResult(selection);
                    break;
                default: break;
            }
        }
        private void FillResult(int selection)
        {
            if (selection == 0)
            {
                
            }
        }
        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
