using System;

namespace Conta_de_Luz
{
    class Menu
    {
        public void menuu(string opcao) // criar um mentoodo ou função para as opções
        {
            Console.Clear();

            Console.WriteLine("1 Cadastro");
            Console.WriteLine("2 Calculo da Conta de Luz");
            Console.WriteLine("3 Calculo da Conta de Agua");
            Console.WriteLine("0 Sair");

            switch (opcao)
            {
                case "1":
                       Console.WriteLine// função para cadastro
                       Console.WriteLine//calculo
                        Console.WriteLine//agua
                        Console.WriteLine//sair
               
                case 0: System.Environment.Exit(0); break;
                default: opcao(); break;
            }
        }
    }
    }
}
