using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace save_to_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "textfile.txt";

            Console.WriteLine("Введите произвольный набор данных:");

            string data = Console.ReadLine();

            File.AppendAllText(filename, data);

            Console.WriteLine(File.ReadAllText("textfile.txt"));

            Console.ReadKey();
        }
    }
}