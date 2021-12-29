using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_7
{
    sealed class Receipt : Document, IGetInformation //Квитанция
    {
        public Receipt(Client client, Organization organization, DateTime dateOfIssue)
        {
            this.client = client;
            this.organization = organization;
            title = "Квитанция";
            this.dateOfIssue = dateOfIssue;
        }
        public override void GetInfo()
        {
            string info = "Информация о документе здорового человека:";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length, Console.CursorTop);
            Console.WriteLine(info);
            Console.WriteLine($"Тип документа : {title}");
            Console.WriteLine($"Название организации : {organization.Name}");
            Console.WriteLine($"Имя клиента : {client.Name}");
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n");
        }
        void IGetInformation.GetInfo()
        {
            Console.WriteLine("Информация о квитанции курильщика");
        }
        public override string ToString()
        {
            return base.ToString() + " " + client + " " + organization + " " + title + " " + dateOfIssue;
        }
    }
}
