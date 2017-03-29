using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class GeenGeldStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public GeenGeldStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void GeldOpvragen(int bedrag)
        {

        }

        public void KaartInvoeren()
        {
            Console.WriteLine("Geen geld aanwezig in de automaat.");
            Console.WriteLine("Uw kaart is uitgeworpen.");

            Console.WriteLine("");
        }

        public void KaartUitwerpen()
        {

        }

        public void PincodeInvoeren(int pincode)
        {
            Console.WriteLine("Geen geld aanwezig in de automaat.");

            Console.WriteLine();
        }

        public void ZetBedragInAutomaat(int bedrag)
        {

        }
    }
}
