﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_de_Luz
{
    class Dadospessoa
    {
        public string Nome(string nome) // adicionar exceções para o nome do usuario
        {
            Console.WriteLine("Ola " + nome);

            return nome;
        }
        
        public string mes(string nome_mes) // adiconar tratamento para exceçoes mes
        {
            switch (nome_mes)
            {
                case "1":
                    Console.WriteLine("Janeiro");
                    break;
                case "2":
                    Console.WriteLine("Fevereiro");
                    break;
                case "3":
                    Console.WriteLine("Março");
                    break;
                case "4":
                    Console.WriteLine("Abril");
                    break;
                case "5":
                    Console.WriteLine("Maio");
                    break;
                case "6":
                    Console.WriteLine("Junho");
                    break;
                case "7":
                    Console.WriteLine("Julho");
                    break;
                case "8":
                    Console.WriteLine("Agosto");
                    break;
                case "9":
                    Console.WriteLine("Setembro");
                    break;
                case "10":
                    Console.WriteLine("Outubro");
                    break;
                case "11":
                    Console.WriteLine("Novembro");
                    break;
                case "12":
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Insiria um Mes, Para Prossegui com o Calculo");
                    break;

            }

            return nome_mes;
        }
    }
}
