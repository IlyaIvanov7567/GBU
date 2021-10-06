using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа через пробел:");
            string value = Console.ReadLine();
            int result = 0;
            string[] arr = value.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                result += Convert.ToInt32(arr[i]);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
