using System;
using System.Collections.Generic;

namespace ExHashSetESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            //PrintCollection(a);

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //união dos elementos de b em c que não estão em c
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);


            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("notebook"));
            foreach(string i in set)
                Console.WriteLine(i);
        }
        static void PrintCollection<T>(IEnumerable<T> collection) //IEnumerable é uma forma de percorrer coleções. É uma interface implementada por todos os pacotes do system.collections. Enumerator é um padrão de projeto.
        {
            foreach (T obj in collection) //foreach pode ser utilizado numa classe genérica graças a implementação por IEnumerable<T>
                Console.Write(obj + " ");
            Console.WriteLine();
        }
    }
}
