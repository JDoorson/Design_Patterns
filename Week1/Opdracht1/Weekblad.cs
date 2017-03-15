using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Weekblad : BoekHandelItem
    {
        public string UitgifteDag { get; set; }

        public Weekblad(string titel, float prijs, int aantal, string uitgifteDag)
            : base(titel, prijs, aantal)
        {
            this.UitgifteDag = uitgifteDag;
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + "Dag uitgite: " + UitgifteDag);
        }
    }
}
