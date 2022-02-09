using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_de_Luz
{
    
    class Program : Dadospessoa
    {

        static void Main(string[] args)
        {
            Menu m = new Menu();
            

            string name, mess;
            float luzz, khww;
            Dadospessoa D = new Dadospessoa();
            Calculo_Conta C = new Calculo_Conta();

            Console.WriteLine("Ola, Insira seu Nome Para começar: ");
            name = Console.ReadLine();
            
            Console.WriteLine("--------------------------");

            Console.WriteLine($" Ola {name} Seja Bem Vindo! ");

            Console.WriteLine("Escolha Uma Opção Abaixo: ");
            Console.WriteLine();
            m.menuu();

            string[] escolha = new string[12];
            {
                escolha[0] = "1 - Janeiro";
                escolha[1] = "2 - Fevereiro";
                escolha[2] = "3 - Março";
                escolha[3] = "4 - Abril";
                escolha[4] = "5 - Maio";
                escolha[5] = "6 - Junho";
                escolha[6] = "7 - Julho";
                escolha[7] = "8 - Agosto";
                escolha[8] = "9 - Setembro";
                escolha[9] = "10 - Outubro";
                escolha[10] ="11 - Novembro";
                escolha[11] = "12 - Dezembro";
                for(int i = 0; i < 11; i++)
                {
                    Console.WriteLine(escolha[i]);
                }
            }
        
            

            Console.WriteLine("--------------------------");

            D.Nome(name);

            Console.WriteLine("Agora insira qual o valor total da sua Fatura, e Quantos Kw/H De consumo no mes: ");

            luzz = float.Parse(Console.ReadLine());
            khww = float.Parse(Console.ReadLine());


            C.Calculo(luzz, khww);

            Console.WriteLine(C.total);
            Console.ReadKey();
          
        }
    }
}
