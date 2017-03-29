using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    interface IAanvaller
    {
        void KoppelBestuurder(string naam);
        void RijNaarVoren();
        void GebruikWapen();
    }
}
