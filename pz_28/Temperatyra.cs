using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Temperatyra
    {
        public event EventHandler<int> TemperatyraChanged;
        public void Temp(int t)
        {
            if (t == -25)
            {
                Console.WriteLine("Температура -25");
            }
            else if (t == 0)
            {
                Console.WriteLine("Температура 0");
            }
            else if (t == 25)
            {
                Console.WriteLine("Температура 25");
            }
            else if (t == 35)
            {
                Console.WriteLine("Температура 35");
            }
        }
    }
}
