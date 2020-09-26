using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Music_Collection
{
    public class Album
    {
        public Album(string albumname, DateTime year, string artist)
        {
            AlbumName = albumname;

            Year = year;

            Artist = artist;
        }

        public Album()
        {
            AlbumName = "";
            Year = DateTime.Now;
            Artist = "";
        }

        public string AlbumName { get; set; }

        public DateTime Year { get; set; }

        public string Artist { get; set; }
    }

   

}
