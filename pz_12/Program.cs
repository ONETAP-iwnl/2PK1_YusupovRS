using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            SortInc3(A, B, C);
        }


        static void SortInc3(double A, double B, double C)
        {
            double[] array = { A, B, C };
            Array.Sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
