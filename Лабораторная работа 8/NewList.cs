using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
namespace Лабораторная_работа_8
{
    public class NewList<T> : IInterection<T>
    {
        public static List<T> f = new List<T>();
        private List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }
        public void Remove(Predicate<T> predicate)
        {
            list.RemoveAll(predicate);
        }
        public void View(Predicate<T> predicate)
        {
            string message = "Список элементов по заданному условию";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - message.Length / 2, Console.CursorTop);
            Console.WriteLine(message);
            list.FindAll(predicate).ForEach(x => Console.WriteLine(x));
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n");
        }
        public void WriteToFile()
        {
            try
            {
                StreamWriter write = new StreamWriter(@"E:\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 8\Список.txt", false);
                list.ForEach(x => write.WriteLine(x));
                write.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Произошло исключение:\n{e}");
            }
            finally
            {

            }
        }
        public void ReadFromFile()
        {
            try
            {
                StreamReader read = new StreamReader(@"E:\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 8\Список.txt");
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                read.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Произошло исключение:\n{e}");
            }
            finally
            {

            }
        }
    }
}
