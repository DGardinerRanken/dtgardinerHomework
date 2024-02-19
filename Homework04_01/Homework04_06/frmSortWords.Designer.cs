namespace Homework04_06
{
    partial class frmSortWords
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
            txtPhraseInput = new TextBox();
            btnSort = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtPhraseOutput = new TextBox();
            SuspendLayout();
            // 
            // txtPhraseInput
            // 
            txtPhraseInput.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtPhraseInput.Location = new Point(183, 60);
            txtPhraseInput.Name = "txtPhraseInput";
            txtPhraseInput.Size = new Size(406, 35);
            txtPhraseInput.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnSort.Location = new Point(107, 147);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(140, 72);
            btnSort.TabIndex = 1;
            btnSort.Text = "&Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(312, 147);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 72);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(508, 147);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 72);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtPhraseOutput
            // 
            txtPhraseOutput.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtPhraseOutput.Location = new Point(183, 271);
            txtPhraseOutput.Name = "txtPhraseOutput";
            txtPhraseOutput.ReadOnly = true;
            txtPhraseOutput.Size = new Size(406, 35);
            txtPhraseOutput.TabIndex = 4;
            // 
            // frmSortWords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(790, 353);
            Controls.Add(txtPhraseOutput);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSort);
            Controls.Add(txtPhraseInput);
            Name = "frmSortWords";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhraseInput;
        private Button btnSort;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtPhraseOutput;
    }
}
