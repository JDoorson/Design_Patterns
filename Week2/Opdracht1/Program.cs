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
            BatchProcessor bp = new BatchProcessor();
            bp.Add(new CallDataLoader());
            bp.Add(new TwitterDataLoader());
            bp.Add(new SensorDataLoader());
            bp.Process();

            Console.ReadKey();
        }
    }
}
