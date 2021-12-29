using System;
using System.Diagnostics;
namespace Лабораторная_работа_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------");
                try
                {
                    Organization microsoft = new Organization("", "address", "microsoft.com");
                }
                catch (IsNotNameOfOrganization ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }//Source - Возвращает или задает имя приложения или объекта, вызывавшего ошибку
                //StackTrace cвойство возвращает кадры стека вызовов, которые происходят в том месте, где было создано исключение
                Console.WriteLine("---------------------------------------------------------------------");
                try
                {
                    Organization microsoft = new Organization("microsoft", "", "microsoft.com");
                }
                catch (IsNotAddress ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }
                Console.WriteLine("---------------------------------------------------------------------");
                try
                {
                    Organization microsoft = new Organization("microsoft", "address", "");
                }
                catch (IsNotWebsite ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }
                Console.WriteLine("---------------------------------------------------------------------");
                try
                {
                    string[] a = { "1", "2", "3" };
                    Console.WriteLine(a[4]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }
                Console.WriteLine("---------------------------------------------------------------------");
                try
                {
                    Organization microsoft = new Organization("microsoft", "address", "microsoft.com");
                    object obj = microsoft;
                    int title = (int)obj;
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }
                Console.WriteLine("---------------------------------------------------------------------");
                try
                {
                    int a = 0;
                    int b = 10;
                    int c = a / b;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }
                Console.WriteLine("---------------------------------------------------------------------");
                int index = 10;
                Debug.Assert(index > -1, "Значение должно быть больше -1");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
        }
    }
}
