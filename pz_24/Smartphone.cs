using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Smartphone: Computer, IClonable
    {
        public double Diagonal { get; set; }
        public string Diapazon { get; set; }

        public new void GetCompName()
        {
            Console.WriteLine($"Айди: {ID}, Память: {TotalHDDMemory} ГБ, Частота процессора: {ProcessorFrequency} Мгц, Диагональ: {Diagonal}, Диапозон: {Diapazon}");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
