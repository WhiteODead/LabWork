using System;

namespace Лабораторная_работа_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Organization microsoft = new Organization("microsoft", "address", "microsoft.com");
            //Client bill = new Client("Bill", "Gates", "address", new DateTime(1955,10,28));

            //Receipt receiptForBill = new Receipt(bill, microsoft, new DateTime(2021, 2, 15));
            //Check checkForBill = new Check(bill, microsoft, new DateTime(2021, 2, 15));
            //Waybill waybillForBill = new Waybill(bill, microsoft, new DateTime(2021, 2, 15));

            //Document firstDocument = receiptForBill;
            //Document secondDocument = checkForBill;
            //Document thirdDocument = waybillForBill;


            //firstDocument.GetInfo();
            //secondDocument.GetInfo();
            //thirdDocument.GetInfo();


            //while (Console.CursorLeft < Console.WindowWidth - 1)
            //{
            //    Console.Write("-");
            //}
            //Console.WriteLine($"\nfirstDocument is Document?:{waybillForBill is Document}");
            //Console.WriteLine($"firstDocument is Receipt?:{waybillForBill is Waybill}");
            //Console.WriteLine($"firstDocument is IGetInformation?:{waybillForBill is IGetInformation}");
            //while (Console.CursorLeft < Console.WindowWidth - 1)
            //{
            //    Console.Write("-");
            //}
            //Console.WriteLine("\n");



            //while (Console.CursorLeft < Console.WindowWidth - 1)
            //{
            //    Console.Write("-");
            //}
            //Console.WriteLine();
            //((IGetInformation)receiptForBill).GetInfo();
            //((IGetInformation)checkForBill).GetInfo();
            //((IGetInformation)waybillForBill).GetInfo();
            //while (Console.CursorLeft < Console.WindowWidth - 1)
            //{
            //    Console.Write("-");
            //}



            //Document[] array = { receiptForBill, waybillForBill, checkForBill };
            //Printer b = new Printer();



            //while (Console.CursorLeft < Console.WindowWidth - 1)
            //{
            //    Console.Write("-");
            //}
            //Console.WriteLine();
            //foreach (Document a in array)
            //{
            //    b.IamPrinting(a);
            //    Console.WriteLine("\n");
            //}
            //while (Console.CursorLeft < Console.WindowWidth - 1)
            //{
            //    Console.Write("-");
            //}
            Organization microsoft = new Organization("microsoft", "address", "microsoft.com");
            Client bill = new Client("Bill", "Gates", "address", new DateTime(1955, 10, 28));
            Client bill1 = new Client("Bill1", "Gates", "address", new DateTime(1965, 10, 28));
            Client bill2 = new Client("Bill2", "Gates", "address", new DateTime(1975, 10, 28));
            Client bill3 = new Client("Bill3", "Gates", "address", new DateTime(1985, 10, 28));

            Receipt receiptForBill = new Receipt(bill, microsoft, new DateTime(2021, 2, 15));
            Check checkForBill = new Check(bill, microsoft, new DateTime(2021, 2, 15));
            Receipt receiptForBill1 = new Receipt(bill1, microsoft, new DateTime(2020, 2, 15));
            Receipt receiptForBill2 = new Receipt(bill2, microsoft, new DateTime(2019, 2, 15));
            Receipt receiptForBill3 = new Receipt(bill3, microsoft, new DateTime(2018, 2, 15));

            Waybill waybillForBill = new Waybill(bill, microsoft, new DateTime(2021, 2, 15), "продукт1", 500);
            Waybill waybillForBill1 = new Waybill(bill, microsoft, new DateTime(2021, 2, 15), "продукт2", 1000);
            Waybill waybillForBill2 = new Waybill(bill, microsoft, new DateTime(2021, 2, 15), "продукт3", 1500);
            Waybill waybillForBill3 = new Waybill(bill, microsoft, new DateTime(2021, 2, 15), "продукт1", 4000);
            Bookkeeping a = new Bookkeeping();
            Controller b = new Controller();
            a.AddWaybill(waybillForBill);
            a.AddWaybill(waybillForBill1);
            a.AddWaybill(waybillForBill2);
            a.AddWaybill(waybillForBill3);

            a.AddReceipt(receiptForBill);
            a.AddReceipt(receiptForBill1);
            a.AddReceipt(receiptForBill2);
            a.AddReceipt(receiptForBill3);
            a.AddCheck(checkForBill);
            b.Output(a, new DateTime(2018, 2, 14), DateTime.Now);
            //a.OutputOfDocuments(new DateTime(2018, 2, 14), DateTime.Now);
            //Console.WriteLine(a.GetTotalPrice());
            //Console.WriteLine(a.GetCountOfChecks());
            b.CountChecks(a);
            b.Price(a);
        }
    }
}
