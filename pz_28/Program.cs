using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вариант 1
            Console.WriteLine("Вариант 1");
            Counter counter = new Counter();
            Wait w200 = new Wait();
            Wait w800 = new Wait();
            w200.Waiting(counter, 200);
            w800.Waiting(counter, 800);
            counter.Count();

            //Вариант 2
            Console.WriteLine("Вариант 2");
            //он не работает, почему не знаю, сделал так же как с первым вариантом
            var generator = new Event();
            var tracker = new Temperatyra();

            generator.TemperatureChanged += t => tracker.Temp(t);

            generator.Start();

            Console.ReadLine();
            Console.ReadKey();
        }

    }
    
}
