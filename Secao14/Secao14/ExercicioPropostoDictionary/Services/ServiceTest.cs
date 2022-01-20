using System;
using System.Collections.Generic;
using System.IO;
namespace ExercicioPropostoDictionary.Services
{
    class ServiceTest
    {
    public static void Contabilizacao(Dictionary<string, int> Resultados, string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] canditadoEvoto = sr.ReadLine().Split(',');

                    if (Resultados.ContainsKey(canditadoEvoto[0]))
                    {
                        int value = Resultados[canditadoEvoto[0]];
                        Resultados[canditadoEvoto[0]] = value + int.Parse(canditadoEvoto[1]);
                    }
                    else
                        Resultados.Add(canditadoEvoto[0], int.Parse(canditadoEvoto[1]));
                }
            }
            foreach (var obj in Resultados)
            {
                Console.WriteLine(obj.Key + " : " + obj.Value);
            }
        }

    }
}
