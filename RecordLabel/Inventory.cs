using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordLabel
{
    public class Inventory
    {
        public List<Album> Albums { get; private set; }

        public Inventory()
        {
            Albums = new List<Album>();
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }
        
        public List<string> AllSongs()
        {
            var allSongs = new List<string>();

            foreach (Album album in Albums)
            {
                //foreach (string song in album.Songs())
                //{
                //    allSongs.Add(song);
                //}
                allSongs.AddRange(album.Songs());
            }

            return allSongs;
        }
    }
}
