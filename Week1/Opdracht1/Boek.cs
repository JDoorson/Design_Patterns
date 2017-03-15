using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Boek : BoekHandelItem
    {
        public string Auteur { get; set; }
        
        public Boek(string titel, float prijs, int aantal, string auteur)
            : base(titel, prijs, aantal)
        {
            this.Auteur = auteur;
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + "Auteur: " + Auteur);
        }
    }
}
