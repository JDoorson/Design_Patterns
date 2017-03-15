using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class BoekHandel
    {
        private List<BoekHandelItem> items;

        public BoekHandel()
        {
            items = new List<BoekHandelItem>();
        }

        public void VoegToe(BoekHandelItem item)
        {
            items.Add(item);
        }

        public void PrintOverzicht()
        {
            foreach(BoekHandelItem i in items)
            {
                Console.WriteLine(i.ToString() + "\n");
            }
        }
    }
}
