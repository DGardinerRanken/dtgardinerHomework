namespace Homework02_08
{
    partial class SalesTracker
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
            lblHowMuchWasSale = new Label();
            lblDanielleSales = new Label();
            lblEdwardSales = new Label();
            lblFrancisSales = new Label();
            lblResult = new Label();
            txtSaleAmount = new TextBox();
            btnDanielle = new Button();
            btnEdward = new Button();
            btnFrancis = new Button();
            txtDanielleSales = new TextBox();
            txtEdwardSales = new TextBox();
            txtFrancisSales = new TextBox();
            lblWhoMadeSale = new Label();
            lblGrandTotal = new Label();
            txtGrandTotal = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblHowMuchWasSale
            // 
            lblHowMuchWasSale.BackColor = SystemColors.GradientActiveCaption;
            lblHowMuchWasSale.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblHowMuchWasSale.Location = new Point(100, 22);
            lblHowMuchWasSale.Name = "lblHowMuchWasSale";
            lblHowMuchWasSale.Size = new Size(257, 47);
            lblHowMuchWasSale.TabIndex = 0;
            lblHowMuchWasSale.Text = "How much was the sale?";
            lblHowMuchWasSale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDanielleSales
            // 
            lblDanielleSales.BackColor = SystemColors.GradientActiveCaption;
            lblDanielleSales.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblDanielleSales.Location = new Point(31, 281);
            lblDanielleSales.Name = "lblDanielleSales";
            lblDanielleSales.Size = new Size(187, 34);
            lblDanielleSales.TabIndex = 1;
            lblDanielleSales.Text = "Danielle Sales:";
            lblDanielleSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEdwardSales
            // 
            lblEdwardSales.BackColor = SystemColors.GradientActiveCaption;
            lblEdwardSales.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblEdwardSales.Location = new Point(31, 348);
            lblEdwardSales.Name = "lblEdwardSales";
            lblEdwardSales.Size = new Size(187, 34);
            lblEdwardSales.TabIndex = 2;
            lblEdwardSales.Text = "Edward Sales:";
            lblEdwardSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFrancisSales
            // 
            lblFrancisSales.BackColor = SystemColors.GradientActiveCaption;
            lblFrancisSales.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblFrancisSales.Location = new Point(31, 415);
            lblFrancisSales.Name = "lblFrancisSales";
            lblFrancisSales.Size = new Size(187, 34);
            lblFrancisSales.TabIndex = 3;
            lblFrancisSales.Text = "Francis Sales:";
            lblFrancisSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.GradientActiveCaption;
            lblResult.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblResult.Location = new Point(31, 541);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(391, 47);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSaleAmount
            // 
            txtSaleAmount.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtSaleAmount.Location = new Point(100, 90);
            txtSaleAmount.Name = "txtSaleAmount";
            txtSaleAmount.Size = new Size(257, 35);
            txtSaleAmount.TabIndex = 5;
            txtSaleAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDanielle
            // 
            btnDanielle.BackColor = SystemColors.Highlight;
            btnDanielle.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnDanielle.ForeColor = SystemColors.ButtonHighlight;
            btnDanielle.Location = new Point(45, 209);
            btnDanielle.Name = "btnDanielle";
            btnDanielle.Size = new Size(118, 44);
            btnDanielle.TabIndex = 6;
            btnDanielle.Text = "Danielle";
            btnDanielle.UseVisualStyleBackColor = false;
            btnDanielle.Click += btnDanielle_Click;
            // 
            // btnEdward
            // 
            btnEdward.BackColor = SystemColors.Highlight;
            btnEdward.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnEdward.ForeColor = SystemColors.ButtonHighlight;
            btnEdward.Location = new Point(169, 209);
            btnEdward.Name = "btnEdward";
            btnEdward.Size = new Size(118, 44);
            btnEdward.TabIndex = 7;
            btnEdward.Text = "Edward";
            btnEdward.UseVisualStyleBackColor = false;
            btnEdward.Click += btnEdward_Click;
            // 
            // btnFrancis
            // 
            btnFrancis.BackColor = SystemColors.Highlight;
            btnFrancis.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnFrancis.ForeColor = SystemColors.ButtonHighlight;
            btnFrancis.Location = new Point(293, 209);
            btnFrancis.Name = "btnFrancis";
            btnFrancis.Size = new Size(118, 44);
            btnFrancis.TabIndex = 8;
            btnFrancis.Text = "Francis";
            btnFrancis.UseVisualStyleBackColor = false;
            btnFrancis.Click += btnFrancis_Click;
            // 
            // txtDanielleSales
            // 
            txtDanielleSales.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDanielleSales.Location = new Point(261, 281);
            txtDanielleSales.Name = "txtDanielleSales";
            txtDanielleSales.ReadOnly = true;
            txtDanielleSales.Size = new Size(120, 35);
            txtDanielleSales.TabIndex = 9;
            // 
            // txtEdwardSales
            // 
            txtEdwardSales.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEdwardSales.Location = new Point(261, 348);
            txtEdwardSales.Name = "txtEdwardSales";
            txtEdwardSales.ReadOnly = true;
            txtEdwardSales.Size = new Size(120, 35);
            txtEdwardSales.TabIndex = 10;
            // 
            // txtFrancisSales
            // 
            txtFrancisSales.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFrancisSales.Location = new Point(261, 415);
            txtFrancisSales.Name = "txtFrancisSales";
            txtFrancisSales.ReadOnly = true;
            txtFrancisSales.Size = new Size(120, 35);
            txtFrancisSales.TabIndex = 11;
            // 
            // lblWhoMadeSale
            // 
            lblWhoMadeSale.BackColor = SystemColors.GradientActiveCaption;
            lblWhoMadeSale.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblWhoMadeSale.Location = new Point(100, 147);
            lblWhoMadeSale.Name = "lblWhoMadeSale";
            lblWhoMadeSale.Size = new Size(257, 42);
            lblWhoMadeSale.TabIndex = 12;
            lblWhoMadeSale.Text = "Who made the sale?";
            lblWhoMadeSale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.BackColor = SystemColors.GradientActiveCaption;
            lblGrandTotal.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblGrandTotal.Location = new Point(31, 478);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(187, 34);
            lblGrandTotal.TabIndex = 13;
            lblGrandTotal.Text = "Grand Total:";
            lblGrandTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGrandTotal.Location = new Point(261, 478);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(120, 35);
            txtGrandTotal.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(54, 607);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 44);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Highlight;
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(282, 607);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 44);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // SalesTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(454, 663);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtGrandTotal);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblWhoMadeSale);
            Controls.Add(txtFrancisSales);
            Controls.Add(txtEdwardSales);
            Controls.Add(txtDanielleSales);
            Controls.Add(btnFrancis);
            Controls.Add(btnEdward);
            Controls.Add(btnDanielle);
            Controls.Add(txtSaleAmount);
            Controls.Add(lblResult);
            Controls.Add(lblFrancisSales);
            Controls.Add(lblEdwardSales);
            Controls.Add(lblDanielleSales);
            Controls.Add(lblHowMuchWasSale);
            Name = "SalesTracker";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHowMuchWasSale;
        private Label lblDanielleSales;
        private Label lblEdwardSales;
        private Label lblFrancisSales;
        private Label lblResult;
        private TextBox txtSaleAmount;
        private Button btnDanielle;
        private Button btnEdward;
        private Button btnFrancis;
        private TextBox txtDanielleSales;
        private TextBox txtEdwardSales;
        private TextBox txtFrancisSales;
        private Label lblWhoMadeSale;
        private Label lblGrandTotal;
        private TextBox txtGrandTotal;
        private Button btnClear;
        private Button btnExit;
    }
}
