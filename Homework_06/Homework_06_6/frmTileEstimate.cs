namespace Homework_06_6
{
    public partial class frmTileEstimate : Form
    {
        //Declare and Initialize Program Constant
        const int MAXROOMS = 10;

        //Declare class variables
        string[] roomNames = new string[MAXROOMS];
        int[]roomWidths = new int[MAXROOMS];
        int[]roomLengths = new int[MAXROOMS];
        int[]roomAreas = new int[MAXROOMS];
        int[]roomBoxes = new int[MAXROOMS];

        string outputStr = string.Empty;
        string headingStr = string.Empty;
        int totalRooms = 0;
        int totalBoxesNeeded = 0;
        int finalNumBoxes = 0;
        //Room? room;

        public frmTileEstimate()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                ++totalRooms;

                //Check if room array is full (10 Rooms)
                if (totalRooms > MAXROOMS)
                {
                    ShowErrorMessage("No More Room In Array!", "MAX ROOMS HAVE BEEN INPUTTED");
                    return;
                }

                //Array is not full
                //Calculate values for the current room name, width, & length

                roomNames[totalRooms - 1] = txtRoom.Text.Trim();
                roomWidths[totalRooms - 1] = int.Parse(txtWidth.Text.Trim());
                roomLengths[totalRooms - 1] = int.Parse(txtLength.Text.Trim());

                //Calculate the area
                CalculateRoomArea();

                //Calculate total num of boxes required
                CalculateTotalBoxesNeeded();

                //Instantiate a room object
                Room room = new Room(roomNames[totalRooms - 1],
                                    roomWidths[totalRooms - 1],
                                    roomLengths[totalRooms - 1],
                                    roomAreas[totalRooms - 1],
                                    roomBoxes[totalRooms - 1]);

                DisplayOutPut(room);
            }
        }
        
        private void CalculateRoomArea()
        {
            roomAreas[totalRooms - 1] = roomWidths[totalRooms - 1] * roomLengths[totalRooms - 1];
        }

        private void CalculateTotalBoxesNeeded()
        {
            int temp = (roomAreas[totalRooms - 1] / 12);
            totalBoxesNeeded = temp + 2;
            finalNumBoxes += totalBoxesNeeded;
        }

        private bool IsValidData() 
        {
            string room = txtRoom.Text.Trim();
            string width = txtWidth.Text.Trim();
            string length = txtLength.Text.Trim();
            bool success = true;
            string errorMessage = string.Empty;

            //Validate the Room TxtBox
            errorMessage += Validator.IsPresent(room, "Room");

            //Validate the Width TxtBox
            errorMessage += Validator.IsPresent(width, "Width");
            errorMessage += Validator.IsInt32(width, "Width");
            errorMessage += Validator.IsWithinRange(width, "Width", 1, 1000);
            //Validate the Length TxtBox
            errorMessage += Validator.IsPresent(length, "Length");
            errorMessage += Validator.IsInt32(length, "Length");
            errorMessage += Validator.IsWithinRange(length, "Length", 1, 1000);

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "ENTRY ERROR");
            }

            return success;
        }

        private void DisplayOutPut(Room r)
        {
            
            lblHeading.Text = string.Empty;
            headingStr = string.Empty;
            headingStr += "Total Number of Rooms:\t" + totalRooms.ToString();
            headingStr += "\r\nTotal Boxes of Tile Needed:\t" + totalBoxesNeeded.ToString();
            lblHeading.Text = headingStr;
            

            outputStr += r.GetName() + " (" + 
                        r.GetWidth().ToString() + " * " + 
                        r.GetLength().ToString() + ") needs " +
                        finalNumBoxes.ToString() + " boxes.\r\n";
            txtResult.Text = outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty;
            txtRoom.Text = string.Empty;
            txtRoom.Focus();
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
