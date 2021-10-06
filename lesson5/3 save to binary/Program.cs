using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace save_to_binary_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "file.bin";

            Console.WriteLine("Введите с клавиатуры произвольный набор чисел (0...255):");

            byte[] bindata = Encoding.UTF8.GetBytes(Console.ReadLine());

            File.WriteAllBytes(filename, bindata);

            for (int i = 0; i < bindata.Length; i++)
            {
                Console.WriteLine(bindata[i]);
            }
            Console.ReadKey();
        }
    }
}
