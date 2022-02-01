using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_de_Luz
{
    class Program : Dados_pessoa 
    {
        static void Main(string[] args)
        {
            string name, mess;
            float luzz, khww;

      
            Dados_pessoa p = new Dados_pessoa();
            Calculo_Conta c = new Calculo_Conta();

            Console.WriteLine("Insira seu Nome e Mes da Para Calcularmos seu Consumo Mensal: ");
            name = Console.ReadLine();
            Console.WriteLine("--------------------------");

            Console.Write("Qual o Mes da Conta Atual: ");
            mess = Console.ReadLine();
            Console.WriteLine("--------------------------");
            
            p.Nome(name);

            p.mes(mess);

            Console.WriteLine("Agora insira qual o valor total da sua Fatura, e Quantos Kw/H De consumo no mes: ");

            luzz = float.Parse(Console.ReadLine());
            khww = float.Parse(Console.ReadLine());
           

            c.Calculo(luzz, khww);

            Console.WriteLine(c.total);
            Console.ReadKey();
        }
    }
}
