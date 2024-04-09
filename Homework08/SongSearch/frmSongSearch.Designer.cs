namespace SongSearch
{
    partial class frmSongSearch
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ddlSongSearch = new System.Windows.Forms.ComboBox();
            this.lvSongSearch = new System.Windows.Forms.ListView();
            this.songTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(51, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(656, 37);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddlSongSearch
            // 
            this.ddlSongSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSongSearch.FormattingEnabled = true;
            this.ddlSongSearch.Items.AddRange(new object[] {
            "Show SongList By Title Ascending",
            "Show SongList By Artist Ascending",
            "Show SongList By Genre Ascending",
            "Show SongList By Title Criteria",
            "Show SongList By Artist Criteria",
            "Show SongList By Genre Criteria"});
            this.ddlSongSearch.Location = new System.Drawing.Point(738, 27);
            this.ddlSongSearch.Name = "ddlSongSearch";
            this.ddlSongSearch.Size = new System.Drawing.Size(397, 39);
            this.ddlSongSearch.TabIndex = 0;
            // 
            // lvSongSearch
            // 
            this.lvSongSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songTitle,
            this.songArtist,
            this.songGenre});
            this.lvSongSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSongSearch.HideSelection = false;
            this.lvSongSearch.Location = new System.Drawing.Point(57, 80);
            this.lvSongSearch.Name = "lvSongSearch";
            this.lvSongSearch.Size = new System.Drawing.Size(750, 565);
            this.lvSongSearch.TabIndex = 4;
            this.lvSongSearch.UseCompatibleStateImageBehavior = false;
            this.lvSongSearch.View = System.Windows.Forms.View.Details;
            // 
            // songTitle
            // 
            this.songTitle.Text = "Song Title";
            this.songTitle.Width = 250;
            // 
            // songArtist
            // 
            this.songArtist.Text = "Song Artist";
            this.songArtist.Width = 250;
            // 
            // songGenre
            // 
            this.songGenre.Text = "Song Genre";
            this.songGenre.Width = 250;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(833, 357);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(314, 71);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(833, 464);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(314, 71);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(833, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(314, 71);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSongSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1176, 677);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lvSongSearch);
            this.Controls.Add(this.ddlSongSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSongSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 18 LINQ Problem #1 - Song Search";
            this.Load += new System.EventHandler(this.frmSongSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox ddlSongSearch;
        private System.Windows.Forms.ListView lvSongSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader songTitle;
        private System.Windows.Forms.ColumnHeader songArtist;
        private System.Windows.Forms.ColumnHeader songGenre;
    }
}

