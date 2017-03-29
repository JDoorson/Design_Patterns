using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Logger
    {
        private int numberOfLines;
        private static Logger uniqueInstance;

        private Logger()
        {
            numberOfLines = 1;
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger();
            return uniqueInstance;
        }

        public void Log(string currentClass, string action)
        {
            Console.WriteLine("{0} - [{1}] {2}", numberOfLines, currentClass, action);
        }
    }
}
