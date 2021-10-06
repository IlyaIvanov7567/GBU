using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_list
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo() { }
        public ToDo(string title) { Title = title; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        static ToDo[] ReadAllTasks()
        {
            string[] json = File.ReadAllLines("tasks.json");
            ToDo[] AllTasks = new ToDo[json.Length];
            for (int i = 0; i < json.Length; ++i)
            {
                AllTasks[i] = JsonSerializer.Deserialize<ToDo>(json[i]);
            }
            return AllTasks;
        }
        static void OutPutAllTasks(ToDo[] AllTasks)
        {
            Console.Clear();
            var num = 1;
            Console.WriteLine("Список задач:");
            for (int i = 0; i < AllTasks.Length; i++)
            {
                if (AllTasks[i].IsDone == true)
                {
                    Console.WriteLine($"[x] {num}. {AllTasks[i].Title}");
                }
                else
                {
                    Console.WriteLine($"[ ] {num}. {AllTasks[i].Title}");
                }
                num++;
            }
        }
        static void AddTask()
        {
            Console.WriteLine("Что делаем?");
            ToDo task = new ToDo(Console.ReadLine());
            string json = JsonSerializer.Serialize(task);
            File.AppendAllText("tasks.json", $"{json}\n");
        }
        static void TaskDone(ToDo[] AllTasks)
        {
            Console.WriteLine("Какую задачу выполняем? ");
            var id = Convert.ToInt32(Console.ReadLine());
            AllTasks[id - 1].IsDone = true;
            SaveAllTasks(AllTasks);
        }
        static void SaveAllTasks(ToDo[] AllTasks)
        {
            File.Delete("tasks.json");
            for (int i = 0; i < AllTasks.Length; ++i)
            {
                string jsonstring = JsonSerializer.Serialize(AllTasks[i]);
                File.AppendAllText("tasks.json", $"{jsonstring}\n");
            }
        }
        static void ShowMenu()
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        OutPutAllTasks(ReadAllTasks());
                        break;
                    case 2:
                        TaskDone(ReadAllTasks());
                        OutPutAllTasks(ReadAllTasks());
                        break;
                    case 3:
                        AddTask();
                        OutPutAllTasks(ReadAllTasks());
                        break;
                    default:
                        break;
                }
            }
            while (choice != 0);
        }
        static int GetUserChoice()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Просмотр списка задач");
            Console.WriteLine("2 - Отметить задачу выполненой");
            Console.WriteLine("3 - Добавить задачу");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
