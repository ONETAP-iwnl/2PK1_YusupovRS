using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 8, 27, 64, 125, 216 };
            Console.WriteLine("Количество элементов из которых можно извлечь куб: " + CubeRootCount(numbers));
            Console.ReadKey();
        }

        static int CubeRootCount(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                int cubeRoot = (int)Math.Pow(number, 1.0 / 3.0);
                if (cubeRoot * cubeRoot * cubeRoot == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
