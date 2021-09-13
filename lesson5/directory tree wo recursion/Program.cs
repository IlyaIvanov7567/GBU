using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directory_tree_wo_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\user\Desktop\root";
            string[] allfolders = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            string[] allfiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            foreach (string folder in allfolders)
            {
                File.AppendAllText("result.txt", $"{folder} \n");
                foreach (string file in allfiles)
                {
                    File.AppendAllText("result.txt", $"{file} \n");
                }
            }
            Console.ReadKey();
        }

    }
}

