using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
namespace Лабораторная_работа_11
{
    class Functional
    {
        public static void Navigation(ref List<Student> studentsList, List<string> array)
        {
            while (true)
            {
                Console.WriteLine("Введите значение. 1 - Поиск по указанным параметрам, 2 - Добавление студента, 3 - Отчислить студента, 4 - Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Search(studentsList);
                            break;
                        }
                    case "2":
                        {
                            AddStudent(ref studentsList, array);
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            RemoveStudent(ref studentsList);
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            System.Environment.Exit(0);
                            Console.Clear();
                            break;
                        }
                    default: Console.WriteLine("Введено некоректное значение"); break;
                }
            }
        }
        private static void Search(List<Student> studentsList)
        {
            Console.Clear();
            string sought;
            Console.WriteLine("Введите значение параметра.\n0 - Вывод всего списка\n1 - Произвольный поиск.\n2 - Поиск по факультету.\n3 - Поиск по группе.\n4 - Поиск по курсу.\n5 - Поиск по адресу.\n6 - Поиск по дате рождения.\n7 - Поиск по уникальному номеру.\n8 - Поиск по ФИО");
            switch (Console.ReadLine())
            {
                case "0":
                    {
                        Console.Clear();
                        Text();

                        IEnumerable<Student> sequence;
                        sequence = studentsList.OrderBy(x => x.id);
                        foreach (Student x in sequence)
                            x.GetInfo(sequence);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Введите значения параметров по которым будет произведён поиск через пробел.\n2 - Поиск по факультету.\n3 - Поиск по группе.\n4 - Поиск по курсу.\n5 - Поиск по адресу.\n6 - Поиск по дате рождения.");
                        sought = Console.ReadLine();
                        CustomSearch(sought, studentsList);
                        break;
                    }
                case "2":
                    {
                        Console.Clear();

                        Console.Write("Введите факультет:");
                        sought = Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                        Console.WriteLine("Студенты факультета {0}:", sought);

                        Text();
                        SearchFaculty(studentsList, sought);

                        Console.ReadKey();
                        Console.Clear();

                        break;
                    }
                case "3":
                    {
                        Console.Clear();

                        Console.Write("Введите группу:");
                        sought = Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                        Console.WriteLine("Студенты {0} группы:", sought);

                        Text();
                        SearchGroup(studentsList, sought);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case "4":
                    {
                        Console.Clear();

                        Console.Write("Введите курс:");
                        sought = Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                        Console.WriteLine("Студенты {0} курса:", sought);

                        Text();
                        SearchCourse(studentsList, sought);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case "5":
                    {
                        Console.Clear();

                        Console.Write("Введите название улицы:");
                        sought = Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                        Console.WriteLine("Искомый(е) студент(ы):");

                        Text();
                        SearchAddress(studentsList, sought);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case "6":
                    {
                        Console.Clear();

                        Console.Write("Введите дату рождения:");
                        sought = Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                        Console.WriteLine("Искомый(е) студент(ы):");

                        Text();
                        SearchDateOfBirth(studentsList, sought);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case "7":
                    {
                        Console.Clear();

                        Console.Write("Введите уникальный номер студента:");
                        sought = Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                        Console.WriteLine("Искомый студент:");

                        Text();
                        SearchID(studentsList, sought);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case "8":
                    {
                        Console.Clear();

                        Console.Write("Введите Имя студента:");
                        sought = Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
                        Console.WriteLine("Первый студент с заданным именем:");

                        Text();
                        SearchSecondName(studentsList, sought);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
            }

        }
        private static void Text()
        {
            Console.Write("ID");
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("Фамилия");
            Console.SetCursorPosition(20, Console.CursorTop);
            Console.Write("Имя");
            Console.SetCursorPosition(40, Console.CursorTop);
            Console.Write("Отчество");
            Console.SetCursorPosition(60, Console.CursorTop);
            Console.Write("Факультет");
            Console.SetCursorPosition(80, Console.CursorTop);
            Console.Write("Курс");
            Console.SetCursorPosition(100, Console.CursorTop);
            Console.Write("Группа");
            Console.SetCursorPosition(120, Console.CursorTop);
            Console.Write("Адресс");
            Console.SetCursorPosition(160, Console.CursorTop);
            Console.Write("Телефон");
            Console.SetCursorPosition(180, Console.CursorTop);
            Console.Write("Дата рождения");
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void SearchFaculty(List<Student> studentsList, string sought)
        {
            IEnumerable<Student> sequence = studentsList.Where(x => x.Faculty == sought).OrderBy(x => x.SecondName).ThenBy(x => x.Name);
            foreach (Student x in sequence)
                x.GetInfo(sequence);
        }
        private static void SearchGroup(List<Student> studentsList, string sought)
        {
            IEnumerable<Student> sequence = studentsList.Where(x => x.Group == sought).OrderBy(x => x.SecondName);
            foreach (Student x in sequence)
                x.GetInfo(sequence);
        }
        private static void SearchCourse(List<Student> studentsList, string sought)
        {
            for (int i = 0; i < sought.Split().Length; i++)
                studentsList.FindAll(y => y.Course == sought.Split()[i]).ForEach(z => z.GetInfo(studentsList));
        }
        private static void SearchAddress(List<Student> studentsList, string sought)
        {
            for (int i = 0; i < sought.Split().Length; i++)
                studentsList.FindAll(y => y.Address.Contains(sought.Split()[i])).ForEach(z => z.GetInfo(studentsList));
        }
        private static void SearchDateOfBirth(List<Student> studentsList, string sought)
        {
            IEnumerable<Student> sequence = studentsList.OrderBy(x => x.DateOfBirth);
            sequence.Last().GetInfo(sequence);
        }
        private static void SearchID(List<Student> studentsList, string sought)
        {
            for (int i = 0; i < sought.Split().Length; i++)
                studentsList.FindAll(y => y.id == Convert.ToInt32(sought.Split()[i])).ForEach(z => z.GetInfo(studentsList));
        }
        private static void SearchSecondName(List<Student> studentsList, string sought)
        {
            studentsList.First(x => x.Name == sought).GetInfo(studentsList);
        }
        private static void CustomSearch(string sought, List<Student> studentsList)
        {
            IEnumerable<Student> filteredList = studentsList;
            string faculty = "";
            string group = "";
            string course = "";
            string dateOfBirth = "";
            string address = "";

            for (int j = 0; j < sought.Split().Length; j++)
            {
                switch (sought.Split()[j])
                {
                    case "2":
                        {
                            Console.Write("Введите факультет:");
                            faculty = Console.ReadLine();
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Введите группу:");
                            group = Console.ReadLine();
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Введите курс:");
                            course = Console.ReadLine();
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Введите название улицы:");
                            address = Console.ReadLine();
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Введите дату рождения:");
                            dateOfBirth = Console.ReadLine();
                            break;
                        }
                }
            }


            for (int k = 0; k < sought.Split().Length; k++)
            {
                switch (sought.Split()[k])
                {
                    case "2":
                        {
                            filteredList = filteredList.Where(x => x.Faculty == faculty);
                            break;
                        }
                    case "3":
                        {
                            filteredList = filteredList.Where(x => x.Group == group);

                            break;
                        }
                    case "4":
                        {
                            filteredList = filteredList.Where(x => x.Course == course);

                            break;
                        }
                    case "5":
                        {
                            filteredList = filteredList.Where(x => x.Address.Contains(address));
                            break;
                        }
                }

            }
            foreach (Student x in filteredList)
                x.GetInfo(filteredList);
            Console.ReadKey();
            Console.Clear();
        }
        private static void AddStudent(ref List<Student> studentsList, List<string> array)
        {
            string name;
            string secondName;
            string middleName;
            string faculty;
            string course;
            string group;
            string phone;
            string dateOfBirth;
            string street;
            string houseNumber;

            StreamWriter addStudents = new StreamWriter(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 3\Список студентов.txt", true, System.Text.Encoding.Unicode);
            Console.Write("Введите фамилию ");
            secondName = Validation.ValidationLetter();
            array.Add(secondName);

            Console.Write("\nВведите имя ");
            name = Validation.ValidationLetter();
            array.Add(name);

            Console.Write("\nВведите Отчество ");
            middleName = Validation.ValidationLetter();
            array.Add(middleName);

            Console.Write("\nВведите факультет. Список факультетов: ФИТ, ТОВ, ХТиТ, ПИМ ");
            faculty = Validation.ValidationFaculty();
            array.Add(faculty);

            Console.Write("\nВведите курс ");
            course = Validation.ValidationCourse();
            array.Add(course);

            Console.Write("\nВведите группу ");
            group = Validation.ValidationGroup();
            array.Add(group);

            Console.Write("\nВведите телефон в формате +375-29-xxx-xx-xx ");
            phone = Validation.ValidationPhone();
            array.Add(phone);

            Console.Write("\nВведите дату рождения в формате \"Год.Месяц.День\" ");
            dateOfBirth = Validation.ValidationDate();
            array.Add(dateOfBirth);

            Console.Write("\nВведите название улицы ");
            street = Validation.ValidationAddress();

            Console.Write("\nВведите номер дома и квартиры в формате \"20-115\"");
            houseNumber = Validation.ValidationHouseNumber();
            array.Add(street + " " + houseNumber);

            studentsList.Add(new Student(array));
            for (int i = 0; i < array.Count; i++)
            {
                if (i == 0)
                {
                    addStudents.Write("\n" + array[i] + " ");
                }
                else if (i < array.Count - 1)
                {
                    addStudents.Write(array[i] + " ");
                }
                else
                {
                    addStudents.Write(array[i]);
                }
                addStudents.Flush();
            }
            array.Clear();
        }
        private static void RemoveStudent(ref List<Student> studentsList)
        {
            Console.Clear();
            Console.WriteLine("Введите уникальный номер отчисляемого студента");
            while(true)
            {
                string a = Console.ReadLine();
                try
                {
                    int id = Convert.ToInt32(a);
                    studentsList.RemoveAt(id);
                    break;
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
            StreamWriter removeStudents = new StreamWriter(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 3\Список студентов.txt", false, System.Text.Encoding.Unicode);

            for (int i = 0; i < studentsList.Count; i++)
            {
                removeStudents.Write(studentsList[i].SecondName + " ");
                removeStudents.Write(studentsList[i].Name + " ");
                removeStudents.Write(studentsList[i].MiddleName + " ");
                removeStudents.Write(studentsList[i].Faculty + " ");
                removeStudents.Write(studentsList[i].Course + " ");
                removeStudents.Write(studentsList[i].Group + " ");
                removeStudents.Write(studentsList[i].Phone + " ");
                removeStudents.Write(studentsList[i].DateOfBirth.Day + "." + studentsList[i].DateOfBirth.Month + "." + studentsList[i].DateOfBirth.Year + " ");
                if (i == studentsList.Count - 1)
                {
                    removeStudents.Write(studentsList[i].Address);
                }
                else
                {
                    removeStudents.Write(studentsList[i].Address + "\n");
                }
                removeStudents.Flush();
            }
            removeStudents.Close();
            Program.Initialization();
        }
        public static void AgeOfStudents(DateTime date)
        {
            var today = DateTime.Now;
            var age = today.Year - date.Year;
            if (date > today.AddYears(-age))
                age--;
            Console.Write(age);
        }
    }
}
