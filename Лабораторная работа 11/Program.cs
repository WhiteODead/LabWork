using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
namespace Лабораторная_работа_11
{
    class Program
    {
        string[] facultys = { "ФИТ", "ХТиТ", "ТОВ", "ПИМ" };
        static List<string> array = new List<string>();
        static List<Student> studentsList = new List<Student>();
        static string line;
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Оттава Сенаторз", Country ="Канада" },
                new Team { Name = "Сиэтл Кракен", Country ="США" }
            };
            List<Player> players = new List<Player>()
            {
            new Player {Name="Мэтт Мюррей", Team="Оттава Сенаторз"},
            new Player {Name="Тома Шабо", Team="Оттава Сенаторз"},
            new Player {Name="Томми Томпсон", Team="Сиэтл Кракен"}
            };
            var result = players.Join(teams, p => p.Team, t => t.Name, (p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country });
            foreach (var item in result)//Join - Сцепляет элементы указанного массива или элементы коллекции, помещая между ними заданный разделитель
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");
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
