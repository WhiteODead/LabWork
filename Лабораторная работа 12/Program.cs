using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
namespace Лабораторная_работа_12
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = new StreamWriter(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 12\1.txt", false);
            Console.WriteLine(Reflector.GetConstructors("Лабораторная_работа_12.Reflector"));
            foreach (string x in Reflector.GetMethodsName("Лабораторная_работа_12.Reflector"))
            {
                Console.WriteLine(x);
                streamWriter.WriteLine(x);
            }
            foreach (string x in Reflector.GetPropertiesName("Лабораторная_работа_12.Reflector"))
            {
                Console.WriteLine(x);
                streamWriter.WriteLine(x);
            }
            foreach (string x in Reflector.GetInterfaces("Лабораторная_работа_12.Reflector"))
            {
                Console.WriteLine(x);
                streamWriter.WriteLine(x);
            }
            foreach (string x in Reflector.GetMethodsName("Лабораторная_работа_12.Reflector", "String"))
            {
                Console.WriteLine(x);
                streamWriter.WriteLine(x);
            }
            streamWriter.Close();
            ParameterInfo[] parameterInfos;
            Test test = new Test();

            foreach (MethodInfo x in Type.GetType("Лабораторная_работа_12.Test").GetMethods())
            {
                if(x.Name == "HelloWorld")
                {
                    parameterInfos = x.GetParameters();
                    Reflector.Invoke(test, "HelloWorld", parameterInfos);
                }
            }

        }
    }
}
