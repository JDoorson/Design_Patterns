using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class SubSystem
    {
        private Logger logger = Logger.GetInstance();

        public SubSystem()
        { }

        public void DoSomeWork()
        {
            logger.Log("SubSystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            logger.Log("SubSystem", "doing some more work");
        }
    }
}
