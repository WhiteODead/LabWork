using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace Лабораторная_работа_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> list = new List<Game>();
            Game witcher3 = new Game("The Witcher 3: Wild Hunt", new DateTime(2015, 05, 18));
            Game hota = new Game("Heroes of Might and Magic 3: Horn of the Abyss", new DateTime(2008, 05, 6));
            Game dota2 = new Game("Defense of the Ancients 2", new DateTime(2013, 07, 9));
            Game csgo = new Game("Counter-Strike: Global Offensive", new DateTime(2012, 08, 21));
            list.Add(witcher3);
            list.Add(hota);
            list.Add(dota2);
            list.Add(csgo);
            foreach (Game game in list)
                Console.WriteLine(game.ToString());
            BlockingCollection<int> collection = new BlockingCollection<int>();
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            collection.Add(4);
            collection.Add(5);
            foreach (int x in collection)
                Console.WriteLine(x);
            Console.WriteLine("//////");
            for (int i = 0; i < 3; i++)
            {
                collection.Take();
            }
            collection.TryAdd(6);
            collection.TryAdd(6);
            List<int> collection2 = new List<int>(collection);
            foreach (int x in collection2)
                Console.WriteLine(x);
            Console.WriteLine("//////");
            collection2.FindAll(x => x == 6).ForEach(x => Console.WriteLine(x));


            static void Ch(object sender, NotifyCollectionChangedEventArgs e)
            {
                Console.WriteLine("Коллекция изменилась с действием: " + e.Action);
            }
            ObservableCollection<Game> obs = new ObservableCollection<Game>();
            obs.CollectionChanged += Ch;
            obs.Add(witcher3);
            obs.Remove(witcher3);
        }
    }
}
