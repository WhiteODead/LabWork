using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_2
{
    class FourthTask
    {
        static public void main()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 4a");
            Console.WriteLine("Kortezhi\n");

            (int, string, char, string, ulong) kort = (19, "Abcde", 'f', "Ghijkl", 20);
            Console.WriteLine("Первый кортеж: {0}", kort);
            Console.WriteLine($"Второй элемент кортежа: {kort.Item2}, четвертый элемент кортежа: {kort.Item4}");

            int first = kort.Item1;
            string second = kort.Item2;
            char third = kort.Item3;
            string fourth = kort.Item4;
            ulong fifth = kort.Item5;

            (first, second, third, fourth, fifth) = kort;

            (int, string, char, string, ulong) kort2 = (19, "Abcde", 'f', "Ghijkl", 21);
            Console.WriteLine("Второй кортеж: {0}", kort2);
            if (kort.CompareTo(kort2) == 0)
                Console.WriteLine("Кортежи равны");
            else
                Console.WriteLine("Кортежи не равны");
        }
    }
}
