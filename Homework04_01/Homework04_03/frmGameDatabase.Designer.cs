namespace Homework04_03
{
    partial class frmGameDatabase
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
            lblSearchTerm = new Label();
            txtSearchTerm = new TextBox();
            txtResult = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblSearchTerm
            // 
            lblSearchTerm.BackColor = Color.PeachPuff;
            lblSearchTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblSearchTerm.Location = new Point(228, 46);
            lblSearchTerm.Name = "lblSearchTerm";
            lblSearchTerm.Size = new Size(346, 50);
            lblSearchTerm.TabIndex = 5;
            lblSearchTerm.Text = "Search Term:";
            lblSearchTerm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtSearchTerm.Location = new Point(167, 119);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(472, 38);
            txtSearchTerm.TabIndex = 0;
            txtSearchTerm.TextAlign = HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.PeachPuff;
            txtResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtResult.Location = new Point(167, 169);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(472, 165);
            txtResult.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSearch.Location = new Point(86, 360);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 68);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(320, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 68);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(566, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(157, 68);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmGameDatabase
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtResult);
            Controls.Add(txtSearchTerm);
            Controls.Add(lblSearchTerm);
            Name = "frmGameDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homework Chapter 8 - Game DB #3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchTerm;
        private TextBox txtSearchTerm;
        private TextBox txtResult;
        private Button btnSearch;
        private Button btnClear;
        private Button btnExit;
    }
}
