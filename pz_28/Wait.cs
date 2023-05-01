using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Wait
    {
        public void Waiting(Counter counter, int chislo)
        {
            counter.CounterChanged += (sender, e) =>
            {
                if (e == chislo)
                {
                    Console.WriteLine($"Число {chislo}");
                }
            };
        }
    }
}
