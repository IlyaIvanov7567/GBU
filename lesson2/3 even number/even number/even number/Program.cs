using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Число {num} четное");
                }
                else
                {
                    Console.WriteLine($"Число {num} не четное");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Некорректый ввод");
                Console.ReadKey();

            }
        }
    }
}
