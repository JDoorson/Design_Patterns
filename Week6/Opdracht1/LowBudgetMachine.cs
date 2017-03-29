using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class LowBudgetMachine : IMachineFactory
    {
        public IProcessor CreateProcessor()
        {
            return new LowBudgetProcessor();
        }

        public IHardDisk CreateHardDisk()
        {
            return new LowBudgetHardDisk();
        }

        public IMonitor CreateMonitor()
        {
            return new LowBudgetMonitor();
        }
    }
}
