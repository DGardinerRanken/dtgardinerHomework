//2. Write a GUI program that adds up the number of eggs produced by some chickens:
//●	Prompts the user for a number of eggs laid by four chickens.
//●	Sum the eggs laid and display the total in dozens and eggs.  For example, a total of 127 eggs would be displayed as "10 dozen and 7 eggs"


namespace Homework02_02
{
    public partial class Form1 : Form
    {

        int Chicken1 = 0;
        int Chicken2 = 0;
        int Chicken3 = 0;
        int Chicken4 = 0;
        int ChickenTotal = 0;
        int FinalResult = 0;
        int Dozens = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            Chicken1 = Convert.ToInt32(txtChicken1.Text);
            Chicken2 = Convert.ToInt32(txtChicken2.Text);
            Chicken3 = Convert.ToInt32(txtChicken3.Text);
            Chicken4 = Convert.ToInt32(txtChicken4.Text);

            ChickenTotal = (Chicken1 + Chicken2 + Chicken3 + Chicken4);

            FinalResult = (ChickenTotal % 12);
            Dozens = (ChickenTotal / 12);

            lblDisplayResult.Text = ($"{ChickenTotal} eggs total, or {Dozens} Dozen and {FinalResult} eggs");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

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
