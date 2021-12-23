namespace Secao4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();
            ColetaDatos.InsercaoDados(func1);
            ColetaDatos.InsercaoDados(func2);
            ImprimeDados.Imprimir(func1);
            ImprimeDados.Imprimir(func2);
            Media.MediaSalario(func1, func2);
        }
    }
}
