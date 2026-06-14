using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeTenis
{
    internal class Gerente
    {
        public string Nome;
        public string Cargo;
        public decimal Salario;

        public void Menu()
        {
            string val = "f";
            while (val != "q")
            {
                Console.WriteLine("\n======GERENTE======");
                Console.WriteLine("-------------------------");
                Console.WriteLine("[1] - Cadastrar Funcionário");
                Console.WriteLine("[3] - Alterar Salário");
                Console.WriteLine("[4] - Alterar Cargo");
                Console.WriteLine("[q] - Voltar");
                Console.WriteLine("-------------------------");
                Console.Write("Escolha uma opção: ");

                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        CadastrarFuncionario();
                    break;

                    case "2":
                        AlterarSalario();
                    break;

                    case "3":
                        AlterarCargo();
                    break;

                    case "q":
                    case "Q":
                    break;
                    

                    default:
                        Console.WriteLine("Digite numero valido No menu !!!");
                    break;
                }
            }
        }

        public void CadastrarFuncionario()
        {
            Console.WriteLine("Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Cargo:");
            Cargo = Console.ReadLine();
            Console.WriteLine("Salário:");
            Salario = decimal.Parse(Console.ReadLine());
            Console.ReadKey();
        }

        public void AlterarSalario()
        {
            Console.WriteLine("Salario Atual: {0}", Salario);
            Console.WriteLine("Novo salario:");
            Salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Salário alterado com sucesso!");
            Console.ReadKey();
        }

        public void AlterarCargo()
        {
            Console.WriteLine("Cargo Atual: {0}", Cargo);
            Console.WriteLine("Novo Cargo:");
            Cargo = Console.ReadLine();
            Console.WriteLine("Cargo alterado com sucesso!");
            Console.ReadKey();
        }
    }
}
