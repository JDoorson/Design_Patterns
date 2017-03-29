using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class HighBudgetProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation very quickly...");
        }
    }
}
