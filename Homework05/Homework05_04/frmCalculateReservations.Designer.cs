namespace Homework05_04
{
    partial class frmCalculateReservations
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
            lblArrivalDate = new Label();
            lblDepartureDate = new Label();
            lblNumOfNights = new Label();
            lblTotalPrice = new Label();
            lblAvgPrice = new Label();
            btnCalculate = new Button();
            dtpArrival = new DateTimePicker();
            dtpDeparture = new DateTimePicker();
            txtNumOfNights = new TextBox();
            txtTotalPrice = new TextBox();
            txtAvgPrice = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblArrivalDate
            // 
            lblArrivalDate.BackColor = Color.LightPink;
            lblArrivalDate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblArrivalDate.Location = new Point(43, 28);
            lblArrivalDate.Name = "lblArrivalDate";
            lblArrivalDate.Size = new Size(132, 37);
            lblArrivalDate.TabIndex = 0;
            lblArrivalDate.Text = "Arrival Date:";
            lblArrivalDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.BackColor = Color.LightPink;
            lblDepartureDate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblDepartureDate.Location = new Point(43, 79);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new Size(163, 37);
            lblDepartureDate.TabIndex = 1;
            lblDepartureDate.Text = "Departure Date:";
            lblDepartureDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumOfNights
            // 
            lblNumOfNights.BackColor = Color.LightPink;
            lblNumOfNights.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblNumOfNights.Location = new Point(43, 127);
            lblNumOfNights.Name = "lblNumOfNights";
            lblNumOfNights.Size = new Size(243, 37);
            lblNumOfNights.TabIndex = 2;
            lblNumOfNights.Text = "Number Of Nights:";
            lblNumOfNights.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = Color.LightPink;
            lblTotalPrice.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(43, 176);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(243, 37);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "Total Price:";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvgPrice
            // 
            lblAvgPrice.BackColor = Color.LightPink;
            lblAvgPrice.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblAvgPrice.Location = new Point(43, 222);
            lblAvgPrice.Name = "lblAvgPrice";
            lblAvgPrice.Size = new Size(243, 37);
            lblAvgPrice.TabIndex = 4;
            lblAvgPrice.Text = "Average Price Per Night:";
            lblAvgPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnCalculate.Location = new Point(195, 277);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(115, 45);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // dtpArrival
            // 
            dtpArrival.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            dtpArrival.Location = new Point(181, 30);
            dtpArrival.MinDate = new DateTime(2024, 3, 3, 0, 0, 0, 0);
            dtpArrival.Name = "dtpArrival";
            dtpArrival.Size = new Size(402, 35);
            dtpArrival.TabIndex = 6;
            // 
            // dtpDeparture
            // 
            dtpDeparture.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            dtpDeparture.Location = new Point(212, 81);
            dtpDeparture.MinDate = new DateTime(2024, 3, 3, 0, 0, 0, 0);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(371, 35);
            dtpDeparture.TabIndex = 7;
            dtpDeparture.Value = new DateTime(2024, 3, 3, 16, 9, 52, 0);
            // 
            // txtNumOfNights
            // 
            txtNumOfNights.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtNumOfNights.Location = new Point(292, 127);
            txtNumOfNights.Name = "txtNumOfNights";
            txtNumOfNights.ReadOnly = true;
            txtNumOfNights.Size = new Size(291, 35);
            txtNumOfNights.TabIndex = 8;
            txtNumOfNights.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtTotalPrice.Location = new Point(292, 176);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(291, 35);
            txtTotalPrice.TabIndex = 9;
            txtTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAvgPrice
            // 
            txtAvgPrice.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtAvgPrice.Location = new Point(292, 222);
            txtAvgPrice.Name = "txtAvgPrice";
            txtAvgPrice.ReadOnly = true;
            txtAvgPrice.Size = new Size(291, 35);
            txtAvgPrice.TabIndex = 10;
            txtAvgPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(325, 277);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 45);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCalculateReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(633, 333);
            Controls.Add(btnExit);
            Controls.Add(txtAvgPrice);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtNumOfNights);
            Controls.Add(dtpDeparture);
            Controls.Add(dtpArrival);
            Controls.Add(btnCalculate);
            Controls.Add(lblAvgPrice);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblNumOfNights);
            Controls.Add(lblDepartureDate);
            Controls.Add(lblArrivalDate);
            Name = "frmCalculateReservations";
            Text = "Form1";
            Load += frmCalculateReservations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArrivalDate;
        private Label lblDepartureDate;
        private Label lblNumOfNights;
        private Label lblTotalPrice;
        private Label lblAvgPrice;
        private Button btnCalculate;
        private DateTimePicker dtpArrival;
        private DateTimePicker dtpDeparture;
        private TextBox txtNumOfNights;
        private TextBox txtTotalPrice;
        private TextBox txtAvgPrice;
        private Button btnExit;
    }
}
