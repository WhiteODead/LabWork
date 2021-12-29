using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Лабораторная_работа_4
{
    static class StatisticOperation
    {
        public static void Sum(NewStack<double> stack)
        {
            Console.Write("Сумма элементов стека равна ");
            Console.WriteLine(stack.Sum());
        }
        public static void Difference(NewStack<double> stack)
        {
            Console.Write($"Разница между максимальным({stack.Max()}) и минимальным({stack.Min()}) элементами стека равна ");
            Console.WriteLine(stack.Max() - stack.Min());
        }
        public static void Count(NewStack<double> stack)
        {
            Console.Write($"Количество элементов стека равно ");
            Console.WriteLine(stack.Count);
        }
        public static void ISCount(this string str)
        {
            int count = 0;
            for(int i = 1; i < str.ToCharArray().Length; i++)
            {
                if(str.ToCharArray()[i] == '?' && str.ToCharArray()[i - 1] != '?')
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество вопросительных предложений в строке равно {count}");
        }
        public static void FEZero(this NewStack<double> stack)
        {
            if(stack.First() == 0)
            {
                Console.WriteLine("Первый элемент равен нулю");
            }
            else
            {
                Console.WriteLine("Первый элемент не равен нулю");
            }
        }
    }
}
