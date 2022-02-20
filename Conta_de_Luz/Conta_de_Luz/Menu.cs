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
            Console.WriteLine("3 Agendar Pagamento");
           
            Console.WriteLine("0 Sair");
        
      

            short escolha = short.Parse(Console.ReadLine());

            switch (escolha){
                case 1:
                    InsertName();
                 
                    break;
                case 2: InsertConta();
                    break;
                case 3:
                    InsertPay();
                    break;
                case 0: System.Environment.Exit(0);
                    break;

            }
         
        
        }
        static void InsertName()
        {
            Console.Clear();
            Console.WriteLine("Ola, Vamos Iniciar sua consulta a Seguir ");

            Console.WriteLine();

            Console.WriteLine("Insira seu Nome e Sobrenome");

            var name = Console.ReadLine();
            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Por Favor Insira nome e Sobrenome");
                name = Console.ReadLine();
                // fazer uma tratativa melhor do metodo de excceção.
            }
           
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
        public void InsertPay()
        {
            Console.Clear();

            InsertName();

            int year = 0, month = 0, day = 0;

            Console.WriteLine("Insira o Dia, o Mes, e o Ano, para agendarmos seu pagamento: ");

            Console.WriteLine();

            day = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());

            DateTime data = new DateTime(day, month, year).ToLocalTime();

            Console.WriteLine($"Pagamento Agendado Para dia{day} do mes {month} de {year}");
        }
    }
}
