using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainSystem ms = new MainSystem();
            Logger logger = Logger.GetInstance();

            logger.Log("main", "starting");
            ms.DoSomeMainWork();
            logger.Log("main", "finished");

            Console.ReadKey();
        }
    }
}
