using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Элементы диагонали 1:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.SetCursorPosition(i, i + 5);
                Console.WriteLine("{0}", arr[i, i]);
            }

            Console.WriteLine("Элементы диагонали 2:");

            //for (int i = 0; i < arr.GetLength(0); i++)
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.SetCursorPosition(arr.GetLength(0)-i-1, i + 9);
                Console.WriteLine("{0}", arr[i, arr.GetLength(0) - i - 1]);
            }
            Console.ReadKey();
        }
    }
}
