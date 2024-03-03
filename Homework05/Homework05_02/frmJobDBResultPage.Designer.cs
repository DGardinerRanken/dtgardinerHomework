namespace Homework05_02
{
    partial class frmJobDBResultPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbResults = new ListBox();
            btnReturn = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lbResults
            // 
            lbResults.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lbResults.FormattingEnabled = true;
            lbResults.ItemHeight = 24;
            lbResults.Location = new Point(113, 33);
            lbResults.Name = "lbResults";
            lbResults.SelectionMode = SelectionMode.MultiSimple;
            lbResults.Size = new Size(330, 196);
            lbResults.TabIndex = 3;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            btnReturn.Location = new Point(113, 266);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(128, 60);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            btnExit.Location = new Point(315, 266);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 60);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmJobDBResultPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(560, 354);
            Controls.Add(btnExit);
            Controls.Add(btnReturn);
            Controls.Add(lbResults);
            Name = "frmJobDBResultPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homework 5 - #2 Job DB Results Page";
            Load += frmJobDBResultPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbResults;
        private Button btnReturn;
        private Button btnExit;
    }
}