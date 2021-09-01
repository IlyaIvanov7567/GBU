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
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                System.Console.WriteLine("{0}", arr[i, i]);
            }
            Console.ReadKey();
        }
    }
}
