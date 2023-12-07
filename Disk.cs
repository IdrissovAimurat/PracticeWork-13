using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork13
{
    class Disk
    {
        public string Artist { get; set; }
        public List<string> Songs { get; set; }

        public Disk(string artist)
        {
            Artist = artist;
            Songs = new List<string>();
        }

        public void AddSong(string song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(string song)
        {
            Songs.Remove(song);
        }

        public override string ToString()
        {
            return $"Исполнитель: {Artist}, Песни: {string.Join(", ", Songs)}";
        }
    }
}
