using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Tank : IAanvaller
    {
        public void GebruikWapen()
        {
            Console.WriteLine("Tank veroorzaakt 8 schade");
        }

        public void KoppelBestuurder(string naam)
        {
            Console.WriteLine("{0} bestuurt de tank", naam);
        }

        public void RijNaarVoren()
        {
            Console.WriteLine("Tank beweegt 3 posities naar voren");
        }
    }
}
