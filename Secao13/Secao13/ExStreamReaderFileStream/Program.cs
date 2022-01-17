using System;
using System.IO;

namespace ExStreamReaderFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\Arquivo1.txt";
           
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path); //O File.OpenText abre implicitamente a classe FileStream e instancia o StreamReader por ele.
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message); ;
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }

            //MODO MAIS VERBOSO
            //string path = "c:\\temp\\Arquivo1.txt"; 
            //FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (IOException e)
            //{

            //    Console.WriteLine(e.Message); ;
            //}
            //finally
            //{
            //    if (sr != null)
            //        sr.Close();
            //    if (fs != null)
            //        fs.Close();
            //}


        }
    }
}
