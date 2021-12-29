using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using System.IO;
namespace Лабораторная_работа_12
{
    public class Test
    {
        public void HelloWorld(string className)
        {
            Console.WriteLine(className);
        }
    }
    public static class Reflector
    {
        static Reflector()
        {

        }
        public static string GetAssemblyName(string className)
        {
            return Assembly.GetAssembly(Type.GetType("System.Reflection.Assembly")).FullName;
        }
        public static string GetConstructors(string className)
        {
            if (Type.GetType(className).GetConstructors().Length > 0)
                return "Да";
            else
                return "Нет";
        }
        public static IEnumerable<string> GetMethodsName(string className)
        {
            List<string> list = new List<string>();
            foreach (MethodInfo x in Type.GetType(className).GetMethods())
                list.Add(x.Name);
            return list;
        }
        public static IEnumerable<string> GetPropertiesName(string className)
        {
            List<string> list = new List<string>();
            foreach (FieldInfo x in Type.GetType(className).GetFields())
                list.Add(x.Name);
            foreach (PropertyInfo x in Type.GetType(className).GetProperties())
                list.Add(x.Name);
            return list;
        }
        public static IEnumerable<string> GetInterfaces(string className)
        {
            List<string> list = new List<string>();
            foreach (Type x in Type.GetType(className).GetInterfaces())
                list.Add(x.Name);
            return list;
        }
        public static IEnumerable<string> GetMethodsName(string className, string parameter)
        {
            List<string> list = new List<string>();
            IEnumerable<ParameterInfo> parameterInfos;
            foreach (MethodInfo x in Type.GetType(className).GetMethods())
            {
                parameterInfos = x.GetParameters().Where(x => x.ParameterType.Name == parameter);
                foreach (ParameterInfo y in parameterInfos)
                    list.Add(x.Name);
            }
            return list;
        }
        public static void Invoke(object obj, string methodName, ParameterInfo[] parameterInfos)
        {
            StreamReader parameters = new StreamReader(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 12\Parameters.txt");
            string[] parameter = new string[1];
            parameter[0] = parameters.ReadLine();
            MethodInfo method = Type.GetType("Лабораторная_работа_12.Test").GetMethod(methodName);
            method.Invoke(obj, parameter);
            parameters.Close();
        }
        static public object Create(string classname, string name)
        {
            object obj = Activator.CreateInstance(Type.GetType(classname), args: name);
            return obj;
        }
    }
}
