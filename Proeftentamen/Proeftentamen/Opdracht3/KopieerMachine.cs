using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class KopieerMachine
    {
        private int aantalKopies;
        public static KopieerMachine uniqueInstance;

        public int AantalKopies { get; }

        private KopieerMachine()
        { }

        public static KopieerMachine GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new KopieerMachine();
            return uniqueInstance;
        }

        public void Kopieer()
        {
            aantalKopies++;
        }
    }
}
