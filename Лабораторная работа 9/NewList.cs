using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_9
{
    delegate void Fun();
    class NewList<T>
    {
        private List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public void Remove()
        {
            Fun func = Remove;
            TEventArgs args = new TEventArgs(func.Method.Name, "Произошло событие, удаляется первый элемент списка.");
            EventHandler<TEventArgs> handler = Programmer.ReturnEvent(func);
            if(handler != null)
            {
                handler(this, args);
            }
        }
        public void Mutate()
        {
            Fun func = Mutate;
            TEventArgs args = new TEventArgs(func.Method.Name, "Произошло событие, выполняется случайная перестановка элементов.");
            EventHandler<TEventArgs> handler = Programmer.ReturnEvent(func);
            if (handler != null)
            {
                handler(this, args);
            }
        }
        public void RemoveFirstElement(object o, TEventArgs e)
        {
            Console.WriteLine($"{e.Message} Имя события: \"{e.Name}\". Время наступления: {e.TimeOfEvent}. Номер события: {TEventArgs.Count}");
            if(list.Count != 0)
            {
                list.RemoveAt(0);
            }
        }
        public void Shuffle(object o, TEventArgs e)
        {
            Random rand = new Random();
            Console.WriteLine($"{e.Message} Имя события: \"{e.Name}\". Время наступления: {e.TimeOfEvent}. Номер события: {TEventArgs.Count}");
            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
        }
        public void View()
        {
            Console.Write($"\nСписок: ");
            list.ForEach(x => Console.Write(x + " "));
            Console.Write("\n");
        }
    }
}
