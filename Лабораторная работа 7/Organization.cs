using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_7
{
    class Organization : IGetInformation
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public Organization(string name, string address, string website)
        {
            if (name.Length <= 1)
            {
                throw new IsNotNameOfOrganization("Недопустимое значение для имени организации", name);
            }
            else Name = name;
            if (address.Length <= 1)
            {
                throw new IsNotAddress("Недопустимое значение для адреса организации", address);
            }
            else Address = address;
            if (website.Length <= 1)
            {
                throw new IsNotWebsite("Недопустимое значение для сайта организации", website);
            }
            else WebSite = website;
        }
        public void GetInfo()
        {
            string info = "Информация об организации:";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length, Console.CursorTop);
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
