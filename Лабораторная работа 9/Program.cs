using System;
using System.Collections.Generic;
namespace Лабораторная_работа_9
{
    class Program
    {
        static void Main(string[] args)
        {
            NewList<int> test = new NewList<int>();
            Programmer.remove += test.RemoveFirstElement;
            Programmer.mutate += test.Shuffle;
            test.Add(1);
            test.Add(3);
            test.Add(4);
            test.Add(7);
            test.Add(15);
            test.Add(22);
            test.Add(10);
            test.View();
            test.Mutate();
            test.View();
            string stroka = "ALalO";
            Func<string, string> func = StringHandling.SToLower;
            func += StringHandling.SToApper;
            func += StringHandling.Oa;
            func += StringHandling.Delet;
            func += StringHandling.AddLetter;
            func(stroka);
        }
    }
}
