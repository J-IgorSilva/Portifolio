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
      
            Dados_pessoa p = new Dados_pessoa();
            Calculo_Conta c = new Calculo_Conta();

            Console.WriteLine("Insira seu Nome e Mes da Para Calcularmos seu Consumo Mensal: ");
            name = Console.ReadLine();

            p.Nome(name);
        }
    }
}
