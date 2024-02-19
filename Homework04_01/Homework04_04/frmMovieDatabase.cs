namespace Homework04_04
{
    public partial class frmMovieDatabase : Form
    {
        //Declare and Initialize program constants
        const string MNF = "MOVIE NOT FOUND";
        const string N = "Name:\t";
        const string DIR = "Director:\t";
        const string DESC = "Description:\t\t";

        string[] movieNames = { "Madame Web",
                               "Dune: Part Two",
                               "Deadpool & Wolverine",
                               "Ghostbusters: Frozen Empire",
                               "Godzilla x Kong: The New Empire",
                                "Kingdom of the Planet of the Apes",
                                "A Quiet Place: Day One",
                                "Moana 2",
                                "Joker: Folie à Deux",
                                "Mission: Impossible - Dead Reckoning Part Two"};

        string[] directors = {"S.J. Clarkson",
                               "Denis Villeneuve",
                               "Shawn Levy",
                               "Gil Kenan",
                               "Adam Wingard",
                                "Wes Ball",
                                "Michael Sarnoski",
                                "David G. Derrick Jr.",
                                "Todd Phillips",
                                "Christopher McQuarrie"};

        string[] descriptions = { "Cassandra Webb is a New York metropolis paramedic who begins to demonstrate signs of clairvoyance." +
                                   " Forced to challenge revelations about her past, she needs to safeguard three young women from a deadly adversary who wants them destroyed.",
                                "Paul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.",
                                "The irresponsible hero Deadpool will change the history of the MCU with Wolverine?",
                                "When the discovery of an ancient artifact unleashes an evil force, Ghostbusters new and old must join forces to protect their home and save the world from a second ice age.",
                                "Two ancient titans, Godzilla and Kong, clash in an epic battle as humans unravel their intertwined origins and connection to Skull Island's mysteries.",
                                "Many years after the reign of Caesar, a young ape goes on a journey that will lead him to question everything he's been taught about the" +
                                " past and make choices that will define a future for apes and humans alike.",
                                "Experience the day the world went quiet.",
                                "After receiving an unexpected call from her wayfinding ancestors, Moana journeys to the far seas of Oceania and into dangerous," +
                                " long-lost waters for an adventure unlike anything she has ever faced.",
                                "Sequel to the film 'Joker' from 2019.",
                                "The 8th entry in the long running Mission Impossible franchise."
                                 };
        
        public frmMovieDatabase()
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
            string term = txtSearchTerm.Text.Trim();
            bool isFound = false;
            int ind = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < movieNames.Length; lcv++)
            {
                //Search either or both arrays looking for a match
                if (movieNames[lcv].ToLower().Contains(term.ToLower())
                    || directors[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                }
            }

            //Match Found
            //I could not figure out how to make the description start at the same point as the names and directors,
            //I'm not too sure why it wont line up
            if (isFound)
            {
                outputStr += ($"{N} {movieNames[ind]}\r\t\r\n");
                outputStr += ($"{DIR} {directors[ind]}\r\n");
                outputStr += ($"{DESC} {descriptions[ind]}");
            }
            else
            {
                outputStr += ($"{N} {MNF}\t\r\n");
                outputStr += ($"{DIR} {MNF}\r\n");
                outputStr += ($"{DESC} {MNF}\r\n");
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
