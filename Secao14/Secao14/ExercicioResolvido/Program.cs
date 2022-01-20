using System;
using System.IO;
using System.Collections.Generic;
using ExercicioResolvido.Entities;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> set = new HashSet<LogRecords>();
            string path = @"c:\temp\in.txt";//Console.ReadLine();
            Console.WriteLine("Enter file full path: " + path);
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime time = DateTime.Parse(line[1]);
                        set.Add(new LogRecords(name, time));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
