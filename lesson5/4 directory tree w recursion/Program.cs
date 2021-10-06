using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directory_tree_w_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\root\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            DirTree(dirInfo);
            Console.ReadLine();
        }
        static void DirTree(DirectoryInfo root)
        {
            DirectoryInfo[] allsubdirs = null;

            FileInfo[] allfiles = null;

            allsubdirs = root.GetDirectories();

            allfiles = root.GetFiles();

            File.AppendAllText("result.txt", $"{root.FullName} \n");

            foreach (var file in allfiles)
            {
                File.AppendAllText("result.txt", $"{file.FullName} \n");
            }

            foreach (var subdir in allsubdirs)
            {
                DirTree(subdir);
            }
        }

    }
}
