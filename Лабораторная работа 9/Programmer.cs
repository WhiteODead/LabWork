using System;
using System.Collections.Generic;
using System.Text;
namespace Лабораторная_работа_9
{
    class Programmer
    {
        public static event EventHandler<TEventArgs> remove;
        public static event EventHandler<TEventArgs> mutate;
        public static EventHandler<TEventArgs> ReturnEvent(Delegate func)
        {
            if (func.Method.Name == "Remove")
                return remove;
            else if (func.Method.Name == "Mutate")
                return mutate;
            return null;
        }
    }
}
