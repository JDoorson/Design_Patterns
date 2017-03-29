using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class RobotAdapter : IAanvaller
    {
        private Robot evilRobot;

        public RobotAdapter(Robot evilRobot)
        {
            this.evilRobot = evilRobot;
        }

        public void GebruikWapen()
        {
            evilRobot.BeukMetHanden();
        }

        public void KoppelBestuurder(string naam)
        {
            evilRobot.BeweegViaPersoon(naam);
        }

        public void RijNaarVoren()
        {
            evilRobot.LoopNaarVoren();
        }
    }   
}
