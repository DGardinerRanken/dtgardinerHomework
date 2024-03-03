namespace Homework05_03
{
    partial class frmStudentList
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
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSearchByFirst = new Button();
            btnSearchLast = new Button();
            lblResult = new Label();
            btnExit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Khaki;
            lblFirstName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblFirstName.Location = new Point(78, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(126, 35);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Khaki;
            lblLastName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblLastName.Location = new Point(371, 56);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(126, 35);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            txtFirstName.Location = new Point(78, 103);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(126, 32);
            txtFirstName.TabIndex = 2;
            txtFirstName.KeyDown += txtFirstName_KeyDown;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            txtLastName.Location = new Point(371, 103);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(126, 32);
            txtLastName.TabIndex = 3;
            txtLastName.KeyDown += txtLastName_KeyDown;
            // 
            // btnSearchByFirst
            // 
            btnSearchByFirst.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnSearchByFirst.Location = new Point(26, 153);
            btnSearchByFirst.Name = "btnSearchByFirst";
            btnSearchByFirst.Size = new Size(222, 40);
            btnSearchByFirst.TabIndex = 4;
            btnSearchByFirst.Text = "Search by First Name";
            btnSearchByFirst.UseVisualStyleBackColor = true;
            btnSearchByFirst.Click += btnSearchByFirst_Click;
            // 
            // btnSearchLast
            // 
            btnSearchLast.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnSearchLast.Location = new Point(319, 153);
            btnSearchLast.Name = "btnSearchLast";
            btnSearchLast.Size = new Size(234, 40);
            btnSearchLast.TabIndex = 5;
            btnSearchLast.Text = "Search by Last Name";
            btnSearchLast.UseVisualStyleBackColor = true;
            btnSearchLast.Click += btnSearchLast_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightYellow;
            lblResult.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblResult.Location = new Point(78, 211);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(419, 156);
            lblResult.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(288, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 35);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(207, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 35);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmStudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(578, 426);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(lblResult);
            Controls.Add(btnSearchLast);
            Controls.Add(btnSearchByFirst);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "frmStudentList";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSearchByFirst;
        private Button btnSearchLast;
        private Label lblResult;
        private Button btnExit;
        private Button btnClear;
    }
}
