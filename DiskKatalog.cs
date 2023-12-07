using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork13
{
    class DiskKatalog
    {
        private Hashtable catalog = new Hashtable();

        public void AddCD(string title, Disk cd)
        {
            catalog[title] = cd;
        }

        public void RemoveCD(string title)
        {
            catalog.Remove(title);
        }

        public void PrintCatalog()
        {
            foreach (DictionaryEntry entry in catalog)
            {
                Console.WriteLine($"CD: {entry.Key}, {entry.Value}");
            }
        }

        public void PrintCD(string title)
        {
            if (catalog.ContainsKey(title))
            {
                Console.WriteLine($"CD: {title}, {catalog[title]}");
            }
        }

        public void SearchByArtist(string artist)
        {
            foreach (DictionaryEntry entry in catalog)
            {
                Disk cd = (Disk)entry.Value;
                if (cd.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Найден CD: {entry.Key}, {cd}");
                }
            }
        }
    }
}
