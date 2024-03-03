namespace Homework05_01
{
    partial class frmSuperHeroDB
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
            ddlName = new ComboBox();
            lblName = new Label();
            lblAlterEgo = new Label();
            lblBio = new Label();
            pbHeros = new PictureBox();
            lblURL = new Label();
            btnClear = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbHeros).BeginInit();
            SuspendLayout();
            // 
            // ddlName
            // 
            ddlName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            ddlName.FormattingEnabled = true;
            ddlName.Location = new Point(59, 55);
            ddlName.Name = "ddlName";
            ddlName.Size = new Size(291, 37);
            ddlName.TabIndex = 0;
            ddlName.SelectedIndexChanged += ddlName_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.BackColor = Color.LightBlue;
            lblName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblName.Location = new Point(59, 113);
            lblName.Name = "lblName";
            lblName.Size = new Size(291, 43);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlterEgo
            // 
            lblAlterEgo.BackColor = Color.LightBlue;
            lblAlterEgo.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblAlterEgo.Location = new Point(59, 176);
            lblAlterEgo.Name = "lblAlterEgo";
            lblAlterEgo.Size = new Size(291, 43);
            lblAlterEgo.TabIndex = 2;
            lblAlterEgo.Text = "Alter Ego:";
            lblAlterEgo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBio
            // 
            lblBio.BackColor = Color.LightBlue;
            lblBio.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblBio.Location = new Point(59, 249);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(291, 333);
            lblBio.TabIndex = 3;
            lblBio.Text = "Bio:";
            // 
            // pbHeros
            // 
            pbHeros.BackColor = Color.LightBlue;
            pbHeros.Location = new Point(385, 55);
            pbHeros.Name = "pbHeros";
            pbHeros.Size = new Size(409, 483);
            pbHeros.TabIndex = 4;
            pbHeros.TabStop = false;
            // 
            // lblURL
            // 
            lblURL.BackColor = Color.LightBlue;
            lblURL.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblURL.Location = new Point(385, 550);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(409, 34);
            lblURL.TabIndex = 5;
            lblURL.Text = "URL:";
            lblURL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(201, 597);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(161, 47);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(460, 597);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 47);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmSuperHeroDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(851, 669);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblURL);
            Controls.Add(pbHeros);
            Controls.Add(lblBio);
            Controls.Add(lblAlterEgo);
            Controls.Add(lblName);
            Controls.Add(ddlName);
            Name = "frmSuperHeroDB";
            Text = "Homework 5 - #1 Super Hero Database";
            Load += frmSuperHeroDB_Load;
            ((System.ComponentModel.ISupportInitialize)pbHeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox ddlName;
        private Label lblName;
        private Label lblAlterEgo;
        private Label lblBio;
        private PictureBox pbHeros;
        private Label lblURL;
        private Button btnClear;
        private Button btnExit;
    }
}
