using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battlefield
{
    class PrOgram
    {
        static void Main(string[] args)
        {
            string[,] battlefield =
          {
                {"X","O","X","O","X","O","X","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O"},
                {"X","X","O","X","X","O","X","X","O","O"},
                {"O","O","O","O","O","O","O","O","O","O"},
                {"X","X","X","O","X","X","X","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O"},
                {"X","X","X","X","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O"},
            };

            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    System.Console.Write($"{battlefield[i, j]} ");
                }
                System.Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
