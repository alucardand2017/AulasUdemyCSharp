using System;
using System.IO;

namespace ExUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\Arquivo1.txt";
            try
            {
                //o bloco using é utilizado pq já tem um tratamento para fechar arquivos que estejam sendo lidos pelo sistema operacional (fora do gerenciamento da CLR)
                using (StreamReader sr = File.OpenText(path)) //utilizando o File.OpenText, que já instancia implicitamente o FileStream e associa ele ao StreamReadr
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro", e.Message);
            }
            //string path = @"c:\Temp\Arquivo1.txt";
            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Ocorreu um erro", e.Message);
            //}

        }
    }
}


