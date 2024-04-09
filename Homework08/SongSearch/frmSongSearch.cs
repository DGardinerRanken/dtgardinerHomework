using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SongLibrary;
using System.Linq;
using System.Drawing;

namespace SongSearch
{
    public partial class frmSongSearch : Form
    {
        //Declare and Initialize program constants
        const string NOTHINGINPUTTED = "No Value Was Inputted.";
        const string NOSONGTITLEFOUND = "No Matching Song Title Found";
        const string NOSONGARTISTFOUND = "No Matching Song Artist Found";
        const string NOSONGGENREFOUND = "No Matching Song Genre Found";

        //Declare and Initialize class variable
        static List<Song> songs = SongManager.LoadData();
        public frmSongSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DecideWhichFunctionToCall();
        }

        private void DecideWhichFunctionToCall()
        {
            int option = ddlSongSearch.SelectedIndex;
            switch (option)
            {
                case -1 : //No option selected
                    ShowErrorMessage("You must select an option", "NO SELECTION MADE IN DROP DOWN LIST");
                    ddlSongSearch.Focus();
                    return;

                case 0 :
                    ShowSongListByTitleAscending();
                    break;
                case 1:
                    ShowSongListByArtistAscending();
                    break;
                case 2:
                    ShowSongListByGenreAscending();
                    break;
                case 3:
                    ShowSongListByTitleCriteria();
                    break;
                case 4:
                    ShowSongListByArtistCriteria();
                    break;
                case 5:
                    ShowSongListByGenreCriteria();
                    break;

                default:
                    break; 
            }
        }

        private void ShowSongListByTitleAscending()
        {
            lvSongSearch.Items.Clear();

            var titlesAscending = 
                from s in songs
                orderby s.SongTitle ascending
                select s;

            lblTitle.Text = "Song List In Ascending Order by Song Title";

            //Iterate through Song list
            foreach (var s in titlesAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByArtistAscending()
        {
            lvSongSearch.Items.Clear();

            var artistAscending =
                from s in songs
                orderby s.SongArtist ascending, s.SongTitle ascending
                select s;

            

            lblTitle.Text = "Song List In Ascending Order by Song Artist";

            //Iterate through Song list and print out matching songs
            foreach (var s in artistAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByGenreAscending()
        {
            lvSongSearch.Items.Clear();

            var genreAscending =
                from s in songs
                orderby s.SongGenre, s.SongArtist ascending, s.SongTitle ascending
                select s;

            lblTitle.Text = "Song List In Ascending Order by Song Genre";

            //Iterate through Song list
            foreach (var s in genreAscending)
            {
                ListViewItem lvItem = new ListViewItem(s.SongTitle);
                lvItem.SubItems.Add(s.SongArtist);
                lvItem.SubItems.Add(s.SongGenre);
                lvSongSearch.Items.Add(lvItem);
            }
        }

        private void ShowSongListByTitleCriteria()
        {
            lvSongSearch.Items.Clear();

            string title = Interaction.InputBox("Enter a song title to search for (full or partial): ");

            if (title.Trim() == string.Empty) //No search criteria
            {
                lvSongSearch.Items.Add(NOTHINGINPUTTED);
            }
            else //Was search criteria
            {
                var songTitles =
                    from s in songs
                    orderby s.SongTitle ascending
                    where s.SongTitle.ToUpper().Contains(title.ToUpper())
                    select s;

                //Check for no songs matching the criteria
                if (songTitles.Count() < 1)
                {
                    ShowErrorMessage(NOSONGTITLEFOUND, "NO OUTPUT");
                    return;
                }

                //There was atleast one song matching the criteria

                lblTitle.Text = "Song Titles Matching Search Criteria:";

                //Iterate through Song list
                foreach (var s in songTitles)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void ShowSongListByArtistCriteria()
        {
            lvSongSearch.Items.Clear();

            string artist = Interaction.InputBox("Enter a song artist to search for (full or partial): ");

            if (artist.Trim() == string.Empty) //No search criteria
            {
                lvSongSearch.Items.Add(NOTHINGINPUTTED);
            }
            else //Was search criteria
            {
                var songArtists =
                    from s in songs
                    orderby s.SongArtist, s.SongTitle ascending
                    where s.SongArtist.ToUpper().Contains(artist.ToUpper())
                    select s;

                //Check for no songs matching the criteria
                if (songArtists.Count() < 1)
                {
                    ShowErrorMessage(NOSONGARTISTFOUND, "NO OUTPUT");
                    return;
                }

                //There was atleast one song matching the criteria

                lblTitle.Text = "Song Artist Matching Search Criteria:";

                //Iterate through Song list
                foreach (var s in songArtists)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void ShowSongListByGenreCriteria()
        {
            lvSongSearch.Items.Clear();

            string genre = Interaction.InputBox("Enter a song genre to search for (full or partial): ");

            if (genre.Trim() == string.Empty) //No search criteria
            {
                lvSongSearch.Items.Add(NOTHINGINPUTTED);
            }
            else //Was search criteria
            {
                var songGenres =
                    from s in songs
                    orderby s.SongGenre, s.SongArtist, s.SongTitle ascending
                    where s.SongGenre.ToUpper().Contains(genre.ToUpper())
                    select s;

                //Check for no songs matching the criteria
                if (songGenres.Count() < 1)
                {
                    ShowErrorMessage(NOSONGGENREFOUND, "NO OUTPUT");
                    return;
                }

                //There was atleast one song matching the criteria

                lblTitle.Text = "Song Genres Matching Search Criteria:";

                //Iterate through Song list
                foreach (var s in songGenres)
                {
                    ListViewItem lvItem = new ListViewItem(s.SongTitle);
                    lvItem.SubItems.Add(s.SongArtist);
                    lvItem.SubItems.Add(s.SongGenre);
                    lvSongSearch.Items.Add(lvItem);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            lvSongSearch.Items.Clear();
            ddlSongSearch.SelectedIndex = -1;
            ddlSongSearch.Focus();
            lblTitle.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Are You Sure You Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void frmSongSearch_Load(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
