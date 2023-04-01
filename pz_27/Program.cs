using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    internal class Program
    {
        struct MARSH
        {
            public string BEGST; // начальный пункт маршрута
            public string TERM; // конечный пункт маршрута
            public int NUMER;  //  номер  маршрута
        }

        static void Main(string[] args)
        {
            MARSH[] TRAFIC = new MARSH[8];
            for (int i = 0; i < 8; i++) 
            {
                Console.WriteLine($"введите данные для маршрута №{i + 1}:");
                Console.Write("начальный пункт маршрута: ");
                TRAFIC[i].BEGST = Console.ReadLine();
                Console.Write("конечный пункт маршрута: ");
                TRAFIC[i].TERM = Console.ReadLine();
                Console.Write("номер маршрута: ");
                TRAFIC[i].NUMER = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(TRAFIC, (a,b) => a.NUMER.CompareTo(b.NUMER)); //лямбда(( для  сортировки по номерам маршрутов 

            //вывод на экран информации о маршрутах
            Console.WriteLine("введите навзание пункта");
            string name = Console.ReadLine();
            bool found = false;
            Console.WriteLine($"Маршруты, начинающиеся или заканчивающиеся в пункте {name}:");
            for (int i = 0; i < 8; i++)
            {
                if (TRAFIC[i].BEGST == name || TRAFIC[i].TERM == name) 
                {
                    Console.WriteLine("Маршрут" + TRAFIC[i].NUMER + TRAFIC[i].BEGST + TRAFIC[i].TERM);
                    found = true;
                }
            }
            //foreach (MARSH m in TRAFIC)
            //{
            //    if (m.BEGST == name || m.TERM == name)
            //    {
            //        Console.WriteLine($"№{m.NUMER} {m.BEGST} - {m.TERM}");
            //        found = true;
            //    }
            // }
            if (!found)
            {
                Console.WriteLine($"Маршрутов, начинающихся или заканчивающихся в пункте {name}, не найдено.");
            }
            Console.ReadKey();
        }
    }
}
