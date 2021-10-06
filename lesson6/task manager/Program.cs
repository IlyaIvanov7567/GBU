using System;
using System.Diagnostics;

namespace Task_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"{processes[i].Id} {processes[i].ProcessName}");
            }

            Console.WriteLine("Введите наименование или id процесса, чтобы закрыть его:");

            string pr_to_kill = Console.ReadLine();
            int pr_to_kill_id;
            try
            {
                pr_to_kill_id = Convert.ToInt32(pr_to_kill);
                foreach (Process pr in processes)
                {
                    if (pr.Id == pr_to_kill_id)
                    {
                        pr.Kill();
                    }
                }
            }
            catch
            {
                foreach (Process pr in processes)
                {
                    if (pr.ProcessName == pr_to_kill)
                    {
                        pr.Kill();
                    }
                }
            }

        }
    }
}