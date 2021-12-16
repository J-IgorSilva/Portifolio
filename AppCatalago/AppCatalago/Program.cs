using AppCatalago.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalago
    // alguns obj e metodos estão em ingles.
    //para exercitar a linguagem.
{
    class Program : SereieRepository
    {
        static SereieRepository repositorio = new SereieRepository();
        static void Main(string[] args)
        {
            string opcaoUsuario = SelectOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                        case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                            case "5":
                        VisualizarSerie();
                        break;
                            case "X":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = SelectOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
        private static void ListarSerie()
        {
            Console.WriteLine("Listar Serie: ");
            var lista = repositorio.lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Serie Cadastrada");
                return;
            }
            foreach ( var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornId(), serie.retornTitulo());
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Escolha o gênero acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Series NewSerie = new Series(id: repositorio.ProximoId() , genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, description: entradaDescricao);

            repositorio.Insere(NewSerie);
        }
        private static void AtualizarSerie()
        {
            Console.Write("Digite o n° da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

            Series atualizaSerie = new Series(id: indiceSerie, genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, description: entradaDescricao);

            repositorio.Atualizar(indiceSerie, atualizaSerie);

        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetoronoId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static string SelectOpcaoUsuario()
        {
            Console.WriteLine("Bem vindo a TOP FILMES");
            Console.WriteLine(" Informe a Opcao: ");
            
            Console.WriteLine(" 1-- Lista de Serie: ");
            Console.WriteLine(" 2-- Adcionar Serie: ");
            Console.WriteLine(" 3-- Atualizar a Lista: ");
            Console.WriteLine(" 4-- Excluir Serie: ");
            Console.WriteLine(" 5-- Visualar Serie: ");
            Console.WriteLine(" S-- Exit: ");
            Console.WriteLine(" X-- Limpar: ");

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;
        }
    }
}
