using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak een zonnepaneel systeem aan
            ZonnepaneelSysteem systeem = new ZonnepaneelSysteem();

            // maak een display voor het systeem aan
            ZonneDisplay display = new ZonneDisplay(systeem);

            // doe een aantal metingen
            for (int i = 0; i < 10; i++)
                systeem.NieuweMeting();

            Console.ReadKey();
        }
    }
}
