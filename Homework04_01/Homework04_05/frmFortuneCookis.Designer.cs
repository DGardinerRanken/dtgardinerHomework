namespace Homework04_05
{
    partial class frmFortuneCookis
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
            btnOpen = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtFortune = new TextBox();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnOpen.Location = new Point(67, 51);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(145, 62);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "&Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(319, 51);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 62);
            btnClear.TabIndex = 1;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(563, 51);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 62);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtFortune
            // 
            txtFortune.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtFortune.Location = new Point(67, 160);
            txtFortune.Multiline = true;
            txtFortune.Name = "txtFortune";
            txtFortune.ReadOnly = true;
            txtFortune.Size = new Size(641, 138);
            txtFortune.TabIndex = 3;
            // 
            // frmFortuneCookis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 334);
            Controls.Add(txtFortune);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnOpen);
            Name = "frmFortuneCookis";
            Text = "Homework Chapter 8 - #5 Fortune Cookie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtFortune;
    }
}
