using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1.Model
{
    class TreinReis : Controller.ITreinReis
    {
        private List<Station> stations;
        private int huidigStation;

        public TreinReis()
        {
            stations = new List<Station>();
            // todo: voeg (hardcoded) Stations toe..
            stations.Add(new Station("Heemskerk", 1, new DateTime(2016, 11, 21, 12, 43, 0), )
            huidigStation = 0;
        }
    }
}
