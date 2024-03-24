namespace Homework07_1
{
    partial class frmLetterDelivery
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
            groupBox1 = new GroupBox();
            txtTrackingNumber = new TextBox();
            txtSentDate = new TextBox();
            txtRecipient = new TextBox();
            lblAdditionalFee = new Label();
            lblTrackingNumber = new Label();
            LblSentDate = new Label();
            lblRecipient = new Label();
            groupBox2 = new GroupBox();
            txtResult = new TextBox();
            btnSend = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PowderBlue;
            groupBox1.Controls.Add(txtTrackingNumber);
            groupBox1.Controls.Add(txtSentDate);
            groupBox1.Controls.Add(txtRecipient);
            groupBox1.Controls.Add(lblAdditionalFee);
            groupBox1.Controls.Add(lblTrackingNumber);
            groupBox1.Controls.Add(LblSentDate);
            groupBox1.Controls.Add(lblRecipient);
            groupBox1.Font = new Font("Arial Narrow", 15.25F, FontStyle.Bold);
            groupBox1.Location = new Point(25, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 470);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txtTrackingNumber
            // 
            txtTrackingNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTrackingNumber.Location = new Point(299, 260);
            txtTrackingNumber.Name = "txtTrackingNumber";
            txtTrackingNumber.Size = new Size(364, 38);
            txtTrackingNumber.TabIndex = 2;
            txtTrackingNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSentDate
            // 
            txtSentDate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtSentDate.Location = new Point(299, 156);
            txtSentDate.Name = "txtSentDate";
            txtSentDate.Size = new Size(364, 38);
            txtSentDate.TabIndex = 1;
            txtSentDate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRecipient
            // 
            txtRecipient.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtRecipient.Location = new Point(299, 56);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(364, 38);
            txtRecipient.TabIndex = 0;
            txtRecipient.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAdditionalFee
            // 
            lblAdditionalFee.BackColor = Color.AliceBlue;
            lblAdditionalFee.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAdditionalFee.Location = new Point(55, 358);
            lblAdditionalFee.Name = "lblAdditionalFee";
            lblAdditionalFee.Size = new Size(608, 48);
            lblAdditionalFee.TabIndex = 6;
            lblAdditionalFee.Text = "(Additional Fee for Certified Letters)";
            lblAdditionalFee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrackingNumber
            // 
            lblTrackingNumber.BackColor = Color.AliceBlue;
            lblTrackingNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTrackingNumber.Location = new Point(55, 254);
            lblTrackingNumber.Name = "lblTrackingNumber";
            lblTrackingNumber.Size = new Size(207, 48);
            lblTrackingNumber.TabIndex = 5;
            lblTrackingNumber.Text = "Tracking Number:";
            lblTrackingNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblSentDate
            // 
            LblSentDate.BackColor = Color.AliceBlue;
            LblSentDate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            LblSentDate.Location = new Point(55, 150);
            LblSentDate.Name = "LblSentDate";
            LblSentDate.Size = new Size(207, 48);
            LblSentDate.TabIndex = 4;
            LblSentDate.Text = "Sent Date:";
            LblSentDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipient
            // 
            lblRecipient.BackColor = Color.AliceBlue;
            lblRecipient.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblRecipient.Location = new Point(55, 50);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(207, 48);
            lblRecipient.TabIndex = 3;
            lblRecipient.Text = "Recipient:";
            lblRecipient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PowderBlue;
            groupBox2.Controls.Add(txtResult);
            groupBox2.Font = new Font("Arial Narrow", 15.25F, FontStyle.Bold);
            groupBox2.Location = new Point(767, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(778, 800);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.AliceBlue;
            txtResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtResult.Location = new Point(21, 34);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(742, 745);
            txtResult.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.CadetBlue;
            btnSend.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSend.ForeColor = Color.AliceBlue;
            btnSend.Location = new Point(80, 526);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(176, 59);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.CadetBlue;
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.ForeColor = Color.AliceBlue;
            btnClear.Location = new Point(297, 526);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 59);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.CadetBlue;
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.ForeColor = Color.AliceBlue;
            btnExit.Location = new Point(512, 526);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 59);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmLetterDelivery
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            CancelButton = btnClear;
            ClientSize = new Size(1576, 848);
            Controls.Add(btnExit);
            Controls.Add(groupBox2);
            Controls.Add(btnClear);
            Controls.Add(groupBox1);
            Controls.Add(btnSend);
            Name = "frmLetterDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Letter Delivery";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTrackingNumber;
        private TextBox txtSentDate;
        private TextBox txtRecipient;
        private Label lblAdditionalFee;
        private Label lblTrackingNumber;
        private Label LblSentDate;
        private Label lblRecipient;
        private GroupBox groupBox2;
        private TextBox txtResult;
        private Button btnSend;
        private Button btnClear;
        private Button btnExit;
    }
}
