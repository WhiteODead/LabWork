using System;
using System.Collections.Generic;
namespace Лабораторная_работа_8
{
    class Program
    {
        static void Main(string[] args)
        {
            NewList<Organization> b = new NewList<Organization>();
            Organization c = new Organization("1", "2", "3");
            Organization d = new Organization("2", "3", "4");
            Organization e = new Organization("2", "4", "3");
            b.Add(c);
            b.Add(d);
            b.Add(e);
            b.View(x => x.Name == "2");
            b.WriteToFile();
            b.ReadFromFile();
        }
    }
}
