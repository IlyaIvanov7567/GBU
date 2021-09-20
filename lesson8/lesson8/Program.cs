using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine(greeting);
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.Age == 0)
            {
                Console.WriteLine("Введите возраст:");
                Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Career))
            {
                Console.WriteLine("Укажите род деятельности:");
                Properties.Settings.Default.Career = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            string userName = Properties.Settings.Default.UserName;
            int age = Properties.Settings.Default.Age;
            string career = Properties.Settings.Default.Career;

            Console.WriteLine($"Имя: {userName}\nВозраст: {age}\nРод деятельности: {career}");
            Console.ReadKey();
        }
    }
}
