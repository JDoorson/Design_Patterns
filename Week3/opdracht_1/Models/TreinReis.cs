using Opdracht1.Views;
using Opdracht1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1.Models
{
    class TreinReis : ITreinReis
    {
        private List<Station> stations;
        private int huidigStation;
        private string huidigSpoor;
        private List<ITreinDisplay> displays = new List<ITreinDisplay>();

        public TreinReis()
        {
            stations = new List<Station>();

            stations.Add(new Station("Heemskerk", "2", DateTime.Parse("8:40"), DateTime.Parse("8:41")));
            stations.Add(new Station("Beverwijk", "2", DateTime.Parse("8:44"), DateTime.Parse("8:45")));
            stations.Add(new Station("Driehuis", "2", DateTime.Parse("8:50"), DateTime.Parse("8:51")));
            stations.Add(new Station("Santpoort Noord", "1", DateTime.Parse("8:54"), DateTime.Parse("8:55")));
            stations.Add(new Station("Santpoort Zuid", "1", DateTime.Parse("8:56"), DateTime.Parse("8:57")));
            stations.Add(new Station("Bloemendaal", "1", DateTime.Parse("9:00"), DateTime.Parse("9:01")));
            stations.Add(new Station("Haarlem", "8", DateTime.Parse("9:05"), DateTime.Parse("9:06")));

            huidigStation = 0;
        }

        public void Add(ITreinDisplay display)
        {
            displays.Add(display);
        }

        public void Remove(ITreinDisplay display)
        {
            displays.Remove(display);
        }
        
        public bool VolgendStation(bool richtingZuid)
        {
            if (richtingZuid)
            {
                huidigStation++;
            }
            else
            {
                huidigStation--;
            }

            NotifyObservers();

            return (huidigStation == stations.Count() - 1 || huidigStation == 0);
        }
        public void NotifyObservers()
        {
            string station = stations[huidigStation].station;
            huidigSpoor = stations[huidigStation].AankomstSpoor;
            DateTime aankomstTijd = stations[huidigStation].AankomstTijd;
            DateTime vertrekTijd = stations[huidigStation].VertrekTijd;

            foreach (ITreinDisplay d in this.displays)
            {
                d.Update(station, huidigSpoor, aankomstTijd, vertrekTijd);
            }

        }
    }
}
