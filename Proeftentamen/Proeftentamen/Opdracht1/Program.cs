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
            IDoorbladeraar boek = new Boek(362);

            while (!boek.LaatstePagina())
            {
                boek.VolgendePagina();
                if (boek.HuidigePagina % 10 == 0)
                    Console.WriteLine("huidige pagina: {0}", boek.HuidigePagina);
            }

            Console.ReadKey();
        }
    }
}
