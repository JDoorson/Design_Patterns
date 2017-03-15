using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    interface IDoorbladeraar
    {
        int HuidigePagina { get; }
        void VolgendePagina();
        void VorigePagina();
        bool EerstePagina();
        bool LaatstePagina();
    }
}
