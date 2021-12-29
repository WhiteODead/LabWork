using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа_10
{
    class Game:IEnumerable
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public Game(string name, DateTime releaseDate, string description)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Description = description;
        }
        public Game(string name, DateTime releaseDate)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Description = "";
        }
        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            return Name + "\n" + ReleaseDate + "\n" + Description;
        }
    }
}
