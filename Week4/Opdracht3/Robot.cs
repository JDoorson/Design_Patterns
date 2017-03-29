using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Robot
    {
        public void BeweegViaPersoon(string naam)
        {
            Console.WriteLine("Robot beweegt via {0}", naam);
        }

        public void BeukMetHanden()
        {
            Console.WriteLine("Robot veroorzaakt 8 schade met zijn handen");
        }

        public void LoopNaarVoren()
        {
            Console.WriteLine("Robot loopt 3 posities naar voren");
        }

    }
}
