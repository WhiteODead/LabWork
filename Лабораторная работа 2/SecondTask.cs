using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_2
{
    public class SecondTask
    {
        static public void FirstSubTask()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 2a");
            string v1 = "Абвгд";
            string v2 = "Абвг";
            string v3 = "Абв";
            var v4 = String.Compare(v1, v2);
            var v5 = String.Compare(v1, v3);
            Console.WriteLine("Сравнение строк 1 и 2: {0} и строк 1 и 3: {1}\n", v4, v5);
        }
        static public void SecondSubTask()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 2b");
            string v1 = "Абвгд 12345";
            string v2 = "Еёжзи";
            string v3 = "Йклмн";
            void ConcatStrings()
            {
                var v4 = String.Concat(v1, v3);
                Console.WriteLine("Объединение строк 1 и 3: {0} \n", v4);
            }
            void CopyString()
            {
                var v4 = String.Copy(v2);
                Console.WriteLine("Копирование строки: {0} \n", v4);
            }
            void SubString()
            {
                var v4 = v3.Substring(0, 2);
                Console.WriteLine("Подстрока: {0} \n", v4);
            }
            void SplitString()
            {
                string[] words = v1.Split();
                Console.WriteLine("1-ое слово: {0}\n2-ое слово: {1}\n", words[0], words[1]);
            }
            void InsertSubString()
            {
                var v4 = v1.Insert(4, v3);
                Console.WriteLine("Вставка подстроки в заданную позицию: {0} \n", v4);
            }
            void RemoveSubString()
            {
                var v4 = v1.Remove(6, 5);
                Console.WriteLine($"Удаление подстроки с заданной позиции: {v4} \n");
            }
            ConcatStrings();
            CopyString();
            SubString();
            SplitString();
            InsertSubString();
            RemoveSubString();
        }
        static public void ThirdSubTask()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 2c");
            string sEmpty = "";
            string sNull = null;
            string s3 = "abcd";
            Console.WriteLine("Длина строки: {0}", sEmpty.Length);
            Console.WriteLine(sEmpty == sNull);
            Console.WriteLine("Является ли строка \"{0}\" пустой или nullable? {1}", sEmpty, String.IsNullOrEmpty(sEmpty));
            Console.WriteLine("Является ли строка \"{0}\" пустой или nullable? {1}", sNull, String.IsNullOrEmpty(sNull));
            Console.WriteLine("Является ли строка \"{0}\" пустой или nullable? {1}", s3, String.IsNullOrEmpty(s3));

        }
        static public void FourthSubTask()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 2d");
            StringBuilder sb = new StringBuilder("Абвгде", 50);
            sb.Remove(4, 1);
            sb.Append(" Ёжзийкл");
            sb.Insert(0, "Мнопрст ");
            Console.WriteLine(sb);
        }
    }
}
