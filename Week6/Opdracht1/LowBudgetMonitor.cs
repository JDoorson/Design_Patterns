using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class LowBudgetMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Displaying stuff very poorly...");
        }
    }
}
