namespace Homework04_02
{
    partial class frmResort
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
            lblNightsStayed = new Label();
            lblNightsString = new Label();
            lblNightlyCost = new Label();
            lblTotalCost = new Label();
            txtNightsStayed = new TextBox();
            txtNightsString = new TextBox();
            txtNightlyCost = new TextBox();
            txtTotalCost = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblNightsStayed
            // 
            lblNightsStayed.BackColor = Color.LightSkyBlue;
            lblNightsStayed.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblNightsStayed.Location = new Point(46, 46);
            lblNightsStayed.Name = "lblNightsStayed";
            lblNightsStayed.Size = new Size(169, 49);
            lblNightsStayed.TabIndex = 7;
            lblNightsStayed.Text = "Nights Stayed:";
            lblNightsStayed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNightsString
            // 
            lblNightsString.BackColor = Color.LightSkyBlue;
            lblNightsString.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblNightsString.Location = new Point(261, 46);
            lblNightsString.Name = "lblNightsString";
            lblNightsString.Size = new Size(169, 49);
            lblNightsString.TabIndex = 8;
            lblNightsString.Text = "Nights String:";
            lblNightsString.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNightlyCost
            // 
            lblNightlyCost.BackColor = Color.LightSkyBlue;
            lblNightlyCost.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblNightlyCost.Location = new Point(480, 46);
            lblNightlyCost.Name = "lblNightlyCost";
            lblNightlyCost.Size = new Size(169, 49);
            lblNightlyCost.TabIndex = 9;
            lblNightlyCost.Text = "Nightly Cost:";
            lblNightlyCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BackColor = Color.LightSkyBlue;
            lblTotalCost.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblTotalCost.Location = new Point(692, 46);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(169, 49);
            lblTotalCost.TabIndex = 10;
            lblTotalCost.Text = "Total Cost:";
            lblTotalCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNightsStayed
            // 
            txtNightsStayed.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtNightsStayed.Location = new Point(46, 120);
            txtNightsStayed.Name = "txtNightsStayed";
            txtNightsStayed.Size = new Size(169, 35);
            txtNightsStayed.TabIndex = 0;
            txtNightsStayed.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNightsString
            // 
            txtNightsString.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtNightsString.Location = new Point(261, 120);
            txtNightsString.Name = "txtNightsString";
            txtNightsString.ReadOnly = true;
            txtNightsString.Size = new Size(169, 35);
            txtNightsString.TabIndex = 4;
            txtNightsString.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNightlyCost
            // 
            txtNightlyCost.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtNightlyCost.Location = new Point(480, 120);
            txtNightlyCost.Name = "txtNightlyCost";
            txtNightlyCost.ReadOnly = true;
            txtNightlyCost.Size = new Size(169, 35);
            txtNightlyCost.TabIndex = 5;
            txtNightlyCost.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtTotalCost.Location = new Point(692, 120);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(169, 35);
            txtTotalCost.TabIndex = 6;
            txtTotalCost.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.PowderBlue;
            btnCalculate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnCalculate.Location = new Point(138, 217);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(174, 71);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PowderBlue;
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(359, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(174, 71);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PowderBlue;
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(579, 217);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(174, 71);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmResort
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            CancelButton = btnClear;
            ClientSize = new Size(917, 351);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotalCost);
            Controls.Add(txtNightlyCost);
            Controls.Add(txtNightsString);
            Controls.Add(txtNightsStayed);
            Controls.Add(lblTotalCost);
            Controls.Add(lblNightlyCost);
            Controls.Add(lblNightsString);
            Controls.Add(lblNightsStayed);
            Name = "frmResort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homework Chapter 8 - Resort #2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNightsStayed;
        private Label lblNightsString;
        private Label lblNightlyCost;
        private Label lblTotalCost;
        private TextBox txtNightsStayed;
        private TextBox txtNightsString;
        private TextBox txtNightlyCost;
        private TextBox txtTotalCost;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
