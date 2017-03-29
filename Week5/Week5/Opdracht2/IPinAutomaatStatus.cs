using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    interface IPinAutomaatStatus
    {
        void GeldOpvragen(int bedrag);
        void KaartInvoeren();
        void KaartUitwerpen();
        void PincodeInvoeren(int pincode);
        void ZetBedragInAutomaat(int bedrag);
    }
}
