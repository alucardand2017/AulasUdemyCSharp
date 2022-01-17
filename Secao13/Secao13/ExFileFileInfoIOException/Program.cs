using System;
using System.IO;

namespace ExFileFileInfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:/Temp/Arquivo1.txt";
            string targetPath = @"c:/Temp/Arquivo3.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string i in lines)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IOException e)
            {


                Console.WriteLine("Ocorreu erros!!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
