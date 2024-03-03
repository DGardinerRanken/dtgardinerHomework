namespace Homework05_04
{
    public partial class frmCalculateReservations : Form
    {
        public frmCalculateReservations()
        {
            InitializeComponent();
        }

        private void frmCalculateReservations_Load(object sender, EventArgs e)
        {
            dtpDeparture.Value = dtpArrival.Value.AddDays(3);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateReservation();
        }
        private void CalculateReservation()
        {
            DateTime startDate = dtpArrival.Value;
            DateTime endDate = dtpDeparture.Value;

            int day = (endDate.Day - startDate.Day);
            txtNumOfNights.Text = day.ToString();

            int totalPrice = day * 120;
            txtTotalPrice.Text = "$" + totalPrice.ToString();

            int avgPrice = totalPrice / day;
            txtAvgPrice.Text = "$" + avgPrice.ToString();
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
