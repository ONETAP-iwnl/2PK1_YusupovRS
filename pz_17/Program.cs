using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            unsafe
            {
                fixed (int* ptr = array)
                {
                    int sum = array.Sum();
                    Console.WriteLine(sum);
                }

            }
            Console.ReadKey();
        }
    }
}
