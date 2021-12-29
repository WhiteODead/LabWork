using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_2
{
    class FirstTask
    {
        static public void FirstSubTask()
        {
            int n1; uint n2; long n3; ulong n4; short n5; ushort n6; byte n7; sbyte n8; float f; double d; decimal de; char c; bool b; string str; object ob;
            void Output()
            {
                Console.Clear();
                Console.WriteLine("Задание 1а");
                Console.WriteLine("Int number: {0}", n1);

                Console.WriteLine("UInt number: {0}", n2);

                Console.WriteLine("Long number: {0}", n3);

                Console.WriteLine("ULong number: {0}", n4);

                Console.WriteLine("Short number: {0}", n5);

                Console.WriteLine("UShort number: {0}", n6);

                Console.WriteLine("Byte number: {0}", n7);

                Console.WriteLine("SByte number: {0}", n8);

                Console.WriteLine("Float number: {0}", f);

                Console.WriteLine("Double number: {0}", d);

                Console.WriteLine("Decimal number: {0}", de);

                Console.WriteLine("Char: {0}", c);

                Console.WriteLine("Bool: {0}", b);

                Console.WriteLine("String: {0}", str);

                Console.WriteLine("Object: {0}", ob);

            }
            void Input()
            {
                Console.WriteLine("Write int:");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write uint:");
                n2 = Convert.ToUInt32(Console.ReadLine());

                Console.WriteLine("Write long:");
                n3 = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Write ulong:");
                n4 = Convert.ToUInt64(Console.ReadLine());

                Console.WriteLine("Write short:");
                n5 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Write ushort:");
                n6 = Convert.ToUInt16(Console.ReadLine());

                Console.WriteLine("Write byte:");
                n7 = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Write sbyte:");
                n8 = Convert.ToSByte(Console.ReadLine());

                Console.WriteLine("Write float:");
                f = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Write double:");
                d = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Write decimal:");
                de = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Write char:");
                c = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Write bool:");
                b = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Write string:");
                str = Console.ReadLine();

                Console.WriteLine("Write object:");
                ob = Console.ReadLine();
            }
            Input();
            Output();

        }
        static public void SecondSubTask()
        {
            void ImplicitConversion()
            {
                byte n1 = 54;
                short n2 = n1;
                int n3 = n1;
                long n4 = n1;
                ulong n5 = n1;
                Console.WriteLine("Implicit conversions:\n\nByte: {0},\nshort: {1},\nint: {2},\nlong: {3},\nulong: {4}", n1, n2, n3, n4, n5);
            }
            void ExplicitConversion()
            {
                Console.WriteLine("Explicit conversions:\n");
                int n1 = 4;
                byte n2 = (byte)(n1);
                Console.WriteLine("Int: {0}, byte: {1}\n", n1, n2);

                short s1 = 4;
                short s2 = (short)(s1 + 70);
                Console.WriteLine("Short: {0}, short: {1}\n", s1, s2);

                short q1 = 45;
                byte q2 = (byte)q1;
                Console.WriteLine("Short: {0}, byte: {1}\n", q1, q2);

                char w1 = '9';
                int w2 = (int)(w1);
                Console.WriteLine("Char: {0}, int: {1}\n", w1, w2);

                double d1 = 155.5247;
                float d2 = (float)(d1);
                Console.WriteLine("Double: {0}, float: {1}\n", d1, d2);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 1b");
            ImplicitConversion();
            ExplicitConversion();
        }
        static public void ThirdSubTask()
        {
            void Boxing()
            {
                int TypeInt = 123;
                object TypeObject = TypeInt;
                Console.WriteLine("Упаковка: {0}\n", TypeObject);
                Unboxing(TypeObject);
            }
            void Unboxing(object args)
            {
                int b3 = (int)args;
                Console.WriteLine("Распаковка: {0}\n", b3);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 1c");
            Boxing();
        }
        static public void FourthSubTask()
        {
            var n1 = 100;
            var n2 = 548.5788;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 1d");
            Console.WriteLine("n1 + n2 = {0}\n", n1 + n2);
        }
        static public void FifthSubTask()
        {
            int? x = null;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Задание 1e");
            Console.WriteLine("Value of x: {0}\n", x);
        }
        static public void SixthSubTask()
        {
            //var TypeDouble = 124.5;
            //TypeDouble = "string";
        }
    }
}
