namespace Homework02_06
{
    partial class Form1
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            txtComputerPicked = new TextBox();
            lblComputerPicked = new Label();
            lblPlayerScore = new Label();
            lblComputerScore = new Label();
            txtPlayerScore = new TextBox();
            txtComputerScore = new TextBox();
            txtWinner = new TextBox();
            btnRestart = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.BackColor = Color.Lavender;
            btnRock.Font = new Font("Arial", 24F, FontStyle.Bold);
            btnRock.Location = new Point(63, 61);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(196, 73);
            btnRock.TabIndex = 0;
            btnRock.Text = "&Rock";
            btnRock.UseVisualStyleBackColor = false;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.BackColor = Color.Lavender;
            btnPaper.Font = new Font("Arial", 24F, FontStyle.Bold);
            btnPaper.Location = new Point(301, 61);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(196, 73);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "&Paper";
            btnPaper.UseVisualStyleBackColor = false;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.BackColor = Color.Lavender;
            btnScissors.Font = new Font("Arial", 24F, FontStyle.Bold);
            btnScissors.Location = new Point(539, 61);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(196, 73);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "&Scissors";
            btnScissors.UseVisualStyleBackColor = false;
            btnScissors.Click += btnScissors_Click;
            // 
            // txtComputerPicked
            // 
            txtComputerPicked.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtComputerPicked.Location = new Point(428, 185);
            txtComputerPicked.Name = "txtComputerPicked";
            txtComputerPicked.ReadOnly = true;
            txtComputerPicked.Size = new Size(278, 35);
            txtComputerPicked.TabIndex = 6;
            txtComputerPicked.TextAlign = HorizontalAlignment.Center;
            // 
            // lblComputerPicked
            // 
            lblComputerPicked.BackColor = Color.LightSkyBlue;
            lblComputerPicked.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblComputerPicked.Location = new Point(140, 185);
            lblComputerPicked.Name = "lblComputerPicked";
            lblComputerPicked.Size = new Size(254, 37);
            lblComputerPicked.TabIndex = 5;
            lblComputerPicked.Text = "Computer picked:";
            lblComputerPicked.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.BackColor = Color.LightSkyBlue;
            lblPlayerScore.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblPlayerScore.Location = new Point(41, 276);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(170, 37);
            lblPlayerScore.TabIndex = 7;
            lblPlayerScore.Text = "Player Score:";
            lblPlayerScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblComputerScore
            // 
            lblComputerScore.BackColor = Color.LightSkyBlue;
            lblComputerScore.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblComputerScore.Location = new Point(377, 278);
            lblComputerScore.Name = "lblComputerScore";
            lblComputerScore.Size = new Size(215, 37);
            lblComputerScore.TabIndex = 9;
            lblComputerScore.Text = "Computer Score:";
            lblComputerScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPlayerScore
            // 
            txtPlayerScore.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtPlayerScore.Location = new Point(217, 279);
            txtPlayerScore.Name = "txtPlayerScore";
            txtPlayerScore.ReadOnly = true;
            txtPlayerScore.Size = new Size(136, 35);
            txtPlayerScore.TabIndex = 8;
            txtPlayerScore.TextAlign = HorizontalAlignment.Center;
            // 
            // txtComputerScore
            // 
            txtComputerScore.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtComputerScore.Location = new Point(599, 280);
            txtComputerScore.Name = "txtComputerScore";
            txtComputerScore.ReadOnly = true;
            txtComputerScore.Size = new Size(136, 35);
            txtComputerScore.TabIndex = 10;
            txtComputerScore.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWinner
            // 
            txtWinner.Font = new Font("Arial", 18F, FontStyle.Bold);
            txtWinner.Location = new Point(301, 362);
            txtWinner.Name = "txtWinner";
            txtWinner.ReadOnly = true;
            txtWinner.ShortcutsEnabled = false;
            txtWinner.Size = new Size(196, 35);
            txtWinner.TabIndex = 11;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Lavender;
            btnRestart.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(52, 362);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(131, 41);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Lavender;
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(604, 362);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 41);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnRestart);
            Controls.Add(txtWinner);
            Controls.Add(txtComputerScore);
            Controls.Add(txtPlayerScore);
            Controls.Add(lblComputerScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblComputerPicked);
            Controls.Add(txtComputerPicked);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private TextBox txtComputerPicked;
        private Label lblComputerPicked;
        private Label lblPlayerScore;
        private Label lblComputerScore;
        private TextBox txtPlayerScore;
        private TextBox txtComputerScore;
        private TextBox txtWinner;
        private Button btnRestart;
        private Button btnExit;
    }
}
