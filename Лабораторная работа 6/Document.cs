using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_6
{
    abstract class Document
    {
        protected internal string title;
        protected internal Client client;
        protected internal Organization organization;
        protected internal DateTime dateOfIssue;
        public abstract void GetInfo();
    }
}
