namespace Photos
{
    partial class frmPhotos
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
            lblWidth = new Label();
            lblHeight = new Label();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            gbFrame = new GroupBox();
            radFramed = new RadioButton();
            radMatted = new RadioButton();
            radUnframed = new RadioButton();
            gbColor = new GroupBox();
            radWhite = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            radBlack = new RadioButton();
            gbMaterial = new GroupBox();
            radGold = new RadioButton();
            radSilver = new RadioButton();
            radSteel = new RadioButton();
            radOak = new RadioButton();
            radPine = new RadioButton();
            gbStyle = new GroupBox();
            radEclectic = new RadioButton();
            radVintage = new RadioButton();
            radAntique = new RadioButton();
            radModern = new RadioButton();
            radSimple = new RadioButton();
            btnCalculate = new Button();
            brnClear = new Button();
            btnExit = new Button();
            lblDescription = new Label();
            lblCost = new Label();
            txtCost = new TextBox();
            gbFrame.SuspendLayout();
            gbColor.SuspendLayout();
            gbMaterial.SuspendLayout();
            gbStyle.SuspendLayout();
            SuspendLayout();
            // 
            // lblWidth
            // 
            lblWidth.BackColor = Color.LightSkyBlue;
            lblWidth.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblWidth.Location = new Point(33, 27);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(245, 38);
            lblWidth.TabIndex = 0;
            lblWidth.Text = "Width (in):";
            lblWidth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            lblHeight.BackColor = Color.LightSkyBlue;
            lblHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblHeight.Location = new Point(33, 97);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(245, 38);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Height (in):";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtWidth.Location = new Point(419, 27);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(468, 38);
            txtWidth.TabIndex = 0;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtHeight.Location = new Point(419, 97);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(468, 38);
            txtHeight.TabIndex = 1;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // gbFrame
            // 
            gbFrame.BackColor = Color.LightSkyBlue;
            gbFrame.Controls.Add(radFramed);
            gbFrame.Controls.Add(radMatted);
            gbFrame.Controls.Add(radUnframed);
            gbFrame.Font = new Font("Arial Narrow", 15.25F, FontStyle.Bold);
            gbFrame.Location = new Point(33, 181);
            gbFrame.Name = "gbFrame";
            gbFrame.Size = new Size(854, 151);
            gbFrame.TabIndex = 4;
            gbFrame.TabStop = false;
            gbFrame.Text = "Framed";
            // 
            // radFramed
            // 
            radFramed.AutoSize = true;
            radFramed.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            radFramed.Location = new Point(295, 104);
            radFramed.Name = "radFramed";
            radFramed.Size = new Size(113, 35);
            radFramed.TabIndex = 2;
            radFramed.TabStop = true;
            radFramed.Text = "Framed";
            radFramed.UseVisualStyleBackColor = true;
            // 
            // radMatted
            // 
            radMatted.AutoSize = true;
            radMatted.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            radMatted.Location = new Point(295, 53);
            radMatted.Name = "radMatted";
            radMatted.Size = new Size(102, 35);
            radMatted.TabIndex = 1;
            radMatted.TabStop = true;
            radMatted.Text = "Matted";
            radMatted.UseVisualStyleBackColor = true;
            // 
            // radUnframed
            // 
            radUnframed.AutoSize = true;
            radUnframed.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            radUnframed.Location = new Point(295, 0);
            radUnframed.Name = "radUnframed";
            radUnframed.Size = new Size(136, 35);
            radUnframed.TabIndex = 0;
            radUnframed.TabStop = true;
            radUnframed.Text = "Unframed";
            radUnframed.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            gbColor.BackColor = Color.LightSkyBlue;
            gbColor.Controls.Add(radWhite);
            gbColor.Controls.Add(radBlue);
            gbColor.Controls.Add(radGreen);
            gbColor.Controls.Add(radRed);
            gbColor.Controls.Add(radBlack);
            gbColor.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbColor.Location = new Point(33, 364);
            gbColor.Name = "gbColor";
            gbColor.Size = new Size(214, 408);
            gbColor.TabIndex = 5;
            gbColor.TabStop = false;
            gbColor.Text = "Color";
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radWhite.Location = new Point(39, 343);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(86, 28);
            radWhite.TabIndex = 4;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radBlue.Location = new Point(39, 261);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(73, 28);
            radBlue.TabIndex = 3;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radGreen.Location = new Point(39, 177);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(89, 28);
            radGreen.TabIndex = 2;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radRed.Location = new Point(39, 98);
            radRed.Name = "radRed";
            radRed.Size = new Size(68, 28);
            radRed.TabIndex = 1;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radBlack.Location = new Point(39, 28);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(84, 28);
            radBlack.TabIndex = 0;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // gbMaterial
            // 
            gbMaterial.BackColor = Color.LightSkyBlue;
            gbMaterial.Controls.Add(radGold);
            gbMaterial.Controls.Add(radSilver);
            gbMaterial.Controls.Add(radSteel);
            gbMaterial.Controls.Add(radOak);
            gbMaterial.Controls.Add(radPine);
            gbMaterial.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            gbMaterial.Location = new Point(352, 364);
            gbMaterial.Name = "gbMaterial";
            gbMaterial.Size = new Size(228, 408);
            gbMaterial.TabIndex = 6;
            gbMaterial.TabStop = false;
            gbMaterial.Text = "Material";
            // 
            // radGold
            // 
            radGold.AutoSize = true;
            radGold.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radGold.Location = new Point(46, 348);
            radGold.Name = "radGold";
            radGold.Size = new Size(75, 28);
            radGold.TabIndex = 9;
            radGold.TabStop = true;
            radGold.Text = "Gold";
            radGold.UseVisualStyleBackColor = true;
            // 
            // radSilver
            // 
            radSilver.AutoSize = true;
            radSilver.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radSilver.Location = new Point(46, 266);
            radSilver.Name = "radSilver";
            radSilver.Size = new Size(85, 28);
            radSilver.TabIndex = 3;
            radSilver.TabStop = true;
            radSilver.Text = "Silver";
            radSilver.UseVisualStyleBackColor = true;
            // 
            // radSteel
            // 
            radSteel.AutoSize = true;
            radSteel.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radSteel.Location = new Point(46, 182);
            radSteel.Name = "radSteel";
            radSteel.Size = new Size(78, 28);
            radSteel.TabIndex = 2;
            radSteel.TabStop = true;
            radSteel.Text = "Steel";
            radSteel.UseVisualStyleBackColor = true;
            // 
            // radOak
            // 
            radOak.AutoSize = true;
            radOak.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radOak.Location = new Point(46, 103);
            radOak.Name = "radOak";
            radOak.Size = new Size(68, 28);
            radOak.TabIndex = 1;
            radOak.TabStop = true;
            radOak.Text = "Oak";
            radOak.UseVisualStyleBackColor = true;
            // 
            // radPine
            // 
            radPine.AutoSize = true;
            radPine.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radPine.Location = new Point(46, 33);
            radPine.Name = "radPine";
            radPine.Size = new Size(72, 28);
            radPine.TabIndex = 0;
            radPine.TabStop = true;
            radPine.Text = "Pine";
            radPine.UseVisualStyleBackColor = true;
            // 
            // gbStyle
            // 
            gbStyle.BackColor = Color.LightSkyBlue;
            gbStyle.Controls.Add(radEclectic);
            gbStyle.Controls.Add(radVintage);
            gbStyle.Controls.Add(radAntique);
            gbStyle.Controls.Add(radModern);
            gbStyle.Controls.Add(radSimple);
            gbStyle.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            gbStyle.Location = new Point(673, 364);
            gbStyle.Name = "gbStyle";
            gbStyle.Size = new Size(214, 408);
            gbStyle.TabIndex = 6;
            gbStyle.TabStop = false;
            gbStyle.Text = "Style";
            // 
            // radEclectic
            // 
            radEclectic.AutoSize = true;
            radEclectic.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radEclectic.Location = new Point(39, 348);
            radEclectic.Name = "radEclectic";
            radEclectic.Size = new Size(107, 28);
            radEclectic.TabIndex = 9;
            radEclectic.TabStop = true;
            radEclectic.Text = "Eclectic";
            radEclectic.UseVisualStyleBackColor = true;
            // 
            // radVintage
            // 
            radVintage.AutoSize = true;
            radVintage.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radVintage.Location = new Point(39, 266);
            radVintage.Name = "radVintage";
            radVintage.Size = new Size(103, 28);
            radVintage.TabIndex = 8;
            radVintage.TabStop = true;
            radVintage.Text = "Vintage";
            radVintage.UseVisualStyleBackColor = true;
            // 
            // radAntique
            // 
            radAntique.AutoSize = true;
            radAntique.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radAntique.Location = new Point(39, 182);
            radAntique.Name = "radAntique";
            radAntique.Size = new Size(106, 28);
            radAntique.TabIndex = 7;
            radAntique.TabStop = true;
            radAntique.Text = "Antique";
            radAntique.UseVisualStyleBackColor = true;
            // 
            // radModern
            // 
            radModern.AutoSize = true;
            radModern.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radModern.Location = new Point(39, 103);
            radModern.Name = "radModern";
            radModern.Size = new Size(104, 28);
            radModern.TabIndex = 6;
            radModern.TabStop = true;
            radModern.Text = "Modern";
            radModern.UseVisualStyleBackColor = true;
            // 
            // radSimple
            // 
            radSimple.AutoSize = true;
            radSimple.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radSimple.Location = new Point(39, 33);
            radSimple.Name = "radSimple";
            radSimple.Size = new Size(96, 28);
            radSimple.TabIndex = 5;
            radSimple.TabStop = true;
            radSimple.Text = "Simple";
            radSimple.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(33, 796);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(146, 55);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // brnClear
            // 
            brnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            brnClear.Location = new Point(185, 796);
            brnClear.Name = "brnClear";
            brnClear.Size = new Size(160, 55);
            brnClear.TabIndex = 8;
            brnClear.Text = "Clear";
            brnClear.UseVisualStyleBackColor = true;
            brnClear.Click += brnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(352, 796);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 55);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.LightSkyBlue;
            lblDescription.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDescription.Location = new Point(33, 887);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(854, 51);
            lblDescription.TabIndex = 10;
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            lblCost.BackColor = Color.LightSkyBlue;
            lblCost.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblCost.Location = new Point(524, 804);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(170, 38);
            lblCost.TabIndex = 11;
            lblCost.Text = "Cost:";
            lblCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCost
            // 
            txtCost.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtCost.Location = new Point(709, 805);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(178, 38);
            txtCost.TabIndex = 12;
            txtCost.TextAlign = HorizontalAlignment.Center;
            // 
            // frmPhotos
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            CancelButton = brnClear;
            ClientSize = new Size(930, 973);
            Controls.Add(txtCost);
            Controls.Add(lblCost);
            Controls.Add(lblDescription);
            Controls.Add(btnExit);
            Controls.Add(brnClear);
            Controls.Add(btnCalculate);
            Controls.Add(gbStyle);
            Controls.Add(gbMaterial);
            Controls.Add(gbColor);
            Controls.Add(gbFrame);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Name = "frmPhotos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Photo Shop";
            gbFrame.ResumeLayout(false);
            gbFrame.PerformLayout();
            gbColor.ResumeLayout(false);
            gbColor.PerformLayout();
            gbMaterial.ResumeLayout(false);
            gbMaterial.PerformLayout();
            gbStyle.ResumeLayout(false);
            gbStyle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private GroupBox gbFrame;
        private RadioButton radFramed;
        private RadioButton radMatted;
        private RadioButton radUnframed;
        private GroupBox gbColor;
        private GroupBox gbMaterial;
        private GroupBox gbStyle;
        private RadioButton radWhite;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private RadioButton radBlack;
        private Button btnCalculate;
        private Button brnClear;
        private Button btnExit;
        private Label lblDescription;
        private Label lblCost;
        private TextBox txtCost;
        private RadioButton radGold;
        private RadioButton radSilver;
        private RadioButton radSteel;
        private RadioButton radOak;
        private RadioButton radPine;
        private RadioButton radEclectic;
        private RadioButton radVintage;
        private RadioButton radAntique;
        private RadioButton radModern;
        private RadioButton radSimple;
    }
}
