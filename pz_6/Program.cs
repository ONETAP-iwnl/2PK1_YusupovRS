using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int a1 = 0;
            int a2 = 1;
            int n = 1;
            int sum;
            int res = -1;
            while (a1 <= a)
            {
                sum = a1 + a2;
                a1 = a2;
                a2 = sum;
                n += 1;
                if (a1 == a)
                {
                    res = n;

                }
                else if (a == 0)
                {
                    res = 0;
                    Console.WriteLine(res);
                }
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
