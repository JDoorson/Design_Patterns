using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class CorrectePinStatus : IPinAutomaatStatus
    {
        private PinAutomaat automaat;

        public CorrectePinStatus(PinAutomaat automaat)
        {
            this.automaat = automaat;
        }

        public void GeldOpvragen(int bedrag)
        {
            if(bedrag <= automaat.BedragInAutomaat)
            {
                automaat.BedragInAutomaat -= bedrag;
                Console.WriteLine("{0} uit de automaat gehaald.", bedrag);
                Console.WriteLine("Uw kaart is uitgeworpen");

                if (automaat.BedragInAutomaat > 0)
                    automaat.ZetAutomaatStatus(automaat.GeefGeenKaartAanwezigStatus());
                else
                    automaat.ZetAutomaatStatus(automaat.GeefGeenGeldStatus());
            }

            Console.WriteLine("");
        }

        public void KaartInvoeren()
        {

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
