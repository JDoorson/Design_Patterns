using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class HighBudgetMachine : IMachineFactory
    {
        public IProcessor CreateProcessor()
        {
            return new HighBudgetProcessor();
        }

        public IHardDisk CreateHardDisk()
        {
            return new HighBudgetHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new HighBudgetMonitor();
        }
    }
}
