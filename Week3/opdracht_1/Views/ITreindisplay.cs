using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1.Views
{
    public interface ITreinDisplay 
    {
        void Update(string huidigStation, string huidigSpoor, DateTime aankomstTijd, DateTime vertrekTijd);
    }
}
