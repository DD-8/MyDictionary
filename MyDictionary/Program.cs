using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> cities = new MyDictionary<string, string>();

            cities.Add("1", "Ankara");
            cities.Add("2", "İstanbul");

            cities.GetAll();
        }
    }
}
