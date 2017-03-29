using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class ComputerShop
    {
        private IMachineFactory factory;

        public ComputerShop(IMachineFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleMachine()
        {
            IProcessor p = factory.CreateProcessor();
            IHardDisk hd = factory.CreateHardDisk();
            IMonitor m = factory.CreateMonitor();

            p.PerformOperation();
            hd.StoreData();
            m.Display();
        }
    }
}
