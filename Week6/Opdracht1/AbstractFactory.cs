using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class AbstractFactory
    {
        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHardDisk();
        public abstract IMonitor CreateMonitor();
    }
}
