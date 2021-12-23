using System;

namespace ExMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordem = 1;
            Console.WriteLine("Digite a ordem da matriz:");
            try
            {
                ordem = int.Parse(Console.ReadLine());
                if (ordem <= 0)
                {
                    ordem = 1;
                    throw new ArgumentException(" Ordem da Matriz deve ser um número natural! Colocado a matriz 1x1 como padrão! ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Erro de argumento inválido! " + ex.Message);
            }
            string[,] matriz = new string[ordem, ordem];
            int[,] matrizN = new int[ordem, ordem];
            Console.WriteLine("\n-------------------");
            try
            {
                Arranjo(matrizN, ordem);
                Imprime(matrizN, ordem);
                //TransformaMatriz(matriz, matrizN, ordem);
                DiagonalPrincipal(matrizN, ordem);
                NumerosNegativos(matrizN, ordem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Erro no preenchimento da Matriz! ", ex.Message);
            }
        }
        private static void Arranjo(int[,] M, int _ordem)
        {
            Console.WriteLine("Digite as lihas com os elementos separados entre espaços");
            for (int i = 0; i < _ordem; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < _ordem; j++)
                {
                    M[i,j] = int.Parse(values[j]);
                }
                //método sem usar a função SPLIT do console.ready().
                //string linha = Console.ReadLine();
                //for (int j = 0; j < _ordem; j++)
                //{
                //    foreach (char a in linha)
                //    {
                //        if (a == ' ')
                //        {
                //            j++;
                //        }
                //        M[i, j] += a;
                //    }
                //}
            }
            Console.WriteLine("\n-------------------");
        }
        private static void Imprime(int[,] matriz, int ordem)
        {
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n-------------------");
        }
        private static void DiagonalPrincipal(int[,] _matrizN, int _ordem)
        {
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < _ordem; i++)
            {
                for (int j = 0; j < _ordem; j++)
                {
                    if (i == j)
                        Console.Write(_matrizN[i, j] + " ");
                }
            }
            Console.WriteLine("\n----------------");
        }
        private static void NumerosNegativos(int[,] _matrizN, int _ordem)
        {
            int contadorNegativo = 0;
            for (int i = 0; i < _ordem; i++)
            {
                for (int j = 0; j < _ordem; j++)
                {
                    if (_matrizN[i, j] < 0)
                        contadorNegativo++;
                }

            }
            Console.WriteLine("Negative Numbers: " + contadorNegativo);
        }
        //private static void TransformaMatriz(string[,] matriz, int[,] matrizN, int _ordem)
        //{
        //    for (int i = 0; i < _ordem; i++)
        //    {

        //        for (int j = 0; j < _ordem; j++)
        //        {
        //            matrizN[i, j] = int.Parse(matriz[i, j]);
        //        }
        //    }
        //}
    }
}
