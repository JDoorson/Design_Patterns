using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class PinAutomaat
    {
        private IPinAutomaatStatus correctePinCodeIngevoerd;
        private IPinAutomaatStatus geenGeldAanwezig;
        private IPinAutomaatStatus kaartAanwezig;
        private IPinAutomaatStatus kaartNietAanwezig;

        private IPinAutomaatStatus automaatStatus;
        public int BedragInAutomaat { get; set; }

        public PinAutomaat(int beginBedrag)
        {
            correctePinCodeIngevoerd = new CorrectePinStatus(this);
            geenGeldAanwezig = new GeenGeldStatus(this);
            kaartAanwezig = new KaartAanwezigStatus(this);
            kaartNietAanwezig = new GeefKaartStatus(this);

            BedragInAutomaat = beginBedrag;
            automaatStatus = kaartNietAanwezig;
        }

        public IPinAutomaatStatus GeefCorrectePinStatus()
        {
            return correctePinCodeIngevoerd;
        }

        public IPinAutomaatStatus GeefGeenGeldStatus()
        {
            return geenGeldAanwezig;
        }

        public IPinAutomaatStatus GeefGeenKaartAanwezigStatus()
        {
            return kaartNietAanwezig;
        }

        public IPinAutomaatStatus GeeftKaartAanwezigStatus()
        {
            return kaartAanwezig;
        }

        public void GeldOpvragen(int bedrag)
        {
            automaatStatus.GeldOpvragen(bedrag);
        }

        public void KaartInvoeren()
        {
            automaatStatus.KaartInvoeren();
        }

        public void KaartUitwerpen()
        {
            automaatStatus.KaartUitwerpen();
        }

        public void PincodeInvoeren(int code)
        {
            automaatStatus.PincodeInvoeren(code);
        }

        public void ZetAutomaatStatus(IPinAutomaatStatus nieuweStatus)
        {
            automaatStatus = nieuweStatus;
        }

        public void ZetBedragInAutomaat(int bedrag)
        {
            automaatStatus.ZetBedragInAutomaat(bedrag);
        }
    }
}
