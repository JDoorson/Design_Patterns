using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class CD : BoekHandelItem
    {
        public string Artiest { get; set; }
        
        public CD(string titel, float prijs, int aantal, string artiest)
            : base(titel, prijs, aantal)
        {
            this.Artiest = artiest;
        }
        public override string ToString()
        {
            return String.Format(base.ToString() + "Artiest: " + Artiest);
        }
    }
}
