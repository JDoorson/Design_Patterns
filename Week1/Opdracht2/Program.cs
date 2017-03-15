using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            IVliegbaar s = new Superman();
            IVliegbaar v = new Vliegtuig();

            MaakVlucht(s);
            MaakVlucht(v);


            Console.ReadLine();
        }

        static void MaakVlucht(IVliegbaar o)
        {
            o.Opstijgen();
            o.Vliegen();
            o.Vliegen();
            o.Vliegen();
            o.Landen();
            Console.WriteLine();
        }
    }
}
