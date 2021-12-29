using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_9
{
    static class StringHandling
    {
        public static string SToApper(string str)
        {
            str = str.ToUpper();
            Console.WriteLine(str);
            return str;
        }
        public static string SToLower(string str)
        {
            str = str.ToLower();
            Console.WriteLine(str);
            return str;
        }
        public static string Delet(string str)
        {
            str = str.Remove(0, 1);
            Console.WriteLine(str);
            return str;
        }
        public static string AddLetter(string str)
        {
            str = str + "M";
            Console.WriteLine(str);
            return str;
        }
        public static string Oa(string str)
        {
            str = str.Replace("O", "a");
            Console.WriteLine(str);
            return str;
        }
    }
}
