using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_7
{
    class IsNotNameOfOrganization : ArgumentException
    {
        string Value { get; set; }
        public IsNotNameOfOrganization(string message, string value) : base(message)
        {
            Value = value;
        }
    }
    class IsNotAddress : ArgumentException
    {
        string Value { get; set; }
        public IsNotAddress(string message, string value) : base(message)
        {
            Value = value;
        }
    }
    class IsNotWebsite : Exception
    {
        string Value { get; set; }
        public IsNotWebsite(string message, string value) : base(message)
        {
            Value = value;
        }
    }
}
