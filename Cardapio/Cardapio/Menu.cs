using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardapioConsole
{
    public class Menu
    {
        private static readonly int[] MesasValidas = { 1, 2, 3, 4 };
        private static readonly int[] CodigoPedido = { 100, 101, 102, 103, 104, 999 };

        public static void MenuCardapio()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            ImprimirOpcoesMenu();

            if (DesejaRealizarPedido())
            {
                var numeroMesa = NumeroDaMesa();
                Cardapio.ImprimirCardapio();
                var codigoDoProduto = int.Parse(Console.ReadLine());
                var pedido = new Pedido();

                while (codigoDoProduto != 999)
                {
                    var produto = Cardapio.ObterProdutoPeloCodigo(codigoDoProduto);
                    var produtoPedido = new ProdutoPedido(produto);
                    pedido.Produtos.Add(produtoPedido);
                    codigoDoProduto = int.Parse(Console.ReadLine());
                }
            }
            Environment.Exit(0);
        }

        private static bool DesejaRealizarPedido()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                case "2":
                    return false;
                default:
                    return false;
            }
        }

        private static int NumeroDaMesa()
        {
            Console.Write("\nESCOLHA O NUMERO DA MESA: ");
            var numeroMesa = int.Parse(Console.ReadLine());

            while (!ValidarNumeroMesa(numeroMesa))
            {
                ImprimirMesasDisponiveis();
                numeroMesa = int.Parse(Console.ReadLine());
            }

            return numeroMesa;
        }      

        private static void InformeCodigo()
        {
            Console.WriteLine("Informe o Codigo: ");
            int digito = int.Parse(Console.ReadLine());
            var VerDigito = Array.Exists(CodigoPedido, x => x == digito);
            if (VerDigito == true)
            {

            }
            else
            {
                Console.WriteLine("Codigo não exite\n");

                InformeCodigo();
            }
        }

        private static bool ValidarNumeroMesa(int numeroMesa)
        {
            return MesasValidas.Contains(numeroMesa);
        }

        private static bool NumeroPedidoCliente(int numeroPedido)
        {
            return CodigoPedido.Contains(numeroPedido);
        }

        public static void ImprimirOpcoesMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ PEDIDOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");
            Console.WriteLine("║ 1 EFETUAR PEDIDO                              ║    ");
            Console.WriteLine("║ 2 SAIR                                        ║    ");
            Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
            Console.WriteLine(" ");
            Console.Write("DIGITE UMA OPÇÃO : ");
        }

        public static void ImprimirMesasDisponiveis()
        {
            Console.Clear();
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ Mesa ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");
            Console.WriteLine("║ MESAS DISPONIVEIS                             ║    ");
            Console.WriteLine("║ [1]  [2]  [3]  [4]                            ║    ");
            Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
        }
    }
}
