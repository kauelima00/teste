using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeTeniss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "o";


            Gerente g = new Gerente();
            Funcionario f = new Funcionario();
            Cliente c = new Cliente();

            Console.Clear();
            Console.WriteLine("======LOJA DE TENIS======");
            Console.WriteLine("-------------------------");
            Console.WriteLine("[1] - Gerente");
            Console.WriteLine("[2] - Funcionário");
            Console.WriteLine("[3] - Cliente");
            Console.WriteLine("[q] - Sair");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    g.Menu();
                    break;

                case "2":
                    f.Menu();
                    break;

                case "3":
                    c.Menu();
                    break;
                case "q":
                case "Q":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Digite um numero Valido!");
                    break;
            }
        }
    }
}
