using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework05_02
{
    public partial class frmJobDBResultPage : Form
    {
        //I tried but could not figure out for the life of me how to send a value from one form to another.
        public frmJobDBResultPage()
        {
            InitializeComponent();
            
        }
        public frmJobDBResultPage(string value)
        {
            InitializeComponent();
            lbResults.Items.Add(value);
        }
        private void frmJobDBResultPage_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{Value}");
        }
        public string Value { get; set; }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJobDB f1 = new frmJobDB();
            f1.ShowDialog();
            this.Close();
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
