using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class BatchProcessor
    {
        private List<BigDataLoader> dataLoaders;

        public BatchProcessor()
        {
            dataLoaders = new List<BigDataLoader>();
        }

        public void Add(BigDataLoader bdl)
        {
            dataLoaders.Add(bdl);
        }

        public void Process()
        {
            if (dataLoaders.Any())
            {
                foreach (BigDataLoader bdl in dataLoaders)
                {
                    //bdl.Extract();
                    //bdl.Transform();
                    //bdl.Load();
                    bdl.ETL();

                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("No DataLoaders in list.");
        }
    }
}
