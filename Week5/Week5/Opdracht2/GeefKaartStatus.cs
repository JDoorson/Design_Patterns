using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class GeefKaartStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public GeefKaartStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void GeldOpvragen(int bedrag)
        {

        }

        public void KaartInvoeren()
        {
            Console.WriteLine("Geef uw pincode a.u.b.");
            automaat.ZetAutomaatStatus(automaat.GeeftKaartAanwezigStatus());

            Console.WriteLine("");
        }

        public void KaartUitwerpen()
        {

        }

        public void PincodeInvoeren(int pincode)
        {

        }

        public void ZetBedragInAutomaat(int bedrag)
        {

        }
    }
}
