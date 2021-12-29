using System;
using System.Collections.Generic;
namespace Лабораторная_работа_4
{
    class Program
    {
        static void Main(string[] args)
        {
            NewStack<double> a = new NewStack<double>("1", "1", "1");
            NewStack<double> b = new NewStack<double>("1", "1", "1");
            string str = "Строка без вопросительных предложений.";
            string str2 = "Эта строка содержит вопросительные предложения????????????Да?Сколько???";
            Console.WriteLine(a.NewDate.dateOfCreation);
            a = a * 2;
            a = a * 6;
            a = a * 4;
            a = a * 0;
            b = b * 2;
            b = b * 6;
            b = b * 4;
            b = b * 0;
            b.FEZero();
            StatisticOperation.Sum(b);
            StatisticOperation.Difference(b);
            StatisticOperation.Count(b);
            str.ISCount();
            str2.ISCount();
            if (a == b)
            {
                Console.WriteLine("Стеки равны");
            }
            else
            {
                Console.WriteLine("Стеки не равны");
            }
            if (a)
            {
                Console.WriteLine("В стеке есть отрицательные элементы");
            }
            else
            {
                Console.WriteLine("В стеке нет отрицательных элементов");
            }
            b = b / 0;
        }
    }
}
