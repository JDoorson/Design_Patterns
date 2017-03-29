using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1.Models
{
    class Station
    {
        public string station { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }
        public Station(string station, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            this.station = station;
            AankomstSpoor = aankomstSpoor;
            AankomstTijd = aankomstTijd;
            VertrekTijd = vertrekTijd;
        }
    }
}
