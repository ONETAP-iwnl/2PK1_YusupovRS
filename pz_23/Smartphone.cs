using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Smartphone: Computer
    {
        public double Diagonal { get; set; }
        public string Diapazon { get; set; }

        public new void GetCompName()
        {
             Console.WriteLine($"Айди: {ID}, Память: {TotalHDDMemory} ГБ, Частота процессора: {ProcessorFrequency} Мгц, Диагональ: {Diagonal}, Диапозон: {Diapazon}");
        }
    }
}

