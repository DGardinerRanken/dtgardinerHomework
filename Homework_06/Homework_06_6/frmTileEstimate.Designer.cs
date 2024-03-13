namespace Homework_06_6
{
    partial class frmTileEstimate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblRoom = new Label();
            lblWidth = new Label();
            lblLength = new Label();
            txtRoom = new TextBox();
            txtWidth = new TextBox();
            txtLength = new TextBox();
            txtResult = new TextBox();
            lblHeading = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(774, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 78);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(774, 377);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 78);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(774, 775);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(157, 78);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblRoom
            // 
            lblRoom.BackColor = Color.Snow;
            lblRoom.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblRoom.Location = new Point(61, 36);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(207, 51);
            lblRoom.TabIndex = 8;
            lblRoom.Text = "Room:";
            lblRoom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            lblWidth.BackColor = Color.Snow;
            lblWidth.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblWidth.Location = new Point(295, 36);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(207, 51);
            lblWidth.TabIndex = 9;
            lblWidth.Text = "Width:";
            lblWidth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLength
            // 
            lblLength.BackColor = Color.Snow;
            lblLength.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblLength.Location = new Point(530, 36);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(207, 51);
            lblLength.TabIndex = 10;
            lblLength.Text = "Length:";
            lblLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRoom
            // 
            txtRoom.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtRoom.Location = new Point(61, 101);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(207, 38);
            txtRoom.TabIndex = 0;
            txtRoom.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtWidth.Location = new Point(295, 101);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(207, 38);
            txtWidth.TabIndex = 1;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            txtLength.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtLength.Location = new Point(530, 101);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(207, 38);
            txtLength.TabIndex = 2;
            txtLength.TextAlign = HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.Snow;
            txtResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtResult.Location = new Point(61, 253);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(676, 600);
            txtResult.TabIndex = 7;
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.Snow;
            lblHeading.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHeading.Location = new Point(61, 159);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(676, 79);
            lblHeading.TabIndex = 6;
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmTileEstimate
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            CancelButton = btnClear;
            ClientSize = new Size(1002, 899);
            Controls.Add(lblHeading);
            Controls.Add(txtResult);
            Controls.Add(txtLength);
            Controls.Add(txtWidth);
            Controls.Add(txtRoom);
            Controls.Add(lblLength);
            Controls.Add(lblWidth);
            Controls.Add(lblRoom);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Name = "frmTileEstimate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapter 12 Homework - #6 Tile Estimate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
        private Label lblRoom;
        private Label lblWidth;
        private Label lblLength;
        private TextBox txtRoom;
        private TextBox txtWidth;
        private TextBox txtLength;
        private TextBox txtResult;
        private Label lblHeading;
    }
}
