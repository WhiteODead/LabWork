using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_8
{
    public interface IInterection<T>
    {
        void Add(T item);
        void Remove(Predicate<T> predicate);
        void View(Predicate<T> predicate);
    }
}
