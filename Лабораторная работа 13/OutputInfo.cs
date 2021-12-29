using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_13
{
    public delegate void ForEvent(Delegate @delegate);
    static partial class OutputInfo
    {
        public static event ForEvent logevent = SDULog.Log;
        public static void Output(string name, Action method)
        {
            logevent(method);
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
                if(Console.CursorLeft == (Console.WindowWidth / 2 - name.Length / 2 ))
                {
                    Console.Write(name);
                }
            }

            method.Invoke();

            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n\n");
        }
    }
    static partial class OutputInfo
    {
        public static void Output<T1>(string name, Func<T1> method)
        {
            logevent(method);
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
                if (Console.CursorLeft == (Console.WindowWidth / 2 - name.Length / 2))
                {
                    Console.Write(name);
                }
            }

            method.Invoke();

            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n\n");
        }
        public static void Output<T1>(string name, Action<T1> method, T1 arg)
        {
            logevent(method);
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
                if (Console.CursorLeft == (Console.WindowWidth / 2 - name.Length / 2))
                {
                    Console.Write(name);
                }
            }

            method.Invoke(arg);

            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n\n");
        }
    }
    static partial class OutputInfo
    {
        public static void Output<T1, T2>(string name, Func<T1, T2> method, T1 arg)
        {
            logevent(method);
            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
                if (Console.CursorLeft == (Console.WindowWidth / 2 - name.Length / 2))
                {
                    Console.Write(name);
                }
            }

            Console.Write($"\n{method.Invoke(arg)}\n");

            while (Console.CursorLeft < Console.WindowWidth - 1)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n\n");

        }
    }
}
