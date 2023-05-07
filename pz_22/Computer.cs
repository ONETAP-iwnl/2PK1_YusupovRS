using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Computer
    {
        private static int totalMemory = 0;
        private static int countHighFrequency = 0;

        public int ID { get; set; }

        private int _totalHDDMemory;
        public int TotalHDDMemory
        {
            get { return _totalHDDMemory; }
            set
            {
                if (value >= 0)
                {
                    totalMemory -= _totalHDDMemory;
                    _totalHDDMemory = value;
                    totalMemory += _totalHDDMemory;
                }
            }
        }

        private double _processorFrequency;
        public double ProcessorFrequency
        {
            get { return _processorFrequency; }
            set
            {
                if (value >= 1.5 && value <= 5.0)
                {
                    if (_processorFrequency > value)
                    {
                        countHighFrequency--;
                    }
                    else if (_processorFrequency < value)
                    {
                        countHighFrequency++;
                    }
                    _processorFrequency = value;
                }
            }
        }

        public static int TotalMemory
        {
            get { return totalMemory; }
        }

        public static int CountHighFrequency
        {
            get { return countHighFrequency; }
        }

        public void GetCompName()
        {
            Console.WriteLine( $"Айди: {ID}\nПамять: {TotalHDDMemory} ГБ\nЧастота процессора: {ProcessorFrequency} Мгц");
        }
    }
}
