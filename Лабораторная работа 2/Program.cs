using System;
using System.Linq;
namespace Лабораторная_работа_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Введите номер задания: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            //FirstTask.FirstSubTask();
                            FirstTask.SecondSubTask();
                            FirstTask.ThirdSubTask();
                            FirstTask.FourthSubTask();
                            FirstTask.FifthSubTask();
                            FirstTask.SixthSubTask();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            SecondTask.FirstSubTask();
                            SecondTask.SecondSubTask();
                            SecondTask.ThirdSubTask();
                            SecondTask.FourthSubTask();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            ThirdTask.FirstSubTask();
                            ThirdTask.SecondSubTask();
                            ThirdTask.ThirdSubTask();
                            ThirdTask.FourthSubTask();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            FourthTask.main();
                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Задание 5");
                            var arr = new[] { 20, 10, 5, 15 };
                            string str = "Abcdefghijklmnop";
                            Console.WriteLine(LocalFunction(arr, str));
                            break;
                        }
                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Задание 6");

                            int a = Int32.MaxValue;
                            int b = 99999999;
                            Check(a, b);
                            Uncheck(a, b);
                            break;
                        }
                    case "Exit":
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default: Console.WriteLine("Такого задания нет"); break;
                }
            }
            (int, int, int, char) LocalFunction(int[] mas, string str1)
            {
                int max = mas.Max();
                int min = mas.Min();
                int sum = mas.Sum();
                return (max, min, sum, str1[0]);
            }
            int Check(int x, int y)
            {
                Console.Write("Checked: ");
                try
                {
                    checked
                    {
                        int result = x + y;
                        Console.WriteLine(result);
                    }
                }
                catch (OverflowException mess)
                {
                    Console.WriteLine(mess.Message);
                }
                return 0;
            }

            int Uncheck(int x, int y)
            {
                Console.Write("Unchecked: ");
                try
                {
                    unchecked
                    {
                        int result = x + y;
                        Console.WriteLine(result);
                    }
                }
                catch (OverflowException mess)
                {
                    Console.WriteLine(mess.Message);
                }
                return 0;
            }
        }
    }
}