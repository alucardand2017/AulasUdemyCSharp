using System;
using System.IO;
using System.Collections.Generic;
namespace ExDirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\myfolder";
            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //contabiliza pastas.
                Console.WriteLine("FOLDERS:");
                foreach(string i in folders)
                {
                    Console.WriteLine(i);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //contabiliza arquivos de pastas e subpastas.
                Console.WriteLine("FILERS:");
                foreach (string i in files)
                {
                    Console.WriteLine(i);
                }
                Directory.CreateDirectory(path + @"\newfolder"); //cria pasta
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
