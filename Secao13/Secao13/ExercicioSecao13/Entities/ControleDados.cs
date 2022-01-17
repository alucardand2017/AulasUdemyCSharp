using System.Collections.Generic;
using System.IO;
using System.Globalization;
namespace ExercicioSecao13.Entities
{
    class ControleDados
    {
        public static void GerarRelatorio(string path, string targetPath) //recebe os caminhos
        {
            List<FichaProduto> lista = new List<FichaProduto>(); //lista para calculos
            using (StreamReader sr = File.OpenText(path)) //abre comunicação com arguivo
            {
                while (!sr.EndOfStream) //até o final
                {
                    string line = sr.ReadLine(); //le uma linha do arquivo
                    string[] aux = line.Split(","); //armazena numa matriz de strings separando os elementos por virgula no arquivo de origem
                    //adiciona na lista de produtos essas strings, armazenando com o tipo correto.
                    lista.Add(new FichaProduto(aux[0], double.Parse(aux[1], CultureInfo.InvariantCulture), 
                        int.Parse(aux[2], CultureInfo.InvariantCulture)));
                }
            }
            Directory.CreateDirectory(Path.GetDirectoryName(targetPath)); //cria diretório usando a função do Path para pegar apenas o nome do diretorio
            using (StreamWriter sw = File.AppendText(targetPath)) // cria arquivo a partir do caminho dado, ou o abre caso ja esteja criado.
            {
                foreach (FichaProduto ficha in lista)
                {
                    sw.WriteLine(ficha.Nome + "," + ficha.ValorBruto().ToString("F2", CultureInfo.InvariantCulture)); //armazena os dados no formato que o exercicio exige.
                }
            }
        }
    }
}
