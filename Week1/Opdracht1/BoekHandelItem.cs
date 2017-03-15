using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class BoekHandelItem
    {
        public string Titel { get; set; }
        public float Prijs { get; set; }
        public int Aantal { get; set; }

        public BoekHandelItem(string titel, float prijs, int aantal)
        {
            this.Titel = titel;
            this.Prijs = prijs;
            this.Aantal = aantal;
        }

        public override string ToString()
        {
            return String.Format("Titel: {0}\nPrijs: ${1}\nAantal: {2}\n", Titel, Prijs, Aantal);
        }
    }
}
