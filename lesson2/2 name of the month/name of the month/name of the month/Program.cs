using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_of_the_month
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int month_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month_num));
            Console.ReadKey();
        }
    }
}
