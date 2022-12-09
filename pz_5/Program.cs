using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //for (int i = 0; i <= 15; i +=1)
            //{
            //    Console.WriteLine(i);   
            //}
            //Console.ReadKey();

            //задание 2
            //char f = 'о';
            //for(int i = 0; i <= 6; i++)
            //{
            //    Console.Write(f);
            //    f++;
            //}
            //Console.ReadKey();

            //задание 3
            //for (var i = 0; i < 10; i++)
            //{
            //    for (var j = 0; j < 5; j++)
            //    {
            //        Console.Write('#');
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //задание 4
            //for(int i = 0; i <= 100; i++)
            //{
            //    if(i % 16 == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }    
            //}
            //Console.ReadKey();

            //задание 5

            for (int i = 0, j = 30; i - j != 8; i++, j--)
            {
                Console.WriteLine(i + "     " + j);
            }
            Console.ReadKey();
        }
    }
}
