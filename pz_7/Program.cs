using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] newarr = new int[10];
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = r.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                newarr[i] = arr[i] + 2;
                Console.Write(newarr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
