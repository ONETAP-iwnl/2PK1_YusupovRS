using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Counter
    {
        public event EventHandler<int> CounterChanged;
        public void Count()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i == 200)
                {
                    CounterChanged?.Invoke(this, i);
                }
                else if (i == 800)
                {
                    CounterChanged?.Invoke(this, i);
                }
            }
        }
    }
}
