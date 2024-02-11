namespace Homework03_02._5
{
    partial class frmBMIExceptions
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
            txtHeight = new TextBox();
            lblCategory = new Label();
            lblBMI = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            txtCategory = new TextBox();
            txtBMI = new TextBox();
            btnExit = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            txtWeight = new TextBox();
            SuspendLayout();
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtHeight.Location = new Point(297, 108);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(176, 35);
            txtHeight.TabIndex = 12;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.LightSteelBlue;
            lblCategory.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblCategory.Location = new Point(122, 267);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(131, 35);
            lblCategory.TabIndex = 21;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            lblBMI.BackColor = Color.LightSteelBlue;
            lblBMI.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblBMI.Location = new Point(122, 216);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(131, 35);
            lblBMI.TabIndex = 20;
            lblBMI.Text = "BMI:";
            lblBMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            lblHeight.BackColor = Color.LightSteelBlue;
            lblHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHeight.Location = new Point(122, 108);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(157, 35);
            lblHeight.TabIndex = 19;
            lblHeight.Text = "Height (in):";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            lblWeight.BackColor = Color.LightSteelBlue;
            lblWeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblWeight.Location = new Point(122, 54);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(157, 35);
            lblWeight.TabIndex = 18;
            lblWeight.Text = "Weight (lb):";
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtCategory.Location = new Point(277, 267);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(176, 35);
            txtCategory.TabIndex = 17;
            txtCategory.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBMI
            // 
            txtBMI.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtBMI.Location = new Point(277, 216);
            txtBMI.Name = "txtBMI";
            txtBMI.ReadOnly = true;
            txtBMI.Size = new Size(176, 35);
            txtBMI.TabIndex = 16;
            txtBMI.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Honeydew;
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(400, 330);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 56);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Honeydew;
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(225, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 56);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Honeydew;
            btnCalculate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnCalculate.Location = new Point(46, 330);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(116, 56);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtWeight.Location = new Point(297, 54);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(176, 35);
            txtWeight.TabIndex = 11;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // frmBMIExceptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(570, 450);
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
            Name = "frmBMIExceptions";
            Text = "Homework 03 BMI Exceptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHeight;
        private Label lblCategory;
        private Label lblBMI;
        private Label lblHeight;
        private Label lblWeight;
        private TextBox txtCategory;
        private TextBox txtBMI;
        private Button btnExit;
        private Button btnClear;
        private Button btnCalculate;
        private TextBox txtWeight;
    }
}
