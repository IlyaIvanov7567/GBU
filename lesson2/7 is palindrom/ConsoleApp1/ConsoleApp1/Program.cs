using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ispalindrom = false;
            Console.Write("enter value: ");
            string value = Console.ReadLine();
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == value[value.Length - 1 - i])
                {
                    ispalindrom = true;
                }
                else
                {
                    ispalindrom = false;
                    break;
                }
            }
            Console.WriteLine($"is {value} palindrom: {ispalindrom}");
            Console.ReadKey();
        }
    }
}
