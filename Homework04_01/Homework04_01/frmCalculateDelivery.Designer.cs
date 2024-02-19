namespace Homework04_01
{
    partial class frmCalculateDelivery
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
            lblZipCode = new Label();
            txtZipCode = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblDeliveryCharge = new Label();
            txtDeliveryCharge = new TextBox();
            SuspendLayout();
            // 
            // lblZipCode
            // 
            lblZipCode.BackColor = Color.Moccasin;
            lblZipCode.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblZipCode.Location = new Point(58, 69);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(192, 45);
            lblZipCode.TabIndex = 0;
            lblZipCode.Text = "Zip Code:";
            lblZipCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtZipCode.Location = new Point(58, 135);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(192, 38);
            txtZipCode.TabIndex = 1;
            txtZipCode.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(307, 60);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(158, 63);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(307, 163);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 63);
            btnClear.TabIndex = 3;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(307, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 63);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDeliveryCharge
            // 
            lblDeliveryCharge.BackColor = Color.Moccasin;
            lblDeliveryCharge.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDeliveryCharge.Location = new Point(531, 69);
            lblDeliveryCharge.Name = "lblDeliveryCharge";
            lblDeliveryCharge.Size = new Size(192, 45);
            lblDeliveryCharge.TabIndex = 5;
            lblDeliveryCharge.Text = "Delivery Charge:";
            lblDeliveryCharge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDeliveryCharge
            // 
            txtDeliveryCharge.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDeliveryCharge.Location = new Point(531, 135);
            txtDeliveryCharge.Name = "txtDeliveryCharge";
            txtDeliveryCharge.ReadOnly = true;
            txtDeliveryCharge.Size = new Size(192, 38);
            txtDeliveryCharge.TabIndex = 6;
            txtDeliveryCharge.TextAlign = HorizontalAlignment.Center;
            // 
            // frmCalculateDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 380);
            Controls.Add(txtDeliveryCharge);
            Controls.Add(lblDeliveryCharge);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtZipCode);
            Controls.Add(lblZipCode);
            Name = "frmCalculateDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homework Chapter 8 - #1 Delivery Charges";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZipCode;
        private TextBox txtZipCode;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblDeliveryCharge;
        private TextBox txtDeliveryCharge;
    }
}
