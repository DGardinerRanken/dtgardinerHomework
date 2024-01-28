//6. You can randomly generate three numbers as follows:

//Random rand = new Random();
//int num1 = rand.Next(1, 4);
//int num2 = rand.Next(1, 11);
//int num3 = rand.Next(1, 101);
//Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);


namespace Homework02_06
{



    public partial class Form1 : Form
    {

        //Declare and Initialize Global Variables
        public static int computerChoice = 0;
        public static int playerChoice = 0;
        public static int computerScore = 0;
        public static int playerScore = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice = 1;

            //Generate a random number for computer choice

            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            if (computerChoice == 1)
            {
                txtComputerPicked.Text = "Rock";
            }

            else if (computerChoice == 2)
            {
                txtComputerPicked.Text = "Paper";
                computerScore++;
            }

            else if (computerChoice == 3)
            {
                txtComputerPicked.Text = "Scissors";
                playerScore++;
            }

            txtComputerScore.Text = ($"{computerScore}");
            txtPlayerScore.Text = ($"{playerScore}");

            if (computerScore >= 3)
            {
                txtWinner.Text = "Computer Wins!";

            }
            else if (playerScore >= 3)
            {
                txtWinner.Text = "Player Wins!";

            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice = 2;


            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            if (computerChoice == 1)
            {
                txtComputerPicked.Text = "Rock";
                playerScore++;
            }

            else if (computerChoice == 2)
            {
                txtComputerPicked.Text = "Paper";

            }

            else if (computerChoice == 3)
            {
                txtComputerPicked.Text = "Scissors";
                computerScore++;
            }

            txtComputerScore.Text = ($"{computerScore}");
            txtPlayerScore.Text = ($"{playerScore}");

            if (computerScore >= 3)
            {
                txtWinner.Text = "Computer Wins!";
            }
            else if (playerScore >= 3)
            {
                txtWinner.Text = "Player Wins!";
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice = 3;


            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            if (computerChoice == 1)
            {
                txtComputerPicked.Text = "Rock";
                computerScore++;
            }

            else if (computerChoice == 2)
            {
                txtComputerPicked.Text = "Paper";
                playerScore++;
            }

            else if (computerChoice == 3)
            {
                txtComputerPicked.Text = "Scissors";
            }

            txtComputerScore.Text = ($"{computerScore}");
            txtPlayerScore.Text = ($"{playerScore}");

            if (computerScore >= 3)
            {
                txtWinner.Text = "Computer Wins!";
            }
            else if (playerScore >= 3)
            {
                txtWinner.Text = "Player Wins!";
            }
        }



        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtComputerPicked.Text = string.Empty;
            txtComputerScore.Text = string.Empty;
            txtPlayerScore.Text = string.Empty;
            txtWinner.Text = string.Empty;
            playerChoice = 0;
            computerChoice = 0;
            computerScore = 0;
            playerScore = 0;
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
