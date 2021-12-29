using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
namespace Лабораторная_работа_3
{
    class Program
    {
        string[] facultys = { "ФИТ", "ХТиТ", "ТОВ", "ПИМ" };
        static List<string> array = new List<string>();
        static List<Student> studentsList = new List<Student>();
        static string line;
        static void Main(string[] args)
        {
            var user = new
            {
                Name = "Abcd",
                Age = 42
            };
            //Console.WriteLine(user.Name + " - " + user.Age + " years old");

            //DateTime date = new DateTime();
            //var today = DateTime.Now;
            //Console.WriteLine(today);
            //Console.WriteLine(date);
            //var age = today.Year - date.Year;
            //if (date > today.AddYears(-age)) age--;
            Initialization();
            Functional.Navigation(ref studentsList, array);
        }
        public static void Initialization()
        {
            StreamReader students = new StreamReader(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 3\Список студентов.txt");
            studentsList.RemoveAll(x => x.Faculty!= "32771488228");
            Student.i = 0;
            while ((line = students.ReadLine()) != null)
            {
                for (int i = 0; i < line.Split().Length; i++)
                {
                    array.Add(line.Split()[i]);
                }
                for (int j = 9; j < array.Count; j++)
                {
                    array[j - 1] = array[j - 1] + " " + array[j];
                    array.Remove(array[j]);
                    j--;
                }
                studentsList.Add(new Student(array));
                array.Clear();
            }
            students.Close();
        }
    }
}
