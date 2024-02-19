namespace Homework04_05
{
    public partial class frmFortuneCookis : Form
    {
        string[] fortunes = { "Birthdays are like friends. The more you have the better.",
                               "Your smile is a treasure to all who know you.",
                                "You never hesitate to tackle the most difficult problems.",
                                "The most obvious solution is not always the best.",
                                "If you want the rainbow, you will have to tolerate the rain.",
                                "The early bird gets the worm, but the second mouse gets the cheese.",
                                "From listening comes wisdom and from speaking repentance",
                                "A smile is your personal welcome mat.",
                                "Courage is not the absence of fear; it is the conquest of it.",
                                "A ship in harbor is safe, but that’s not why ships are built.",
                                "The wise man is the one that makes you think that he is dumb",
                                "One that would have the fruit must climb the tree."
        };

        public frmFortuneCookis()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            PickFortunes();
        }
        private void PickFortunes()
        {
            Random random = new Random();
            int randomNumber1 = random.Next(0, fortunes.Length);
            int randomNumber2 = random.Next(0, fortunes.Length - 1);


            txtFortune.Text =  ($"{fortunes[randomNumber1]}\n\r" + $"\r\n{fortunes[randomNumber2]}");
            

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtFortune.Text = string.Empty;
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
