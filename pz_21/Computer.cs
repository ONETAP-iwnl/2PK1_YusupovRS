using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Computer
    {
        public int ID { get; set; }
        public int TotalHDDMemory { get; set; }
        public double ProcessorFrequency { get; set; }

        public void GetCompName()
        {
            Console.WriteLine($"Айди: {ID}\nПамять: {TotalHDDMemory} ГБ\nЧастота процессора: {ProcessorFrequency} Мгц");
        }

    }
}
