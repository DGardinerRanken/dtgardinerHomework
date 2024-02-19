namespace Homework04_04
{
    partial class frmMovieDatabase
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
            btnExit = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            txtResult = new TextBox();
            txtSearchTerm = new TextBox();
            lblSearchTerm = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(562, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(157, 68);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(316, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 68);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSearch.Location = new Point(82, 348);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 68);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.LightCoral;
            txtResult.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(82, 161);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(637, 165);
            txtResult.TabIndex = 4;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtSearchTerm.Location = new Point(163, 107);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(472, 38);
            txtSearchTerm.TabIndex = 0;
            txtSearchTerm.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSearchTerm
            // 
            lblSearchTerm.BackColor = Color.LightCoral;
            lblSearchTerm.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblSearchTerm.Location = new Point(224, 34);
            lblSearchTerm.Name = "lblSearchTerm";
            lblSearchTerm.Size = new Size(346, 50);
            lblSearchTerm.TabIndex = 5;
            lblSearchTerm.Text = "Search Term:";
            lblSearchTerm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMovieDatabase
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtResult);
            Controls.Add(txtSearchTerm);
            Controls.Add(lblSearchTerm);
            Name = "frmMovieDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homework Chapter 8 - #4 Movie Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtResult;
        private TextBox txtSearchTerm;
        private Label lblSearchTerm;
    }
}
