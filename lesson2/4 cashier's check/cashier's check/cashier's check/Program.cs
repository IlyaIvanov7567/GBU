using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_s_check
{
    class Program
    {
        static void Main(string[] args)
        {
            string firm = "Ромашка";
            long inn = 5902034504;
            int check_num = 2;
            DateTime date = new DateTime(2019, 07, 01, 15, 46, 00);
            int cash_shift = 8;
            string cno = "ОСН";
            string cashier = "Забегаева С. В.";
            long rnkkt = 15344535059984;
            string city = "Перьм";
            string placeofsale = "Офис";
            int goods_quantity = 1;
            decimal price = 1200.00m;
            decimal sum = goods_quantity * price;
            float taxrate = 20;
            decimal taxamount = 200.00m;
            decimal total = 1200.00m;
            decimal cash = 1200.00m;
            decimal recd = 1200.00m;
            string fnsURL = "www.nalog.ru";
            int fd = 32;
            long fn = 9999078900011730;
            long fp = 339323316;
            Console.WriteLine("\tКАССОВЫЙ ЧЕК");
            Console.WriteLine($"\t{firm}");
            Console.WriteLine($"\tИНН {inn}");
            Console.WriteLine($"ЧЕК\t\t\t{check_num}");
            Console.WriteLine(date.ToString("dd.MM.yyy HH:mm"));
            Console.WriteLine($"СМЕНА\t\t\t{cash_shift}");
            Console.WriteLine("ПРИХОД");
            Console.WriteLine($"СНО\t\t\t{cno}");
            Console.WriteLine($"КАССИР\t\t\t{cashier}");
            Console.WriteLine($"РН ККТ\t\t\t{rnkkt.ToString("D16")}");
            Console.WriteLine($"{city}");
            Console.WriteLine($"МЕСТО РАСЧЕТОВ\t\t{placeofsale}\n");
            Console.WriteLine("АВАНС");
            Console.WriteLine("ТОВАР");
            Console.WriteLine($"{goods_quantity} шт * {price} =\t{sum}");
            Console.WriteLine($"НДС {taxrate}%\t\t\t{taxamount}");
            Console.WriteLine($"ИТОГО\t\t\t{total}");
            Console.WriteLine($"НАЛИЧНЫМИ\t\t{cash}");
            Console.WriteLine($"\tПОЛУЧЕНО\t{recd}");
            Console.WriteLine($"СУММА НДС {taxrate}%\t\t{taxamount}");
            Console.WriteLine($"САЙТ ФНС\t\t{fnsURL}");
            Console.WriteLine($"ФД\t\t\t{fd}");
            Console.WriteLine($"ФН\t\t\t{fn}");
            Console.WriteLine($"ФП\t\t\t{fp}");
            Console.ReadKey();
        }
    }
}
