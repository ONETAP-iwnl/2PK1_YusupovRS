using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Event
    {
        private int t = -30;
        private int step = 1;

        public event Action<int> TemperatureChanged;

        public void Start()
        {
            while (t <= 40)
            {
                t += step;
                TemperatureChanged?.Invoke(t);
            }
        }
    }
}
