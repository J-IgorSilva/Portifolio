using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_de_Luz
{
    class Dados_pessoa
    {
        public string Nome(string nome)
        {
            Console.WriteLine("Ola "+ nome);
            return nome;
        }
        
        public string mes(string nome_mes)
        {
            Console.WriteLine("Conta Referente ao Mes " + nome_mes);
            return nome_mes;
        }
    }
}
