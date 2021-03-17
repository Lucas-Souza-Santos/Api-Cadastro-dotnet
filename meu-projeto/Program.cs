using System;
using System.Collections.Generic;

namespace meu_projeto
{

    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            int opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario != 7)
            {
                switch (opcaoUsuario)
                {
                    case 1:
                        ListarContas();
                        break;
                    case 2:
                        InserirConta();
                        break;
                    case 3:
                        Transferir();
                        break;
                    case 4:
                        Sacar();
                        break;
                    case 5:
                        Depositar();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        break;                   
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por ultilizar os nossos serviços.");
            Console.ReadLine();

        }

        private static void Transferir()
        {
            Console.Write("Digite o número da Conta de Origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da Conta de Destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser Transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Deposito: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorSaque);
        }

        private static void Sacar()
        {
            Console.Write("Digite o número da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        }

        private static void ListarContas()
        {
            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                Console.ReadLine();
                return;
            }
            for(int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
            Console.ReadLine();
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");
            
            Console.Write("Digite 1 para Conta Física ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta((TipoConta)entradaTipoConta, entradaSaldo, entradaCredito, entradaNome);

            listContas.Add(novaConta);

        }

        private static int ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO BANK a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");
            
            Console.WriteLine(" 1- Listar conta");
            Console.WriteLine(" 2- Inserir nova conta");
            Console.WriteLine(" 3- Transferir");
            Console.WriteLine(" 4- Sacar");
            Console.WriteLine(" 5- Depositar");
            Console.WriteLine(" 6- Limpar Tela");
            Console.WriteLine(" 7- Sair");
            Console.WriteLine();

            int opcaoUsuario = int.Parse(Console.ReadLine());
            return opcaoUsuario;

        }
    }
}
