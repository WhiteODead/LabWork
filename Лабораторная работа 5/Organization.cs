using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_5
{
    class Organization : IGetInformation
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public Organization(string name, string address, string website)
        {
            Name = name;
            Address = address;
            WebSite = website;
        }
        public void GetInfo()
        {
            string info = "Информация об организации:";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length / 2, Console.CursorTop);
            Console.WriteLine(info);
            Console.WriteLine($"Название : {Name}");
            Console.WriteLine($"Адрес : {Address}");
            Console.WriteLine($"Сайт : {WebSite}");
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Name + " " + Address + " " + WebSite;
        }
    }
}
