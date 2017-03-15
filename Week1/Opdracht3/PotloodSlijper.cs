using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class PotloodSlijper : IPotloodSlijper
    {
        public PotloodSlijper()
        {

        }

        public void Slijp(IPotlood p)
        {
            p.NaGeslepen();
        }
    }
}
