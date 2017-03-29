using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class MainSystem
    {
        private Logger logger = Logger.GetInstance();
        private SubSystem ss = new SubSystem();

        public MainSystem()
        { }

        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
            ss.DoSomeWork();
            ss.DoSomeMoreWork();
        }
    }
}
