using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_7
{
    class Printer
    {
        public virtual void IamPrinting(Document document)
        {
            Console.WriteLine(document.GetType());
            Console.WriteLine(document.ToString());
        }
    }
}
