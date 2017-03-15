using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    public class Nummer
    {
        public string Artist { get; private set; }
        public string Title { get; private set; }
        public string Duration { get; private set; }
        
        public Nummer(string artist, string title, string duration)
        {
            this.Artist = artist;
            this.Title = title;
            this.Duration = duration;
        }

        public static List<Nummer> GetList()
        {
            List<Nummer> nl = new List<Nummer>();
            nl.Add(new Nummer("Pink Floyd", "Wish You Were Here", "03:12"));
            nl.Add(new Nummer("Bruno Mars", "Billionaire", "03:33"));
            nl.Add(new Nummer("Led Zeppelin", "Dazed and Confused", "04:00"));
            return nl;
        }
    }
}
