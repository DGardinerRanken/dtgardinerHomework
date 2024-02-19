namespace Homework04_06
{
    public partial class frmSortWords : Form
    {

        public frmSortWords()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortWords();
        }
        private void SortWords()
        {
            string Words = txtPhraseInput.Text.Trim();
            string[] subs = Words.Split(' ');

            Array.Sort(subs, 0, subs.Length);
            
            txtPhraseOutput.Text = ($"{subs}");

            //I tried thinking out the logic on this one and looking it up,
            //I cannot seem to get this to work
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtPhraseInput.Text = string.Empty;
            txtPhraseOutput.Text = string.Empty;
            txtPhraseInput.Focus();
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
