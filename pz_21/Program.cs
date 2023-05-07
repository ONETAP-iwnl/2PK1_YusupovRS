using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer comp1 = new Computer { ID = 1, TotalHDDMemory = 512, ProcessorFrequency = 3.2 };
            Computer comp2 = new Computer { ID = 2, TotalHDDMemory = 1024, ProcessorFrequency = 2.8 };
            Computer comp3 = new Computer { ID = 3, TotalHDDMemory = 2048, ProcessorFrequency = 2.9 };
            Computer comp4 = new Computer { ID = 4, TotalHDDMemory = 4096, ProcessorFrequency = 4.8 };

            comp1.GetCompName();
            comp2.GetCompName();
            comp3.GetCompName();
            comp4.GetCompName();
            Console.ReadKey();
        }
    }
}
