using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string papka = "D:\\програмест";
            string[] Files = Directory.GetFiles(papka);
            string s;

            if (Files.Length == 0)
            {
                Console.WriteLine("Файлов нет.");
            }
            else
            {
                foreach (string file in Files)
                {
                    if (File.Exists(file))
                    {
                        Console.WriteLine("Файл " + file);
                        using (StreamReader sr = new StreamReader(file))
                        {
                            s = sr.ReadToEnd();
                        }
                        using (StreamWriter sw = new StreamWriter("file2.txt", false, Encoding.Default))
                        {
                            sw.WriteLineAsync(s);
                        }


                    }
                }
            }

            Console.ReadKey();
        }
    }
}
