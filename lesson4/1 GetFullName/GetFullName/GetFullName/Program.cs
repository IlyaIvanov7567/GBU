using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNameList = { "Илья", "Кирилл", "Денис", "Михаил", "Артем" };
            string[] lastNameList = { "Иванов", "Сидоров", "Вольнов", "Фокин", "Агаян" };
            string[] patronymicList = { "Евгеньевич", "Сергеевич", "Евгеньевич", "Вячеславовчи", "Карапетович" };
            OutputFullName(firstNameList, lastNameList, patronymicList);
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string FullName = $"{lastName} {firstName} {patronymic}";
            return FullName;
        }

        static void OutputFullName(string[] firstNameList, string[] lastNameList, string[] patronymicList)
        {
            for (int i = 0; i < firstNameList.Length; i++)
            {
                Console.WriteLine($"{GetFullName(firstNameList[i], lastNameList[i], patronymicList[i])}");
            }
        }
    }
}