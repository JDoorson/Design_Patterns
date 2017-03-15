using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            BoekHandel handel = new BoekHandel();
            Boek b = new Boek("Goed boek", 12.34f, 5, "Die ene auteur");
            Weekblad wb = new Weekblad("Geweldig weekblad", 9.99f, 10, "10-11-16");
            CD cd = new CD("Best seller", 4.20f, 24, "Trump");

            handel.VoegToe(b);
            handel.VoegToe(wb);
            handel.VoegToe(cd);
            handel.PrintOverzicht();

            Console.ReadKey();
        }
    }
}
