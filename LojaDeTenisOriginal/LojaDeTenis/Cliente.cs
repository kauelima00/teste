using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeTenis
{
    internal class Cliente
    {
        public string Nome;
        public string CPF;
        public string Email;
        public string Telefone;


        public void Menu()
        {
            string opcao = "m";

            while (opcao != "q")
            {
                Console.WriteLine("\n======CLIENTE======");
                Console.WriteLine("-------------------------");
                Console.WriteLine("[1] - Cadastrar Cliente");
                Console.WriteLine("[2] - Editar Dados");
                Console.WriteLine("[3] - Realizar Compra");
                Console.WriteLine("[q] - Voltar");
                Console.WriteLine("-------------------------");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarCliente();
                        break;

                    case "2":
                        EditarDados();
                        break;

                    case "3":
                        RealizarCompra();
                        break;

                    case "q":
                    case "Q":
                        Console.WriteLine("\nSaindo do Programa...");
                        break;
                    default:
                        Console.WriteLine("Digite Numero Valido!");
                        break;
                }
            }
        }
        

        

        public void CadastrarCliente()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("CPF: ");
            CPF = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.WriteLine("");
            Console.ReadKey();
        }



        public void EditarDados()
        {
            if (Nome == null)
            {
                Console.WriteLine("");
                Console.WriteLine("Nenhum cliente cadastrado!");
                Console.WriteLine("");
                return;
            }

            Console.WriteLine("[1] - Editar Nome");
            Console.WriteLine("[2] - Editar CPF");
            Console.WriteLine("[3] - Editar Email");
            Console.WriteLine("[4] - Editar Telefone");
            Console.Write("Escolha o que deseja editar: ");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Novo Nome: ");
                Nome = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Nome alterado com sucesso!");
                Console.WriteLine("");
            }
            else if (opcao == 2)
            {
                Console.Write("Novo CPF: ");
                CPF = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("CPF alterado com sucesso!");
                Console.WriteLine("");
            }
            else if (opcao == 3)
            {
                Console.Write("Novo Email: ");
                Email = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Email alterado com sucesso!");
                Console.WriteLine("");
            }
            else if (opcao == 4)
            {
                Console.Write("Novo Telefone: ");
                Telefone = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Telefone alterado com sucesso!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("");

            }
        }
            public void RealizarCompra()
            {
            
            }
    }
}




