using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Лабораторная_работа_11
{
    class Validation
    {
        public static string ValidationLetter()
        {
            string a;
            bool b = false;
            while (true)
            {
                a = Console.ReadLine();
                for (int i = 0; i < a.ToCharArray().Length; i++)
                {
                    if (a.ToCharArray()[i] >= 'А' && a.ToCharArray()[i] <= 'Я' || a.ToCharArray()[i] >= 'а' && a.ToCharArray()[i] <= 'я')
                    {
                        b = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        b = false;
                        break;
                    }
                }
                if (b == true)
                {
                    return a;
                }
            }
        }
        public static string ValidationFaculty()
        {
            string a;
            while (true)
            {
                a = Console.ReadLine();
                if (a == "ФИТ" || a == "ХТиТ" || a == "ТОВ" || a == "ПИМ")
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static string ValidationGroup()
        {
            while (true)
            {
                string a;
                int b;
                try
                {
                    a = Console.ReadLine();
                    b = Convert.ToInt32(a);
                    if (b >= 1 && b <= 12)
                    {
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static string ValidationCourse()
        {
            while (true)
            {
                string a;
                int b;
                try
                {
                    a = Console.ReadLine();
                    b = Convert.ToInt32(a);
                    if (b >= 1 && b <= 4)
                    {
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static string ValidationDate()
        {
            while (true)
            {
                string a;
                try
                {
                    a = Console.ReadLine();
                    DateTime.Parse(a);
                    if (DateTime.Parse(a).Year >= 1920 && DateTime.Parse(a).Year <= 2005)
                    {
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static string ValidationPhone()
        {
            while (true)
            {
                string a;

                a = Console.ReadLine();
                try
                {
                    Convert.ToInt32(a.ToCharArray()[1]);
                    Convert.ToInt32(a.ToCharArray()[2]);
                    Convert.ToInt32(a.ToCharArray()[3]);
                    Convert.ToInt32(a.ToCharArray()[5]);
                    Convert.ToInt32(a.ToCharArray()[6]);
                    Convert.ToInt32(a.ToCharArray()[8]);
                    Convert.ToInt32(a.ToCharArray()[9]);
                    Convert.ToInt32(a.ToCharArray()[10]);
                    Convert.ToInt32(a.ToCharArray()[12]);
                    Convert.ToInt32(a.ToCharArray()[13]);
                    Convert.ToInt32(a.ToCharArray()[15]);
                    Convert.ToInt32(a.ToCharArray()[16]);
                    if (a.ToCharArray()[0] == '+' && a.ToCharArray()[4] == '-' && a.ToCharArray()[7] == '-' && a.ToCharArray()[11] == '-' && a.ToCharArray()[14] == '-' && a.ToCharArray().Length == 17)
                    {
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Try again");

                }
            }
        }
        public static string ValidationAddress()
        {
            List<string> array = new List<string>();
            string line;
            string b;
            while (true)
            {
                try
                {
                    StreamReader a = new StreamReader(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 3\Улицы.txt");
                    b = Console.ReadLine();
                    while ((line = a.ReadLine()) != null)
                    {
                        if (line.Contains(b))
                        {
                            a.Close();
                            return line;
                        }
                    }
                    a.Close();
                    Console.WriteLine("Try again");
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static string ValidationHouseNumber()
        {
            while (true)
            {
                string b;
                try
                {
                    b = Console.ReadLine();
                    if (Convert.ToInt32(b.Split('-')[0]) > 0 && Convert.ToInt32(b.Split('-')[0]) < 200 && Convert.ToInt32(b.Split('-')[1]) > 0 && Convert.ToInt32(b.Split('-')[0]) < 500 && b.Split('-').Length == 2)
                    {
                        return b;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
