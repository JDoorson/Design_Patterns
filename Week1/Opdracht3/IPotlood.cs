using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    interface IPotlood
    {
        bool IsScherp { get; }
        void Schrijf(string boodschap);
        void NaGeslepen();
    }
}
