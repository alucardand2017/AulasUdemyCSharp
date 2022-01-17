using System;
using System.IO;

namespace ExStreamWriter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Temp\Arquivo1.txt";
            string targetPath = @"c:\Temp\Arquivo3.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
