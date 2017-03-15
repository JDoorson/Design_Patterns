using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class SimpleMP3Display : IObserver
    {
        private ISubject player;

        public SimpleMP3Display(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

        public void Update(Nummer nummer)
        {
            Console.WriteLine("Simple display: {0} - '{1}'", nummer.Artist, nummer.Title);
        }
    }
}
