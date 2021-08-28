using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            double mintemp;
            double maxtemp;
            double avgtemp;
            Console.WriteLine("Введите минимальную температуру за сутки и нажмите Enter");
            mintemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки и нажмите Enter");
            maxtemp = Convert.ToDouble(Console.ReadLine());
            avgtemp = (mintemp + maxtemp) / 2;
            Console.WriteLine($"Среднесуточная температура: {avgtemp}");
            Console.ReadKey();
        }
    }
}
