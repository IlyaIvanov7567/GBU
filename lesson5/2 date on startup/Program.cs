using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_on_startup
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";

            string date = Convert.ToString(DateTime.Now);

            File.AppendAllText(filename, date + "\n");

        }
    }
}
