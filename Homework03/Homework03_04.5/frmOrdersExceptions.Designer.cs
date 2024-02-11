namespace Homework03_04._5
{
    partial class frmOrdersExceptions
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
            btnClear = new Button();
            btnExit = new Button();
            btnValidate = new Button();
            lblResult = new Label();
            txtEstimatedDelivery = new TextBox();
            txtQuantity = new TextBox();
            txtItemNumber = new TextBox();
            lblEstimatedDelivery = new Label();
            lblQuantity = new Label();
            lblItemNumber = new Label();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Info;
            btnClear.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(274, 356);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 50);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            btnExit.Location = new Point(447, 356);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 50);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = SystemColors.Info;
            btnValidate.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            btnValidate.Location = new Point(96, 356);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(126, 50);
            btnValidate.TabIndex = 16;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.PowderBlue;
            lblResult.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblResult.Location = new Point(229, 275);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(218, 47);
            lblResult.TabIndex = 15;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEstimatedDelivery
            // 
            txtEstimatedDelivery.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            txtEstimatedDelivery.Location = new Point(386, 208);
            txtEstimatedDelivery.Name = "txtEstimatedDelivery";
            txtEstimatedDelivery.Size = new Size(218, 32);
            txtEstimatedDelivery.TabIndex = 14;
            txtEstimatedDelivery.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            txtQuantity.Location = new Point(386, 127);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(218, 32);
            txtQuantity.TabIndex = 13;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtItemNumber
            // 
            txtItemNumber.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            txtItemNumber.Location = new Point(386, 52);
            txtItemNumber.Name = "txtItemNumber";
            txtItemNumber.Size = new Size(218, 32);
            txtItemNumber.TabIndex = 12;
            txtItemNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEstimatedDelivery
            // 
            lblEstimatedDelivery.BackColor = Color.LightCyan;
            lblEstimatedDelivery.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblEstimatedDelivery.Location = new Point(85, 200);
            lblEstimatedDelivery.Name = "lblEstimatedDelivery";
            lblEstimatedDelivery.Size = new Size(295, 47);
            lblEstimatedDelivery.TabIndex = 11;
            lblEstimatedDelivery.Text = "Estimated Delivery Days [ 1, 30 ]:";
            lblEstimatedDelivery.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.LightCyan;
            lblQuantity.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblQuantity.Location = new Point(85, 119);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(295, 47);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity [ 1, 12 ]:";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemNumber
            // 
            lblItemNumber.BackColor = Color.LightCyan;
            lblItemNumber.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemNumber.Location = new Point(85, 44);
            lblItemNumber.Name = "lblItemNumber";
            lblItemNumber.Size = new Size(295, 47);
            lblItemNumber.TabIndex = 9;
            lblItemNumber.Text = "Item Number [ 100, 999 ]:";
            lblItemNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmOrdersExceptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(698, 450);
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
            Name = "frmOrdersExceptions";
            Text = "Homework 3 Orders Exceptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnExit;
        private Button btnValidate;
        private Label lblResult;
        private TextBox txtEstimatedDelivery;
        private TextBox txtQuantity;
        private TextBox txtItemNumber;
        private Label lblEstimatedDelivery;
        private Label lblQuantity;
        private Label lblItemNumber;
    }
}
