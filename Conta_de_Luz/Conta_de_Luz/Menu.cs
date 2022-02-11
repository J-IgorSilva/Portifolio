using System;

namespace Conta_de_Luz
{
    class Menu
    {
        public void Menuu() // criar um mentoodo ou função para as opções
        {
            Console.WriteLine("Ola Seja Bem vindo, Esolha uma das Opções Abaixo! ");

            Console.WriteLine("------------------------------");

            Console.WriteLine("1 Cadastro");
            Console.WriteLine("2 Calculo da Conta de Luz");
           
            Console.WriteLine("0 Sair");

            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: InsertName();
                    break;
                case 2: InsertConta();
                    break;
                case 0: System.Environment.Exit(0);
                    break;

            }
            static void InsertName()
            {
                Console.Clear();
                Console.WriteLine("Ola, Vamos Iniciar sua consulta a Seguir ");

                Console.WriteLine();

                Console.WriteLine("Insira seu Nome e Sobrenome");

                var name = Console.ReadLine();


            }
            public void InsertConta()
            {
                Console.Clear();

                Console.WriteLine("Insira o Valor do Consumo, Sem os Impostos");

                float ligth = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite Quantos Kw/H  Você Consumiu");

                float kwh = float.Parse(Console.ReadLine());

                float total = ligth / kwh;

                Console.WriteLine($"O Valor Pago Por KH/W é de ${total} Sem Impostos.");

            }
        }
       
    }
}
