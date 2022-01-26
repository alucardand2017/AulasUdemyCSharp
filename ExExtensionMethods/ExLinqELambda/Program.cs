﻿using System;
using System.Linq;
using ExLinqELambda.Entities;
using System.Collections.Generic;


namespace ExLinqELambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> produtcs = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.00, Category = c2},
                new Product() {Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            //condição de Tier = 1 e Price < 900
            //var r1 = produtcs.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            var r1 =
                from p in produtcs
                where p.Category.Tier == 1 && p.Price < 900.00
                select p;
            Print("TIER 1 AND PRICE < 900.00", r1);

            //condição de Category.Name == "Tools" instanciando apenas o nome
            //var r2 = produtcs.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in produtcs
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAME OF PRODUCTS FROM \'TOOLS\' ", r2);


            //condição com Name começando com 'C' e instanciando um conjunto com o nome, preço e nome da categoria
            //var r3 = produtcs.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in produtcs
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("NAMES STARTED WITH \'C\' AND ANONYMOUS OBJECT", r3);

            //condição com o Tier == 1 e ordenando por preço e depois por nome
            //var r4 = produtcs.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in produtcs
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);


            //condição de pular os dois primeiros e pegar os proximos quatro.
            //var r5 = produtcs.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p)
                 .Skip(2)
                 .Take(4);
            Print("SKIPPED TWO AND TAKE FOUR FOWARD", r5);
            //AS DEMAIS ABAIXO SÃO DE MESMA SINTAXE QUE A ACIMA.
            //condição para retornar uma pesquisa sem dar erro como no First.
            var r6 = produtcs.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("WHEM THE QUERY RETURN A NULL LIST: " + r6);
            //condição para retornar o primeiro objeto ou nulo no caso de conjunto vazio.
            var r7 = produtcs.FirstOrDefault();
            Console.WriteLine("RETURNS A FIRST PRODUCT OF THE LIST: " + r7);
            //pega o elemento segundo a condição. Se tiver mais que 1 elemento dá erro.
            var r8 = produtcs.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT IN TEST1: " + r8);
            //idem o de cima, retornando vazio pela condição da função lambda.
            var r9 = produtcs.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT IN TEST2: " + r9);

            Console.WriteLine();
            var r10 = produtcs.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = produtcs.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);
            var r12 = produtcs.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            var r13 = produtcs.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);
            var r14 = produtcs.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);
            var r15 = produtcs.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            //agrupamento realizado por categoria
            //var r16 = produtcs.GroupBy(p => p.Category);
            var r16 =
                from p in produtcs
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                    Console.WriteLine(p);
                Console.WriteLine();
            }
            //agrupamento realizado por tier
            var r17 = produtcs.GroupBy(p => p.Category.Tier);
            foreach (IGrouping<int,Product> group in r17)
            {
                Console.WriteLine("Tier " + group.Key + ":");
                foreach (Product p in group)
                    Console.WriteLine(p);
                Console.WriteLine();
            }
        }
    }
}
