using System;
using System.Windows.Forms;

namespace Photos
{
    public partial class frmPhotos : Form
    {
        //Declare and Initialize global constants
        const decimal EIGHTXTEN = 3.99m;
        const decimal TENXTWELVE = 5.99m;
        const decimal OTHERSIZES = 9.99m;
        const decimal UNFRAMED = 0.00m;
        const decimal FRAMED = 25.00m;
        const decimal MATTED = 10.00m;

        //Declare and Initialize class variables
        decimal width = 0.0m;
        decimal height = 0.0m;
        decimal totalCost = 0.00m;
        RadioButton radioButtonFrame;
        RadioButton radioButtonColor;
        RadioButton radioButtonMaterial;
        RadioButton radioButtonStyle;
        string frameStr = string.Empty;
        string colorStr = string.Empty;
        string styleStr = string.Empty;
        string materialStr = string.Empty;
        public frmPhotos()
        {
            InitializeComponent();
            
            //  https://social.msdn.microsoft.com/Forums/windows/en-US/c0c36595-9d98-40f7-8e6a-176a5a3af929/how-to-detect-which-radio-button-is-checked-inside-a-groupbox-control?forum=winforms
            //  Set up framed groupBox radioButtons
            radUnframed.CheckedChanged += new EventHandler(gbFramed_Check_Changed);
            radMatted.CheckedChanged += new EventHandler(gbFramed_Check_Changed);
            radFramed.CheckedChanged += new EventHandler(gbFramed_Check_Changed);

            //  Set up color groupBox radioButtons
            radBlack.CheckedChanged += new EventHandler(gbColor_Check_Changed);
            radRed.CheckedChanged += new EventHandler(gbColor_Check_Changed);
            radGreen.CheckedChanged += new EventHandler(gbColor_Check_Changed);
            radBlue.CheckedChanged += new EventHandler(gbColor_Check_Changed);
            radWhite.CheckedChanged += new EventHandler(gbColor_Check_Changed);

            //  Set up material groupBox radioButtons
            radPine.CheckedChanged += new EventHandler(gbMaterial_Check_Changed);
            radOak.CheckedChanged += new EventHandler(gbMaterial_Check_Changed);
            radSteel.CheckedChanged += new EventHandler(gbMaterial_Check_Changed);
            radSilver.CheckedChanged += new EventHandler(gbMaterial_Check_Changed);
            radGold.CheckedChanged += new EventHandler(gbMaterial_Check_Changed);

            //  Set up style groupBox radioButtons
            radSimple.CheckedChanged += new EventHandler(gbStyle_Check_Changed);
            radModern.CheckedChanged += new EventHandler(gbStyle_Check_Changed);
            radAntique.CheckedChanged += new EventHandler(gbStyle_Check_Changed);
            radVintage.CheckedChanged += new EventHandler(gbStyle_Check_Changed);
            radEclectic.CheckedChanged += new EventHandler(gbStyle_Check_Changed);
        }

        private void gbFramed_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonFrame =  (RadioButton)sender;

                frameStr = radioButtonFrame.Name.Substring(11);

                switch(frameStr)
                {
                    case "Unframed":
                        gbColor.Enabled = false;
                        gbMaterial.Enabled = false;
                        gbStyle.Enabled = false;
                        break;

                    case "Matted":
                        gbColor.Enabled = true;
                        radBlack.Checked = true;
                        gbMaterial.Enabled = false;
                        gbStyle.Enabled = false;
                        break;

                    case "Framed":
                        gbColor.Enabled = false;
                        gbMaterial.Enabled = true;
                        radPine.Checked = true;
                        gbStyle.Enabled = true;
                        radSilver.Checked = true;
                        break;
                }
            }
        }

        private void gbColor_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonColor = (RadioButton)sender;

                colorStr = radioButtonColor.Name.Substring(11);
            }
        }

        private void gbMaterial_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonMaterial = (RadioButton)sender;

                materialStr = radioButtonMaterial.Name.Substring(11);
            }

        }

        private void gbStyle_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonStyle = (RadioButton)sender;

                styleStr = radioButtonStyle.Name.Substring(11);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void brnClear_Click(object sender, EventArgs e)
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

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

    }
}
