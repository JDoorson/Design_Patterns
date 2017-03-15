using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Potlood : IPotlood
    {
        private int maxTeSchrijven;
        private int geschrevenKarakters;

        //private bool isScherp;
        private int potloodResterend;

        public bool IsScherp { get { return geschrevenKarakters < maxTeSchrijven; } }

        public Potlood(int maxTeSchrijven)
        {
            this.maxTeSchrijven = maxTeSchrijven;
            geschrevenKarakters = 0;
            this.potloodResterend = maxTeSchrijven;
           // this.isScherp = true;
        }

        public void Schrijf(string boodschap)
        {
            foreach (char c in boodschap)
            {
                if (IsScherp)
                    Console.Write(c);
                else
                    Console.Write('#');
                geschrevenKarakters++;
            }


            //for(int i = 0; i < boodschap.Length; i++)
            //{
            //    if (i < maxTeSchrijven)
            //        Console.Write(boodschap[i]);
            //    else
            //        Console.Write("#");
            //}
            int len = boodschap.Length;

            if (len <= potloodResterend)
            {
                Console.WriteLine(boodschap);
                potloodResterend -= len;
            }
            else
            {
                Console.Write(boodschap.Remove(potloodResterend));
                Console.WriteLine(new String('#', len - potloodResterend));
            }

          //  isScherp = potloodResterend < len;
        }

        public void NaGeslepen()
        {
            //potloodResterend = maxTeSchrijven;
            //   isScherp = true;
            geschrevenKarakters = 0;
        }
    }
}
