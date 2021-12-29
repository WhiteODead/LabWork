using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_7
{
    sealed class Waybill : Document, IGetInformation //Накладная
    {
        private string product;
        public string Product
        {
            get
            {
                return product;
            }
        }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
        }
        public Waybill(Client client, Organization organization, DateTime dateOfIssue, string product, int price)
        {
            this.price = price;
            this.client = client;
            this.organization = organization;
            title = "Накладная";
            this.dateOfIssue = dateOfIssue;
            this.product = product;
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
            Console.WriteLine($"Товар : {product}");
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
            return base.ToString() + " " + client + " " + organization + " " + title + " " + dateOfIssue + " " + product;
        }
    }
}
