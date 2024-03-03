namespace Homework05_02
{
    partial class frmJobDB
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
            lblIndustries = new Label();
            label1 = new Label();
            lbIndustries = new ListBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblIndustries
            // 
            lblIndustries.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblIndustries.Location = new Point(103, 9);
            lblIndustries.Name = "lblIndustries";
            lblIndustries.Size = new Size(330, 43);
            lblIndustries.TabIndex = 0;
            lblIndustries.Text = "What industries are you interested in?";
            lblIndustries.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            label1.Location = new Point(103, 49);
            label1.Name = "label1";
            label1.Size = new Size(330, 43);
            label1.TabIndex = 1;
            label1.Text = "(Select all that apply)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbIndustries
            // 
            lbIndustries.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lbIndustries.FormattingEnabled = true;
            lbIndustries.ItemHeight = 24;
            lbIndustries.Location = new Point(103, 95);
            lbIndustries.Name = "lbIndustries";
            lbIndustries.SelectionMode = SelectionMode.MultiSimple;
            lbIndustries.Size = new Size(330, 148);
            lbIndustries.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            btnSearch.Location = new Point(202, 280);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 59);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmJobDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(549, 358);
            Controls.Add(btnSearch);
            Controls.Add(lbIndustries);
            Controls.Add(label1);
            Controls.Add(lblIndustries);
            Name = "frmJobDB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homework 5 - #2 Job Database";
            Load += frmJobDB_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblIndustries;
        private Label label1;
        private ListBox lbIndustries;
        private Button btnSearch;
    }
}
