using System;
using System.Collections.Generic;
using Nancy.Json;

namespace CardapioConsole
{
    public class Pedido : Menu
    {
        public decimal ValorTotal { get; set; }

        public List<ProdutoPedido> Produtos { get; set; }

        public Pedido()
        {
            Produtos = new List<ProdutoPedido>();
        }

        public void AdicionarProduto(ProdutoPedido pedido)
        {
            Produtos.Add(pedido);
            var valorProduto = pedido.Produto.Preco;
            ValorTotal = valorProduto * pedido.Quantidade + ValorTotal;
            Console.WriteLine($"dfs{pedido}{pedido.Quantidade}{ValorTotal}");
        }
       
        public void ImprimirPedidoJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Console.WriteLine(serializer.Serialize(this));
        }
        public void ImprimirPedidoComMesa()
        {
            foreach (var imprimirComMesa in Produtos)
            {
                Console.WriteLine($"\n1- { imprimirComMesa.Produto.Descricao} - COM VALOR TOTAL DE R$: {this.ValorTotal}\n");               
            }
        }
    }

    public class ProdutoPedido
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public ProdutoPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}
