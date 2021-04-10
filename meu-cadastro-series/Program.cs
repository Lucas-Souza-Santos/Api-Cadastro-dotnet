using System;

namespace meu_cadastro_series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            int opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != 7)
            {
                switch(opcaoUsuario)
                {
                    case 1:
                        ListarSerie();
                        break;
                    case 2:
                        InserirSerie();
                        break;
                    case 3:
                        AtualizarSerie();
                        break;
                    case 4:
                        ExcluirSerie();
                        break;
                    case 5:
                        VisualizarSerie();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }


        }

        private static void VisualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void ExcluirSerie()
        {
            throw new NotImplementedException();
        }

        private static void AtualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine()); 

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(),
                                          genero:(Genero)entradaGenero,
                                          titulo: entradaTitulo, 
                                          ano: entradaAno, 
                                          descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
        }

        private static void ListarSerie()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                Console.WriteLine($" #ID {serie.retornaId()}: - {serie.retornaTitulo()}");
            }
        }

        private static int ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine(" 1- Listar séries");
            Console.WriteLine(" 2- Inserir nova série");
            Console.WriteLine(" 3- Atualizar série");
            Console.WriteLine(" 4- Excluir série");
            Console.WriteLine(" 5- Visualizar série");
            Console.WriteLine(" 6- Limpar Tela");
            Console.WriteLine(" 7- Sair");

            int opcaoUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
