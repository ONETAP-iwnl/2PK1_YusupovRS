using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 0;
            int m = 4;
            int n = 4;
            int[,] matrix = new int[m, n];
            Console.WriteLine("Сгенерированная матрица");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(2, 8);
                    Console.Write("{0,3} ", matrix[i, j].ToString());
                    if ((j > i) && (matrix[i, j] >= 0))
                    {
                        count++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество = {0}", count);
            Console.ReadKey();
        }
    }
}
