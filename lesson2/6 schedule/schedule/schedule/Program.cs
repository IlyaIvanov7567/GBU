using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule
{
    class Program
    {
        [Flags]
        enum dayofweek
        {
            monday = 0b_0000_0001,
            tuesday = 0b_0000_0010,
            wednesday = 0b_0000_0100,
            thursday = 0b_0000_1000,
            friday = 0b_0001_0000,
            saturday = 0b_0010_0000,
            sunday = 0b_0100_0000
        }
        static void Main(string[] args)
        {
            dayofweek office1 = (dayofweek)0b_0001_1110;
            dayofweek office2 = (dayofweek)0b_0111_1111;
            Console.WriteLine($"Рассписание работы офиса 1: {office1}");
            Console.WriteLine($"Рассписание работы офиса 2: {office2}");
            Console.ReadKey();
        }
    }
}
