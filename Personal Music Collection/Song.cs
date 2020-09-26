using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Music_Collection
{
    public class Song
    {
        public Song(string title, string length,string artist,string albumtitle)
        {
            Title = title;

            Length = length;

            Artist = artist;

            AlbumTitle = albumtitle;
        }

        public Song()
        {
            Title = "";

            Length = "";

            Artist = "";

            AlbumTitle = "";
        }

        public string Title { get; set; } 
        public string Length { get; set; }
        public string Artist { get; set; }
        public string AlbumTitle { get; set; }
    }
}
