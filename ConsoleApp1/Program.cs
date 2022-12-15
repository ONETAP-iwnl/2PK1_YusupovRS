using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа через пробел: длина и ширина стола");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');

            double length = Convert.ToDouble(splitString[0]); // длина
            double width = Convert.ToDouble(splitString[1]); // ширина

            //Тут будет Ваш код
            double pl = length + 0.2;
            double plii = width + 0.2;

        Console.WriteLine($"Площадь стола: " + pl * plii);
        }
    }
}
