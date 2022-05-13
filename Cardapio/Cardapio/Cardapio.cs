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
                new Produto(100, "Cachorro quente", 5.70M),
                new Produto(101, "X Completo", 18.30M),
                new Produto(102, "X Salada", 16.50M),
                new Produto(103, "Hamburguere", 22.40M),
                new Produto(104, "Coca 2L", 10.00M),
                new Produto(105, "Refrigerante", 1.00M)
            };
        }

        public static Produto ObterProdutoPeloCodigo(int codigo)
        {
            var produto = Produtos.FirstOrDefault(x => x.CodigoProduto == codigo);
            return produto;
        }

        public static void ImprimirCardapio()
        {
            Console.Clear();
            Console.WriteLine("Quais produtos(codigo) você deseja?\n");
            Console.WriteLine("Código    Produto              Preço Unitário\n");

            foreach (var produto in Produtos)
            {
                Console.WriteLine($"{produto.CodigoProduto}      {produto.Descricao}              {produto.Preco}\n");
            }
        }
    }
}
