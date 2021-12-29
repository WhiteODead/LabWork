using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Лабораторная_работа_4
{
    public class NewStack<T> : Stack<T>
    {
        public class Owner
        {
            public string Id { get; }
            public string Name { get; }
            public string Organization { get; }

            public Owner()
            {
                Console.Write("Введите Id: ");
                Id = Console.ReadLine();
                Console.Write("Введите Имя создателя: ");
                Name = Console.ReadLine();
                Console.Write("Введите название организации: ");
                Organization = Console.ReadLine();
            }
            public Owner(string id, string name, string organization)
            {
                Id = id;
                Name = name;
                Organization = organization;
            }
        }
        public class Date
        {
            public DateTime dateOfCreation { get; }
            public Date()
            {
                dateOfCreation = DateTime.Now;
            }
        }



        public Date NewDate { get; }
        public Owner NewOwner { get; }
        public NewStack()
        {
            this.NewDate = new Date();
            this.NewOwner = new Owner();
        }
        public NewStack(string id, string name, string organization)
        {
            this.NewDate = new Date();
            this.NewOwner = new Owner(id, name, organization);
        }
        


        public static NewStack<T> operator *(NewStack<T> first, T second)
        {
            first.Push(second);
            return first;
        }
        public static NewStack<T> operator *(T first, NewStack<T> second)
        {
            second.Push(first);
            return second;
        }
        public static NewStack<T> operator /(NewStack<T> first, T second)
        {
            foreach(T x in first)
            {
                if(x.Equals(second))
                {
                    first.Pop();
                    Console.WriteLine("Элемент успешно удалён");
                    return first;
                }
            }
            Console.WriteLine("В стеке нет данного элемента");
            return first;
        }
        public static NewStack<T> operator /(T first, NewStack<T> second)
        {
            foreach (T x in second)
            {
                if (x.Equals(first))
                {
                    second.Pop();
                    Console.WriteLine("Элемент успешно удалён");
                    return second;
                }
            }
            Console.WriteLine("В стеке нет данного элемента");
            return second;
        }
        public static bool operator true(NewStack<T> first)
        {
            foreach (T x in first)
            {
                if (Convert.ToInt32(x) < 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator false(NewStack<T> first)
        {
            foreach (T x in first)
            {
                if (Convert.ToInt32(x) < 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator ==(NewStack<T> first, NewStack<T> second)
        {
            if (first.Count == second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (!first.ToArray()[i].Equals(second.ToArray()[i]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(NewStack<T> first, NewStack<T> second)
        {
            if (first.Count == second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (!first.ToArray()[i].Equals(second.ToArray()[i]))
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
