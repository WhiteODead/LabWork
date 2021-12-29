using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_5
{
    class Client : IGetInformation
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public Client(string name, string secondName, string address, DateTime dateOfBitrhday)
        {
            Name = name;
            SecondName = secondName;
            Address = address;
            DateOfBirthday = dateOfBitrhday;
        }
        public void GetInfo()
        {
            string info = "Информация о клиенте";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length / 2, Console.CursorTop);
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
