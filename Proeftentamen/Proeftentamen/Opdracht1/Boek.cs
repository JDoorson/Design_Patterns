using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Boek : IDoorbladeraar
    {
        private int huidigePagina;
        private int aantalPaginas;

        public int HuidigePagina { get { return huidigePagina; } }

        public Boek(int aantalPaginas)
        {
            this.aantalPaginas = aantalPaginas;
            huidigePagina = 1;
        }

        public void VolgendePagina()
        {
            if(!LaatstePagina())
                huidigePagina++;
        }

        public void VorigePagina()
        {
            if(!EerstePagina())
                huidigePagina--;
        }

        public bool EerstePagina()
        {
            return HuidigePagina == 1;
        }

        public bool LaatstePagina()
        {
            return HuidigePagina == aantalPaginas;
        }
    }
}
