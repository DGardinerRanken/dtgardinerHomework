namespace Homework02_04
{
    partial class frmCollegeAdmission
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
            this.btnAdmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblAcceptOrReject = new System.Windows.Forms.Label();
            this.lblAdmisionTestScore = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtAdmissionTestScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdmit
            // 
            this.btnAdmit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmit.Location = new System.Drawing.Point(12, 268);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(181, 66);
            this.btnAdmit.TabIndex = 2;
            this.btnAdmit.Text = "&Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(406, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 66);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(607, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 66);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.BackColor = System.Drawing.Color.MediumPurple;
            this.lblGPA.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(103, 86);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(164, 53);
            this.lblGPA.TabIndex = 5;
            this.lblGPA.Text = "GPA:";
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcceptOrReject
            // 
            this.lblAcceptOrReject.BackColor = System.Drawing.Color.MediumPurple;
            this.lblAcceptOrReject.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptOrReject.Location = new System.Drawing.Point(214, 268);
            this.lblAcceptOrReject.Name = "lblAcceptOrReject";
            this.lblAcceptOrReject.Size = new System.Drawing.Size(164, 66);
            this.lblAcceptOrReject.TabIndex = 7;
            this.lblAcceptOrReject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmisionTestScore
            // 
            this.lblAdmisionTestScore.BackColor = System.Drawing.Color.MediumPurple;
            this.lblAdmisionTestScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmisionTestScore.Location = new System.Drawing.Point(524, 86);
            this.lblAdmisionTestScore.Name = "lblAdmisionTestScore";
            this.lblAdmisionTestScore.Size = new System.Drawing.Size(164, 53);
            this.lblAdmisionTestScore.TabIndex = 6;
            this.lblAdmisionTestScore.Text = "ATS:";
            this.lblAdmisionTestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGPA
            // 
            this.txtGPA.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(106, 170);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(161, 38);
            this.txtGPA.TabIndex = 0;
            this.txtGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdmissionTestScore
            // 
            this.txtAdmissionTestScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmissionTestScore.Location = new System.Drawing.Point(527, 170);
            this.txtAdmissionTestScore.Name = "txtAdmissionTestScore";
            this.txtAdmissionTestScore.Size = new System.Drawing.Size(161, 38);
            this.txtAdmissionTestScore.TabIndex = 1;
            this.txtAdmissionTestScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCollegeAdmission
            // 
            this.AcceptButton = this.btnAdmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdmissionTestScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblAdmisionTestScore);
            this.Controls.Add(this.lblAcceptOrReject);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdmit);
            this.Name = "frmCollegeAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblAcceptOrReject;
        private System.Windows.Forms.Label lblAdmisionTestScore;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtAdmissionTestScore;
    }
}

