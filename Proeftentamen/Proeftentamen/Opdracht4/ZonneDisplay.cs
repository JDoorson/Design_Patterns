using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class ZonneDisplay : IObserver
    {
        private ZonnepaneelSysteem systeem;

        public ZonneDisplay(ZonnepaneelSysteem systeem)
        {
            this.systeem = systeem;
            systeem.RegisterObserver(this);
        }

        public void Update(int wattage)
        {
            Console.WriteLine("nieuwe meting: {0} Watt", wattage);
        }
    }
}
