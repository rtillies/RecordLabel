using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLabel
{
    public class Album
    {
        public string Artist { get; }
        public string Title { get; }
        public List<string> SideASongs { get; private set; }
        public List<string> SideBSongs { get; private set; }

        public Album(string artist, string title)
        {
            Artist = artist;
            Title = title;
            SideASongs = new List<string>();
            SideBSongs = new List<string>();
        }

        public void AddSong(string song)
        {
            if (SideASongs.Count < 5)
            {
                SideASongs.Add(song);
            }
            else if (SideBSongs.Count < 5)
            {
                SideBSongs.Add(song);
            }
        }

        public List<string> Songs()
        {
            var allSongs = new List<string>();
            allSongs.AddRange(SideASongs);
            allSongs.AddRange(SideBSongs);
            return allSongs;
        }
    }
}
