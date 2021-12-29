using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_7
{
    partial class Client
    {
        public void GetInfo()
        {
            string info = "Информация о клиенте:";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length, Console.CursorTop);
            Console.WriteLine(info);
            Console.WriteLine($"Имя : {Name}");
            Console.WriteLine($"Фамилия : {SecondName}");
            Console.WriteLine($"Адрес проживания : {Address}");
            Console.WriteLine($"Дата рождения : {DateOfBirthday}");
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Name + " " + SecondName + " " + Address + " " + DateOfBirthday;
        }
    }
}
