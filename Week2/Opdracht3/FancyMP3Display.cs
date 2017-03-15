using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class FancyMP3Display : IObserver
    {
        private ISubject player;

        public FancyMP3Display(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

        public void Update(Nummer nummer)
        {
            Console.WriteLine("Fancy display: '{0}', van {1} ({2})", nummer.Title, nummer.Artist, nummer.Duration);
        }
    }
}
