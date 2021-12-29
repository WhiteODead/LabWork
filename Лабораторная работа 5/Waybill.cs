using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_5
{
    sealed class Waybill : Document, IGetInformation //Накладная
    {
        public string Product { get; set; }
        public Waybill(Client client, Organization organization, DateTime dateOfIssue)
        {
            this.client = client;
            this.organization = organization;
            title = "Накладная";
            this.dateOfIssue = dateOfIssue;
            Product = "1230";
        }
        public override void GetInfo()
        {
            string info = "Информация о документе здорового человека";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length/2, Console.CursorTop);
            Console.WriteLine(info);
            Console.WriteLine($"Тип документа : {title}");
            Console.WriteLine($"Название организации : {organization.Name}");
            Console.WriteLine($"Имя клиента : {client.Name}");
            Console.WriteLine($"Товар : {Product}");
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n");
        }
        void IGetInformation.GetInfo()
        {
            Console.WriteLine("Информация о накладной курильщика");
        }
        public override string ToString()
        {
            return base.ToString() + " " + client + " " + organization + " " + title + " " + dateOfIssue + " " + Product;
        }
    }
}
