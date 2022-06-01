using Nancy.Json;
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

        public static void MenuCardapio()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            ImprimirOpcoesMenu();
            
            if (DesejaRealizarPedido())
            {
                var numeroMesa = NumeroDaMesa();
                var pedido = FazerPedido();
                Console.WriteLine($"A MESA {numeroMesa} PEDIU OS SEGUINTES ITENS:");
                pedido.ImprimirPedidoComMesa();
                Console.WriteLine("IMPRESSÃO DO PEDIDO EM JSON");
                pedido.ImprimirPedidoJson();
            }
            Environment.Exit(0);
        }
        

        private static Pedido FazerPedido()
        {
            var pedidoConcluido = false;
            var pedido = new Pedido();

            while (!pedidoConcluido)
            {
                Cardapio.ImprimirCardapio();
                Console.WriteLine("\nQUAL PRODUTO VOCÊ DESEJA?\n");
                var codigoDoProduto = int.Parse(Console.ReadLine());

                if (codigoDoProduto == 999)
                {
                    pedidoConcluido = true;
                    continue;
                }

                Console.WriteLine("\nQUANTAS UNIDADES?\n");
                var quantidadeDoProduto = int.Parse(Console.ReadLine());
                var produto = Cardapio.ObterProdutoPeloCodigo(codigoDoProduto);
                var produtoPedido = new ProdutoPedido(produto, quantidadeDoProduto);
                pedido.AdicionarProduto(produtoPedido);
                Console.Clear();
            }
            return pedido;
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
        
        private static bool ValidarNumeroMesa(int numeroMesa)
        {
            return MesasValidas.Contains(numeroMesa);
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
