using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardapioConsole;

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
    }

    public class ProdutoPedido
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public ProdutoPedido(Produto produto)
        {
            Produto = produto;
        }
    }
}
