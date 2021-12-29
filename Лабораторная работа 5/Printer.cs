using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_5
{
    class Printer
    {
        public virtual void IamPrinting(Document document)
        {
            Console.WriteLine($"Document.GetType(): {document.GetType()}");
            Console.WriteLine($"Document.ToString(): {document.ToString()}");
        }
    }
}
