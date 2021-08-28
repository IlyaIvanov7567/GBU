using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_rainy_winter
{
    class Program
    {
        static void Main(string[] args)
        {
            double mintemp;
            double maxtemp;
            double avgtemp;
            Console.WriteLine("Введите номер месяца и нажмите Enter");
            int month_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month_num));
            Console.WriteLine("Введите минимальную температуру за сутки и нажмите Enter");
            mintemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки и нажмите Enter");
            maxtemp = Convert.ToDouble(Console.ReadLine());
            avgtemp = (mintemp + maxtemp) / 2;
            Console.Write($"Среднесуточная температура: {avgtemp}");
            /*if ((month_num == 1 | month_num == 2 | month_num ==12) && avgtemp > 0)
            {
                Console.WriteLine("Дождливая зима");
            }*/
            switch (month_num)
            {
                case 1:
                case 2:
                case 12:
                    if (avgtemp > 0)
                        Console.WriteLine(" Дождливая зима");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
