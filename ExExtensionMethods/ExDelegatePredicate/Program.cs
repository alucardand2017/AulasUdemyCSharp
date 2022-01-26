using System;
using ExDelegatePredicate.Entities;
using System.Collections.Generic;

namespace ExDelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();
            list.Add(new Products("Tv", 900.00));
            list.Add(new Products("Mouse", 50.00));
            list.Add(new Products("Tablet", 350.50));
            list.Add(new Products("HD Case", 80.90));

            list.RemoveAll(p => p.Price >= 100);
            foreach(Products p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}


