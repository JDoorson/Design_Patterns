﻿using System;
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
