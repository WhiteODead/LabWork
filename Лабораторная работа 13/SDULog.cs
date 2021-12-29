using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
namespace Лабораторная_работа_13
{
    class SDULog
    {
        public static void Log(Delegate @delegate)
        {
            StreamWriter writer = new StreamWriter(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 13\bin\Debug\files\sdulogfile.txt", true);
            writer.Write($"Вызван метод \"{@delegate.Method.Name}\", ");
            writer.Write($"Время вызова: {DateTime.Now}\n");
            writer.Close();
        }
    }
}
