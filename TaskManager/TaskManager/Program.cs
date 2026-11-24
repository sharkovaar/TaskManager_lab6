using System;
using System.Collections.Generic;

namespace TaskManager
{
    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title)
        {
            Title = title;
            IsCompleted = false;
        }
    }

    class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- МЕНЕДЖЕР ЗАДАЧ ---");
                Console.WriteLine("1. Показать все задачи");
                Console.WriteLine("2. Добавить задачу");
                Console.WriteLine("3. Отметить задачу выполненной");
                Console.WriteLine("4. Удалить задачу");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод!");
                        break;
                }
            }
        }

        static void ShowTasks() { Console.WriteLine("Функция в разработке..."); }
        static void AddTask() { Console.WriteLine("Функция в разработке..."); }
        static void CompleteTask() { Console.WriteLine("Функция в разработке..."); }
        static void DeleteTask() { Console.WriteLine("Функция в разработке..."); }
    }
}
