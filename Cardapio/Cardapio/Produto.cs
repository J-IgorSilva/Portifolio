using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardapioConsole
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public Produto(int codigo, string descricao, decimal preco)
        {
            CodigoProduto = codigo;
            Descricao = descricao;
            Preco = preco;
        }
        public Produto(decimal preco)
        {
            Preco = preco;
        }

    }
}