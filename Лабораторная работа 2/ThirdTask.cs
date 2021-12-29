using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_2
{
    class ThirdTask
    {
        static public void FirstSubTask()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 3a");
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(arr[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
        static public void SecondSubTask()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 3b");
            int i;
            string[] st = { "Чума", "Смерть", "Война", "Голод"};
            for (i = 0; i < st.Length; i++)
            {
                Console.Write(st[i] + " ");
            }
            Console.WriteLine($"Длина массива: {st.Length}");
            Console.WriteLine("Введите позицию нового элемента массива, а затем его значение");
            st[Convert.ToInt32(Console.ReadLine()) - 1] = Console.ReadLine();
            Console.WriteLine("Получившийся массив строк: ");
            for (i = 0; i < st.Length; i++)
            {
                Console.Write(st[i] + " ");
            }
            Console.WriteLine();
        }
        static public void ThirdSubTask()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 3c");
            double[][] styp = new double[][]
            {
                new double[2],
                new double[3],
                new double[4]
            };
            Console.WriteLine("Введите элементы ступенчатого массива");
            for (int x = 0; x < styp.Length; x++)
                for (int y = 0; y < styp[x].Length; y++)
                    styp[x][y] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Получившийся ступенчатый массив: ");
            for (int x = 0; x < styp.Length; x++)
            {
                for (int y = 0; y < styp[x].Length; y++)
                {
                    Console.Write("{0} ", styp[x][y]);
                }
                Console.WriteLine();
            }
        }
        static public void FourthSubTask()
        {
            //var array = new object[0];
            //var str = "vmjhfhgf";
        }
    }
}
