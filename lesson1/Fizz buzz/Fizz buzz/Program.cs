using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)              //цикл (инициализация; условие; итератор)
            {
                if (i % 15 == 0)                        //проверка на кратность 3 и 5, путем сравнения остаттка от деления с нулем
                {
                    Console.WriteLine("Fizz Buzz");     //вывод строки в консоль, если кратно 15
                }
                else if (i % 5 == 0)                    //иначе проверка на кратность 5, путем сравнения остаттка от деления с нулем
                { 
                    Console.WriteLine("Buzz");          //вывод строки в консоль, если кратно 5
                }
                else if (i % 3 == 0)                    //иначе проверка на кратность 3, путем сравнения остаттка от деления с нулем
                {
                    Console.WriteLine("Fizz");          //вывод строки в консоль, если кратно 3
                }
                else Console.WriteLine(i);              //иначе вывод значения переменной i
            }
            Console.ReadKey();
        }
    }
}