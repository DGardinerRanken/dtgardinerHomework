using Microsoft.VisualBasic.ApplicationServices;
using System.Numerics;

namespace Homework04_03
{
    //Create a searchable database for a video game store:

    //Player Unknown's Battlegrounds (PUBG) Bluehole $35

    //League of Legends Riot Games $0

    //Call of Duty: Black Ops III Activision $60

    //Battlefield 4 Electronic Arts(EA) $20

    //Super Mario Odyssey Nintendo $60
    public partial class frmGameDatabase : Form
    {

        //Declare and Initialize program constants
        const string GNF = "GAME NOT FOUND";
        const string N = "NAME:\t";
        const string PUB = "PUBLISHER:\t";
        const string PR = "PRICE:\t\t";

        string[] gameNames = { "Player Unknown's BattleGrounds", 
                               "League of Legends",
                               "Call of Duty: Black Ops III",
                               "Battlefield 4",
                               "Super Mario Odyssey"}; 
        
        string[] publishers = {"Bluehole",
                               "Riot Games",
                               "Activision",
                               "Electronic Arts(EA)",
                               "Nintendo"};

        decimal[] prices =     {35m,
                               0m,
                               60m,
                               20m,
                               60m};
        public frmGameDatabase()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInput();
            if (keepGoing)
            {
                PerformTheSearch();
            }
        }
        private bool CheckForNoInput()
        {
            bool retVal = true;
            string term = txtSearchTerm.Text.Trim();

            if (term == "")
            {
                ShowErrorMessage("You Must Enter A Search Term", "SEARCH TERM LEFT EMPTY");

                ClearAll();
                retVal = false;
            }

            return retVal;
        }
        private void PerformTheSearch()
        {
            string term      = txtSearchTerm.Text.Trim();
            bool isFound     = false;
            int ind  = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < gameNames.Length; lcv++)
            {
                //Search either or both arrays looking for a match
                if (gameNames[lcv].ToLower().Contains(term.ToLower())
                    || publishers[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                }
            }

            //Match Found
            if (isFound)
            {
                outputStr += ($"{N} {gameNames[ind]}\r\t\r\n");
                outputStr += ($"{PUB} {publishers[ind]}\r\n");
                outputStr += ($"{PR} {prices[ind]}\r\n");
            }
            else
            {
                outputStr += ($"{N} {GNF}\t\r\n");
                outputStr += ($"{PUB} {GNF}\r\n");
                outputStr += ($"{PR} {GNF}\r\n");
            }

            txtResult.Text = outputStr;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtSearchTerm.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtSearchTerm.Focus();
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
