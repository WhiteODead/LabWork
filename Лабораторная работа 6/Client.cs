using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_6
{
    partial class Client : IGetInformation
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public Client(string name, string secondName, string address, DateTime dateOfBitrhday)
        {
            Name = name;
            SecondName = secondName;
            Address = address;
            DateOfBirthday = dateOfBitrhday;
        }
    }
}
