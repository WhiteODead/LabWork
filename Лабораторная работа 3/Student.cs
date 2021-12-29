using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_3
{
    public partial class Student
    {
        const int CONSTANTA = 5;
        public static int i;
        public readonly int id;
        private string name;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        private string secondName;
        public string SecondName
        {
            set
            {
                secondName = value;
            }
            get
            {
                return secondName;
            }
        }
        private string middleName;
        public string MiddleName
        {
            set
            {
                middleName = value;
            }
            get
            {
                return middleName;
            }
        }
        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            set
            {
                dateOfBirth = value;
            }
            get
            {
                return dateOfBirth;
            }
        }
        private string address;
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        private string phone;
        public string Phone
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }
        private string faculty;
        public string Faculty
        {
            set
            {
                faculty = value;
            }
            get
            {
                return faculty;
            }
        }
        private string course;
        public string Course
        {
            set
            {
                course = value;
            }
            get
            {
                return course;
            }
        }
        private string group;
        public string Group
        {
            set
            {
                group = value;
            }
            get
            {
                return group;
            }
        }
        static Student()
        {
            i = 0;
        }
        public Student()
        {

        }
        //private Student()
        //{

        //}
        public int test1;
        public int test2;
        public int test3;
        public Student(List<string> array)
        {
            id += i;
            i++;
            secondName = array[0];
            name = array[1];
            middleName = array[2];
            faculty = array[3];
            course = array[4];
            group = array[5];
            phone = array[6];
            dateOfBirth = DateTime.Parse(array[7]);
            address = array[8];
        }
    }
    public partial class Student
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public void GetInfo(List<Student> studentsList)
        {
            Console.Write(id);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write(secondName);
            Console.SetCursorPosition(20, Console.CursorTop);
            Console.Write(name);
            Console.SetCursorPosition(40, Console.CursorTop);
            Console.Write(middleName);
            Console.SetCursorPosition(60, Console.CursorTop);
            Console.Write(faculty);
            Console.SetCursorPosition(80, Console.CursorTop);
            Console.Write(course);
            Console.SetCursorPosition(100, Console.CursorTop);
            Console.Write(group);
            Console.SetCursorPosition(120, Console.CursorTop);
            Console.Write(address);
            Console.SetCursorPosition(160, Console.CursorTop);
            Console.Write(phone);
            Console.SetCursorPosition(180, Console.CursorTop);
            Console.Write(dateOfBirth.Day + "." + dateOfBirth.Month + "." + dateOfBirth.Year);
            Console.SetCursorPosition(200, Console.CursorTop);
            Functional.AgeOfStudents(dateOfBirth);
            Console.WriteLine();
        }
        public void RefOut(ref string a, out string b)
        {
            b = "asd";
        }
    }
}
