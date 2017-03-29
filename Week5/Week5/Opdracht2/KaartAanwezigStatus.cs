using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class KaartAanwezigStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public KaartAanwezigStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void GeldOpvragen(int bedrag)
        {

        }

        public void KaartInvoeren()
        {
            
        }

        public void KaartUitwerpen()
        {
            Console.WriteLine("Uw kaart is uitgeworpen.");
            automaat.ZetAutomaatStatus(automaat.GeefGeenKaartAanwezigStatus());

            Console.WriteLine("");
        }

        public void PincodeInvoeren(int pincode)
        {
            if (pincode == 1234)
            {
                Console.WriteLine("U heeft de correcte pincode ingevoerd.");
                automaat.ZetAutomaatStatus(automaat.GeefCorrectePinStatus());
            }

            Console.WriteLine("");
        }

        public void ZetBedragInAutomaat(int bedrag)
        {

        }
    }
}
