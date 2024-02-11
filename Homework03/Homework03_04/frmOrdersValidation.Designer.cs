namespace Homework03_04
{
    partial class frmOrdersValidation
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
            lblItemNumber = new Label();
            lblQuantity = new Label();
            lblEstimatedDelivery = new Label();
            txtItemNumber = new TextBox();
            txtQuantity = new TextBox();
            txtEstimatedDelivery = new TextBox();
            lblResult = new Label();
            btnValidate = new Button();
            btnExit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblItemNumber
            // 
            lblItemNumber.BackColor = Color.DarkSalmon;
            lblItemNumber.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemNumber.Location = new Point(40, 42);
            lblItemNumber.Name = "lblItemNumber";
            lblItemNumber.Size = new Size(295, 47);
            lblItemNumber.TabIndex = 0;
            lblItemNumber.Text = "Item Number [ 100, 999 ]:";
            lblItemNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.DarkSalmon;
            lblQuantity.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblQuantity.Location = new Point(40, 117);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(295, 47);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity [ 1, 12 ]:";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEstimatedDelivery
            // 
            lblEstimatedDelivery.BackColor = Color.DarkSalmon;
            lblEstimatedDelivery.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblEstimatedDelivery.Location = new Point(40, 198);
            lblEstimatedDelivery.Name = "lblEstimatedDelivery";
            lblEstimatedDelivery.Size = new Size(295, 47);
            lblEstimatedDelivery.TabIndex = 2;
            lblEstimatedDelivery.Text = "Estimated Delivery Days [ 1, 30 ]:";
            lblEstimatedDelivery.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtItemNumber
            // 
            txtItemNumber.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            txtItemNumber.Location = new Point(341, 50);
            txtItemNumber.Name = "txtItemNumber";
            txtItemNumber.Size = new Size(218, 32);
            txtItemNumber.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            txtQuantity.Location = new Point(341, 125);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(218, 32);
            txtQuantity.TabIndex = 4;
            // 
            // txtEstimatedDelivery
            // 
            txtEstimatedDelivery.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            txtEstimatedDelivery.Location = new Point(341, 206);
            txtEstimatedDelivery.Name = "txtEstimatedDelivery";
            txtEstimatedDelivery.Size = new Size(218, 32);
            txtEstimatedDelivery.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightSalmon;
            lblResult.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblResult.Location = new Point(184, 273);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(218, 47);
            lblResult.TabIndex = 6;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = SystemColors.Info;
            btnValidate.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            btnValidate.Location = new Point(51, 354);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(126, 50);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            btnExit.Location = new Point(402, 354);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 50);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Info;
            btnClear.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(229, 354);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 50);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmOrdersValidation
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(611, 414);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnValidate);
            Controls.Add(lblResult);
            Controls.Add(txtEstimatedDelivery);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemNumber);
            Controls.Add(lblEstimatedDelivery);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemNumber);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "frmOrdersValidation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemNumber;
        private Label lblQuantity;
        private Label lblEstimatedDelivery;
        private TextBox txtItemNumber;
        private TextBox txtQuantity;
        private TextBox txtEstimatedDelivery;
        private Label lblResult;
        private Button btnValidate;
        private Button btnExit;
        private Button btnClear;
    }
}
