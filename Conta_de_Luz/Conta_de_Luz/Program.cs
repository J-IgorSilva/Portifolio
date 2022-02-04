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
            string name, mess;
            float luzz, khww;
            Dadospessoa D = new Dadospessoa();
            Calculo_Conta C = new Calculo_Conta();

            Console.WriteLine("Ola, Insira seu Nome Para começar: ");
            name = Console.ReadLine();
            Console.WriteLine("--------------------------");
          
            string[] escolha = new string[12];
            {
                escolha[0] = "Janeiro";
                escolha[1] = "Fevereiro";
                escolha[2] = "Março";
                escolha[3] = "Abril";
                escolha[4] = "Maio";
                escolha[5] = "Junho";
                escolha[6] = "Julho";
                escolha[7] = "Agosto";
                escolha[8] = "Setembro";
                escolha[9] = "Outubro";
                escolha[10] = "Novembro";
                escolha[11] = "Dezembro";
                for(int i = 0; i < 11; i++)
                {
                    Console.WriteLine(escolha[i]);
                }
            }
        
            Console.Write("Qual o Mes da Conta Atual: ");

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
