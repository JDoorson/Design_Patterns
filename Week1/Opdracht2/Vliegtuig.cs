using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Vliegtuig : IVliegbaar
    {
        public Vliegtuig() { }

        public void Opstijgen()
        {
            Console.WriteLine("Vliegtuig aan het opstijgen...");
        }

        public void Vliegen()
        {
            Console.WriteLine("Vliegtuig aan het vliegen...");
        }

        public void Landen()
        {
            Console.WriteLine("Vliegtuig aan het landen...");
        }
    }
}
