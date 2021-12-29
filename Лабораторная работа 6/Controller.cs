using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_6
{
    class Controller
    {
        public void Price(Bookkeeping obj)
        {
             Console.WriteLine(obj.GetTotalPrice());
        }
        public void Output(Bookkeeping obj,DateTime dateTime1, DateTime dateTime2)
        {
            obj.OutputOfDocuments(dateTime1, dateTime2);
        }
        public void CountChecks(Bookkeeping obj)
        {
             Console.WriteLine(obj.GetCountOfChecks());
        }
    }
}
