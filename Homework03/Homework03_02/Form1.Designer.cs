namespace Homework03_02
{
    partial class frmBMIValidation
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
            txtWeight = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtBMI = new TextBox();
            txtCategory = new TextBox();
            lblWeight = new Label();
            lblHeight = new Label();
            lblBMI = new Label();
            lblCategory = new Label();
            txtHeight = new TextBox();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtWeight.Location = new Point(321, 75);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(176, 35);
            txtWeight.TabIndex = 0;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Honeydew;
            btnCalculate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnCalculate.Location = new Point(62, 351);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(116, 56);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Honeydew;
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(241, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 56);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Honeydew;
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(416, 351);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 56);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtBMI
            // 
            txtBMI.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtBMI.Location = new Point(301, 237);
            txtBMI.Name = "txtBMI";
            txtBMI.ReadOnly = true;
            txtBMI.Size = new Size(176, 35);
            txtBMI.TabIndex = 5;
            txtBMI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtCategory.Location = new Point(301, 288);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(176, 35);
            txtCategory.TabIndex = 6;
            txtCategory.TextAlign = HorizontalAlignment.Center;
            // 
            // lblWeight
            // 
            lblWeight.BackColor = Color.LightGreen;
            lblWeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblWeight.Location = new Point(146, 75);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(157, 35);
            lblWeight.TabIndex = 7;
            lblWeight.Text = "Weight (lb):";
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            lblHeight.BackColor = Color.LightGreen;
            lblHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHeight.Location = new Point(146, 129);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(157, 35);
            lblHeight.TabIndex = 8;
            lblHeight.Text = "Height (in):";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            lblBMI.BackColor = Color.LightGreen;
            lblBMI.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblBMI.Location = new Point(146, 237);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(131, 35);
            lblBMI.TabIndex = 9;
            lblBMI.Text = "BMI:";
            lblBMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.LightGreen;
            lblCategory.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblCategory.Location = new Point(146, 288);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(131, 35);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtHeight.Location = new Point(321, 129);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(176, 35);
            txtHeight.TabIndex = 1;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // frmBMIValidation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(619, 450);
            Controls.Add(txtHeight);
            Controls.Add(lblCategory);
            Controls.Add(lblBMI);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(txtCategory);
            Controls.Add(txtBMI);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtWeight);
            Name = "frmBMIValidation";
            Text = "Homework 3 - BMI Validation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeight;
        private Label lblBMI;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblCategory;
        private Label label4;
        private TextBox txtBMI;
        private TextBox txtCategory;
        private Label lblHeight;
    }
}
