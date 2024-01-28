namespace Homework02_01
{
    partial class DistanceConverter
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
            lblDistanceInMiles = new Label();
            lblDistanceInKilos = new Label();
            lblResult = new Label();
            txtDistanceInMiles = new TextBox();
            txtDistanceInKilos = new TextBox();
            btnConvertToKm = new Button();
            btnConvertToMiles = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblDistanceInMiles
            // 
            lblDistanceInMiles.BackColor = Color.LightSalmon;
            lblDistanceInMiles.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDistanceInMiles.Location = new Point(83, 56);
            lblDistanceInMiles.Name = "lblDistanceInMiles";
            lblDistanceInMiles.Size = new Size(235, 55);
            lblDistanceInMiles.TabIndex = 7;
            lblDistanceInMiles.Text = "Distance in Miles:";
            lblDistanceInMiles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDistanceInKilos
            // 
            lblDistanceInKilos.BackColor = Color.LightSalmon;
            lblDistanceInKilos.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDistanceInKilos.Location = new Point(466, 56);
            lblDistanceInKilos.Name = "lblDistanceInKilos";
            lblDistanceInKilos.Size = new Size(235, 55);
            lblDistanceInKilos.TabIndex = 8;
            lblDistanceInKilos.Text = "Distance In Kilos:";
            lblDistanceInKilos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightSalmon;
            lblResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResult.Location = new Point(83, 274);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(618, 55);
            lblResult.TabIndex = 6;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDistanceInMiles
            // 
            txtDistanceInMiles.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDistanceInMiles.Location = new Point(83, 138);
            txtDistanceInMiles.Name = "txtDistanceInMiles";
            txtDistanceInMiles.Size = new Size(235, 38);
            txtDistanceInMiles.TabIndex = 0;
            txtDistanceInMiles.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDistanceInKilos
            // 
            txtDistanceInKilos.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDistanceInKilos.Location = new Point(466, 138);
            txtDistanceInKilos.Name = "txtDistanceInKilos";
            txtDistanceInKilos.Size = new Size(235, 38);
            txtDistanceInKilos.TabIndex = 1;
            txtDistanceInKilos.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConvertToKm
            // 
            btnConvertToKm.BackColor = Color.Salmon;
            btnConvertToKm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnConvertToKm.Location = new Point(83, 194);
            btnConvertToKm.Name = "btnConvertToKm";
            btnConvertToKm.Size = new Size(235, 45);
            btnConvertToKm.TabIndex = 2;
            btnConvertToKm.Text = "Convert to &Km";
            btnConvertToKm.UseVisualStyleBackColor = false;
            btnConvertToKm.Click += btnConvertToKm_Click;
            // 
            // btnConvertToMiles
            // 
            btnConvertToMiles.BackColor = Color.Salmon;
            btnConvertToMiles.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnConvertToMiles.Location = new Point(466, 194);
            btnConvertToMiles.Name = "btnConvertToMiles";
            btnConvertToMiles.Size = new Size(235, 45);
            btnConvertToMiles.TabIndex = 3;
            btnConvertToMiles.Text = "Convert to &Miles";
            btnConvertToMiles.UseVisualStyleBackColor = false;
            btnConvertToMiles.Click += btnConvertToMiles_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Salmon;
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(83, 361);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(235, 45);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Salmon;
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(466, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(235, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // DistanceConverter
            // 
            AcceptButton = btnConvertToKm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvertToMiles);
            Controls.Add(btnConvertToKm);
            Controls.Add(txtDistanceInKilos);
            Controls.Add(txtDistanceInMiles);
            Controls.Add(lblResult);
            Controls.Add(lblDistanceInKilos);
            Controls.Add(lblDistanceInMiles);
            Name = "DistanceConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistanceInMiles;
        private Label lblDistanceInKilos;
        private Label lblResult;
        private TextBox txtDistanceInMiles;
        private TextBox txtDistanceInKilos;
        private Button btnConvertToKm;
        private Button btnConvertToMiles;
        private Button btnClear;
        private Button btnExit;
    }
}
