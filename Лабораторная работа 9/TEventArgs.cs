using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_9
{
    class TEventArgs:EventArgs
    {
        public string Name { get; set; }
        public static int Count { get; set; }
        public string Message { get; set; }
        public DateTime TimeOfEvent { get; set; }
        public TEventArgs(string name, string message)
        {
            Count++;
            Name = name;
            Message = message;
            TimeOfEvent = DateTime.Now;
        }
    }
}
