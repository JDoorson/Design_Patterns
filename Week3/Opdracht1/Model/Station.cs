using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1.Model
{
    public class Station
    {
        public string StationNaam { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }

        public Station(string stationNaam, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            StationNaam = stationNaam;
            AankomstSpoor = aankomstSpoor;
            AankomstTijd = aankomstTijd;
            VertrekTijd = vertrekTijd;
        }
    }
}
