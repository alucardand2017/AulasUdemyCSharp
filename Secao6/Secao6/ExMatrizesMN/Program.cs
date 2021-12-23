using System;

namespace ExMatrizesMN
{
    class Program
    {
        static void Main(string[] args)
        {
            int mLinhas = 1;
            int nColunas = 1;
            Console.WriteLine("Digite o numero de linhas e colunas da matriz: Ex: (5 4)");
            try
            {
                string[] tamanho = Console.ReadLine().Split(' ');
                mLinhas = int.Parse(tamanho[0]);
                nColunas = int.Parse(tamanho[1]);

                if (mLinhas <= 0 || nColunas <= 0)
                {
                    nColunas = mLinhas = 1;
                    throw new ArgumentException(" Ordem da Matriz deve ser um número natural! Colocado a matriz 1x1 como padrão! ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Erro de argumento inválido! " + ex.Message);
            } //pega o numero de linhas e colunas da matriz
            int[,] matrizN = new int[mLinhas, nColunas];
            Console.WriteLine("\n-------------------");
            try
            {
                Arranjo(matrizN, mLinhas, nColunas);
                ImprimePosicao(matrizN, mLinhas, nColunas);

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Erro no preenchimento da Matriz! ", ex.Message);
            } //preenche a matriz e escolhe o numero que será observado
        }
        private static void Arranjo(int[,] M, int _mLinhas, int _nColunas)
        {
            Console.WriteLine("Digite as linhas com os elementos separados entre espaços");
            for (int i1 = 0; i1 < _mLinhas; i1++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j1 = 0; j1 < _nColunas; j1++)
                {
                    M[i1, j1] = int.Parse(values[j1]);
                }
            }
            Console.WriteLine("\n-------------------");
        } // transforma a linha string na linha da matriz int
        private static void ImprimePosicao(int[,] M, int _mL, int _nC)
        {
            int escolha = int.Parse(Console.ReadLine());
            for (int i = 0; i < _mL; i++)
            {
                for (int j = 0; j < _nC; j++)
                {
                    if (M[i, j] == escolha)
                    {
                        Console.Write("\nPosition: ({0},{1}) \n", i, j);
                        //NumerosAdjacentes(M, _mLinhas, _nColunas, i, j);
                        if (j != 0)
                        {
                            Console.Write("Left: {0}.\n", M[i, j - 1]);

                        }
                        if (j < (_nC-1))
                        {
                            Console.Write("Right: {0}.\n", M[i, j + 1]);

                        }
                        if (i != 0)
                        {
                            Console.Write("Up: {0}.\n", M[i - 1, j]);

                        }
                        if (i != (_mL-1))
                        {
                            Console.Write("Down: {0}.\n", M[i + 1, j]);

                        }
                    }
                }
            }
            Console.WriteLine("\n-------------------");
        } // pega a escolha do numero observado e imprime os resultado em tela, fazendo as ponderações.
    }
}
