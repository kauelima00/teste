using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeTeniss
{
    internal class Gerente
    {
        public string Nome;
        public string Cargo;
        public decimal Salario;

        public void Menu()
        {
            string val = "l";
            while (val != "q" && val != "Q")
            {
                Console.Clear();
                Console.WriteLine("\n======GERENTE======");
                Console.WriteLine("-------------------------");
                Console.WriteLine("[1] - Cadastrar Funcionário");
                Console.WriteLine("[2] - Exibir Funcionários");
                Console.WriteLine("[3] - Alterar Salário");
                Console.WriteLine("[4] - Alterar Cargo");
                Console.WriteLine("[5] - Demitir Funcionário");
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
                        ExibirFuncionario();
                        break;

                    case "3":
                        AlterarSalario();
                        break;

                    case "4":
                        AlterarCargo();
                        break;

                    case "5":
                        DemitirFuncionario();
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
            Funcionario f = new Funcionario();

            Console.Clear();
            Console.WriteLine("Nome:");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Cargo:");
            f.Cargo = Console.ReadLine();
            Console.WriteLine("Salário:");
            f.Salario = decimal.Parse(Console.ReadLine());
            Loja.Funcionarios.Add(f);
            

            Console.WriteLine("Funcionário Cadastrado Com Sucesso!!");
        }
        public void ExibirFuncionario()
        {
            Console.Clear();
            Console.WriteLine("=====FUNCIONARIOS=====");
            if (Loja.Funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionario Cadastrado!");
                
                return;
            }
            
            for (int i = 0; i < Loja.Funcionarios.Count; i++)
            {
                Funcionario f = Loja.Funcionarios[i];

                Console.WriteLine("\n[" + (i + 1) + "]");
                Console.WriteLine("Nome:    {0}",f.Nome);
                Console.WriteLine("Cargo:   {0}",f.Cargo);
                Console.WriteLine("Salario: {0}",f.Salario);
            }
            Console.ReadKey();
        }
        public void AlterarSalario()
        {
            Console.Clear();
            ExibirFuncionario();
            Console.WriteLine("Numero do funcionario:  ");
            int index = int.Parse(Console.ReadLine()) -1;
            Console.WriteLine("Salario Atual: {0}", Loja.Funcionarios[index].Salario);
            Console.WriteLine("Novo salario:");
            Loja.Funcionarios[index].Salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Salário alterado com sucesso!");
            
        }

        public void AlterarCargo()
        {
            Console.Clear();
            ExibirFuncionario();
            Console.WriteLine("Numero do Funcionario:  ");
            int index = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Cargo Atual: {0}", Loja.Funcionarios[index].Cargo);
            Console.WriteLine("Novo Cargo:");
            Loja.Funcionarios[index].Cargo = Console.ReadLine();
            Console.WriteLine("Cargo alterado com sucesso!");
            Console.ReadKey();
        }

        public void DemitirFuncionario()
        {
            Console.Clear();
            ExibirFuncionario();
            if (Loja.Funcionarios.Count == 0) return;
            else
            {
                Console.WriteLine("Numero do Funcionario: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Funcionario {0} Demitido", Loja.Funcionarios[index].Nome); 
                Loja.Funcionarios.RemoveAt(index);
                Console.ReadKey();
            }
        }
    }
}
