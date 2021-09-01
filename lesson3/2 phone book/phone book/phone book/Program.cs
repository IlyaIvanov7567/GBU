using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_book
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook =
           {
                {"ИМЯ", "КОНТАКТ"},
                {"Андрей", "89097568390"},
                {"Антон", "89097568391"},
                {"Борис", "89097568392"},
                {"Владимир", "vova@yandex.ru"},
                {"Григорий", "8(909)-756-83-90"},
            };
            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    System.Console.Write("{0,-20}", phonebook[i, j]);
                }
                System.Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
