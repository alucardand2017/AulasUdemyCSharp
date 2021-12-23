using System;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto arroz = new Produto(" Arroz Camil", 10.00, 50);
            Produto feijao = new Produto(" Feijao TioJoao", 15.00, 100);
            Produto bisnaga = new Produto("Bisnaga Panco", 5.00, 50);

            arroz.DadosProduto();
            feijao.DadosProduto();
            bisnaga.DadosProduto();

            arroz.RemoverProdutos(10);
            feijao.RemoverProdutos(100);
            bisnaga.AdicionarProdutor(100);

            arroz.DadosProduto();
            feijao.DadosProduto();
            bisnaga.DadosProduto();

            
        }
    }
}
