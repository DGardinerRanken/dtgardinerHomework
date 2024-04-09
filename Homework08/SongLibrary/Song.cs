using System;

namespace SongLibrary
{
    public class Song
    {
        //Instance Variables
        public string SongTitle { get; set; }
        public string SongArtist { get; set; }
        public string SongGenre { get; set; }

        public override string ToString()
        {
            return "Song Title: " + SongTitle + "\n" + 
                   "Song Artist: " + SongArtist + "\n" +
                   "Song Genre: " + SongGenre + "\n";
        }
    }
}
