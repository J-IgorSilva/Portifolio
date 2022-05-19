using System;
using System.Collections.Generic;
using Nancy.Json;

namespace CardapioConsole
{
    public class Pedido
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
        }

        public void ImprimirPedido()
        {
           foreach (var produto in Produtos)
            {
                Console.WriteLine();
            }
        }

        public void ImprimirPedidoJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Console.WriteLine(serializer.Serialize(this));
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
