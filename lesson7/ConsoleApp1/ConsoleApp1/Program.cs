using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Whats your name?");
            var name = Console.ReadLine();
            string unknown = "someone";
            Console.WriteLine($"Hello, {name}");
            Console.ReadKey();
        }
    }
}
