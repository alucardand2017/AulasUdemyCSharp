using System;
using System.Collections.Generic;
using System.Text;

namespace ProdutoEstoque
{
    class Produto
    {
        public string nome;
        public double preco;
        public int qnt;

        public Produto(string nome , double preco, int qnt)
        {
            this.nome = nome;
            this.preco = preco;
            this.qnt = qnt;
        }
        public  double ValorTotalEmEstoque()
        {
            return preco * qnt;
        }
        public  void AdicionarProdutor(int add)
        {
            qnt += add;
        }
        public  void RemoverProdutos(int sub)
        {
            if(sub > qnt) Console.WriteLine("Quantidade de produtos no estoque não é suficiente! refaça a operação. Qnt atual = {0}", qnt);
            else qnt -= sub;
        }
        public  void DadosProduto()
        {
            Console.WriteLine("\n NOME: {0} \n PREÇO: {1} \n ESTOQUE: {2} \n VALOR DE ESTOQUE: {3}", nome, preco, qnt, ValorTotalEmEstoque());
        }
    }
}
