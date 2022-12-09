using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string longtext = ""; //длинное слово
            string[] textArray = text.Split(new char[] { ' ' });
            Console.WriteLine("количество слов: " + textArray.Length);
            foreach (string str in textArray)
                if (str.Length >= longtext.Length)
                    longtext = str;
            Console.WriteLine("Длинное слово: " + longtext);
            Array.Reverse(textArray);
            for (int i = 0; i < textArray.Length; i++)
            {
                Console.Write(" " + textArray[i]);
            }


            Console.ReadKey();
        }
    }
}
