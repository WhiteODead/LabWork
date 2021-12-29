using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Лабораторная_работа_6
{
    public struct A
    {
    }   
    enum B
    {
        C,
        D,
        E,
        F
    }
    class Bookkeeping
    {
        private static List<Receipt> receipts = new List<Receipt>();
        private static List<Waybill> waybills = new List<Waybill>();
        private static List<Check> checks = new List<Check>();
        public void AddReceipt(Receipt receipt)
        {
            receipts.Add(receipt);
        }
        public void AddWaybill(Waybill waybill)
        {
            waybills.Add(waybill);
        }
        public void AddCheck(Check check)
        {
            checks.Add(check);
        }
        public void RemoveReceipt(Receipt receipt)
        {
            receipts.Remove(receipt);
        }
        public void RemoveReceipt(int index)
        {
            receipts.RemoveAt(index);
        }

        public void RemoveWaybill(Waybill waybill)
        {
            waybills.Remove(waybill);
        }
        public void RemoveWaybill(int index)
        {
            waybills.RemoveAt(index);
        }

        public void RemoveCheck(Check check)
        {
            checks.Remove(check);
        }
        public void RemoveCheck(int index)
        {
            checks.RemoveAt(index);
        }
        public void OutputOfDocuments(DateTime dateTime1, DateTime dateTime2)
        {
            receipts.FindAll(x => x.dateOfIssue > dateTime1 && x.dateOfIssue < dateTime2).ForEach(x => x.GetInfo());
            waybills.FindAll(x => x.dateOfIssue > dateTime1 && x.dateOfIssue < dateTime2).ForEach(x => x.GetInfo());
            checks.FindAll(x => x.dateOfIssue > dateTime1 && x.dateOfIssue < dateTime2).ForEach(x => x.GetInfo());
        }
        public void OutputOfReceipts()
        {
            receipts.ForEach(x => x.GetInfo());
        }
        public void OutputOfWaybills()
        {
            waybills.ForEach(x => x.GetInfo());
        }
        public void OutputOfChecks()
        {
            checks.ForEach(x => x.GetInfo());
        }
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            string product;
            Console.Write("Введите наименование товара:");
            product = Console.ReadLine();
            waybills.FindAll(x => x.Product == product).ForEach(x => totalPrice += x.Price);
            return totalPrice;
        }
        public int GetCountOfChecks()
        {
            return checks.Count();
        }
    }
}
