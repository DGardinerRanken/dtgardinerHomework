//8. Implement #7 as a GUI program.

namespace Homework02_08
{
    public partial class SalesTracker : Form
    {

        //Declare and Initialize global variables

        static string salesInitialStr = "";
        static decimal dSales = 0m;
        static decimal eSales = 0m;
        static decimal fSales = 0m;
        static decimal dTotal = 0m;
        static decimal eTotal = 0m;
        static decimal fTotal = 0m;
        static decimal grandTotal = 0m;

        public SalesTracker()
        {
            InitializeComponent();
            DisplaySales();
        }

        private void btnDanielle_Click(object sender, EventArgs e)
        {
            dSales = Convert.ToDecimal(txtSaleAmount.Text);
            dTotal = dTotal + dSales;
            txtSaleAmount.Text = "";
            txtSaleAmount.Focus();
            DisplaySales();
        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            eSales = Convert.ToDecimal(txtSaleAmount.Text);
            eTotal = eTotal + eSales;
            txtSaleAmount.Text = "";
            txtSaleAmount.Focus();
            DisplaySales();
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            fSales = Convert.ToDecimal(txtSaleAmount.Text);
            fTotal = fTotal + fSales;
            txtSaleAmount.Text = "";
            txtSaleAmount.Focus();
            DisplaySales();
        }

        private void DisplaySales()
        {
            grandTotal = (fTotal + dTotal + eTotal);

            txtDanielleSales.Text = ($"${dTotal}");
            txtEdwardSales.Text = ($"${eTotal}");
            txtFrancisSales.Text = ($"${fTotal}");
            txtGrandTotal.Text = ($"${grandTotal}");

            if (dTotal > eTotal && dTotal > fTotal)
            {
                lblResult.Text = "Daneille has the most sales.";
            }
            else if (eTotal > dTotal && eTotal > fTotal)
            {
                lblResult.Text = "Edward has the most sales.";
            }
            else if (fTotal > dTotal && fTotal > eTotal)
            {
                lblResult.Text = "Francis has the most sales.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtDanielleSales.Text = string.Empty;
            txtEdwardSales.Text   = string.Empty;
            txtFrancisSales.Text  = string.Empty;
            txtGrandTotal.Text    = string.Empty;
            txtSaleAmount.Text    = string.Empty;
            lblResult.Text = string.Empty;
            fTotal = 0;
            dTotal = 0;
            eTotal = 0;
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
