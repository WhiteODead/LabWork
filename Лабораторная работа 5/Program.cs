using System;

namespace Лабораторная_работа_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string info;
            Organization microsoft = new Organization("microsoft", "address", "microsoft.com");
            Client bill = new Client("Bill", "Gates", "address", new DateTime(1955,10,28));

            Receipt receiptForBill = new Receipt(bill, microsoft, new DateTime(2021, 2, 15));
            Check checkForBill = new Check(bill, microsoft, new DateTime(2021, 2, 15));
            Waybill waybillForBill = new Waybill(bill, microsoft, new DateTime(2021, 2, 15));

            Document firstDocument = receiptForBill;
            Document secondDocument = checkForBill;
            Document thirdDocument = waybillForBill;

            firstDocument.GetInfo();
            secondDocument.GetInfo();
            thirdDocument.GetInfo();
            info = "Проверка на принадлежность к классу";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length / 2, Console.CursorTop);
            Console.WriteLine(info);
            Console.WriteLine($"firstDocument is Document?:{waybillForBill is Document}");
            Console.WriteLine($"firstDocument is Receipt?:{waybillForBill is Waybill}");
            Console.WriteLine($"firstDocument is IGetInformation?:{waybillForBill is IGetInformation}");
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n");

            info = "GetInfo интерфейса";
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length / 2, Console.CursorTop);
            Console.WriteLine(info);
            ((IGetInformation)receiptForBill).GetInfo();
            ((IGetInformation)checkForBill).GetInfo();
            ((IGetInformation)waybillForBill).GetInfo();
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n");

            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            info = "Информация о документах";
            Document[] array = { receiptForBill, waybillForBill, checkForBill };
            Printer b = new Printer();
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length / 2, Console.CursorTop);
            Console.WriteLine(info);
            foreach (Document a in array)
            {
                b.IamPrinting(a);
                Console.WriteLine("\n");
            }
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
        }
    }
}
