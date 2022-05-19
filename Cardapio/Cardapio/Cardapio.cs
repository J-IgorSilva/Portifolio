using CardapioConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardapioConsole
{
    public static class Cardapio
    {
        public static List<Produto> Produtos = ObterProdutosParaCardapio();

        private static List<Produto> ObterProdutosParaCardapio()
        {
            return new List<Produto>
            {
                new Produto(100, "CACHORRO QUENTE", 5.70M),
                new Produto(101, "X COMPLETO", 18.30M),
                new Produto(102, "X SALADA", 16.50M),
                new Produto(103, "HAMBUGUERE", 22.40M),
                new Produto(104, "COCA 2L", 10.00M),
                new Produto(105, "REFRIGERANTE", 1.00M)
            };
        }

        public static Produto ObterProdutoPeloCodigo(int codigo)
        {
            var produto = Produtos.FirstOrDefault(x => x.CodigoProduto == codigo);
            return produto;
        }
        public static Produto ObterPreco(int preco)
        {
            var valortotalpreco = Produtos.FirstOrDefault(x => x.Preco == preco);
            return valortotalpreco;
        }

        public static void ImprimirCardapio()
        {
            Console.Clear();
            Console.WriteLine("QUAIS PRODUTOS(codigo) VOCÊ DESEJA?\n");
            Console.WriteLine("CODIGO    PRODUTO              PREÇO UNITARIO\n");

            foreach (var produto in Produtos)
            {
                Console.WriteLine($"{produto.CodigoProduto}      {produto.Descricao,-15}              {produto.Preco}\n");
            }
        }       
    }
}
