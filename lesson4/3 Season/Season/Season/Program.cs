using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        enum Season
        {
            error,
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            inputmess();
            while (true)
            {
                bool success = Int32.TryParse(Console.ReadLine(), out int month_number);
                if (success)
                {
                    Console.WriteLine(TranslateSeason(GetSeason(month_number)));
                    inputmess();
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12 и нажмите Enter");
                }
            }
        }
        static void inputmess()
        {
            Console.WriteLine("Введите порядковый номеря месяца и нажмите Enter");
        }
        static Season GetSeason(int value)
        {
            switch (value)
            {
                case 1:
                case 2:
                case 12:
                    return Season.Winter;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                case 9:
                case 10:
                case 11:
                    return Season.Autumn;
                default:
                    return Season.error;
            }
        }
        static string TranslateSeason(Season value)
        {
            string result;
            switch (value)
            {
                case Season.Winter:
                    result = "Зима";
                    break;
                case Season.Spring:
                    result = "Весна";
                    break;
                case Season.Summer:
                    result = "Лето";
                    break;
                case Season.Autumn:
                    result = "Осень";
                    break;
                default:
                    result = "Ошибка";
                    break;
            }
            return result;
        }
    }
}
