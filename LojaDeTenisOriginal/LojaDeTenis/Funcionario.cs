using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeTenis
{
    internal class Funcionario
    {
        public string Nome;
        public decimal Preco;
        public int Numeracao;
        public string Marca;
        public int Estoque;
        public string Codigo;   


        public void Menu()
        {
            
            string val = "w";

            while(val != "q") 
            {

            Console.Clear();
            Console.WriteLine("\n======FUNCIONARIO======");
            Console.WriteLine("-------------------------");
            Console.WriteLine("[1] - Cadastrar Tenis");
            Console.WriteLine("[2] - Exibir Estoque");
            Console.WriteLine("[3] - Alterar Preco");
            Console.WriteLine("[5] - ");
            Console.WriteLine("[q] - Voltar");
            Console.WriteLine("-------------------------");
            Console.Write("Escolha uma opção: ");

            val = Console.ReadLine();

            if (val == "1")
                {
                    CadastrarTenis();
                }
            else if (val == "2")
                {
                    ExibirEstoque();
                }
            else if (val == "3")
                {
                    AlterarPreco();
                }
             else if (val == "4")
                {

                }       
            }
        }
        
        public void CadastrarTenis()
        {
            
            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Marca: ");
            Marca = Console.ReadLine();
            Console.WriteLine("Numeração: ");
            Numeracao = int.Parse(Console.ReadLine());
          
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tênis cadastrado com sucesso!");
            Console.WriteLine("-----------------------------");
        }

        public void ExibirEstoque()
        {
            Console.WriteLine("");
            Console.WriteLine("======TENIS======");
            Console.WriteLine("Nome:           {0}",Nome);
            Console.WriteLine("Marca:          {0}",Marca);
            Console.WriteLine("Preço:          {0}",Preco);
            Console.WriteLine("Estoque:        {0} unidades",Estoque);
            Console.WriteLine("Numeração:      {0}",Numeracao);
            Console.WriteLine("=================");
            Console.WriteLine("");
        }

        public void AlterarPreco()
        {
            Console.WriteLine("Preço Atual: {0}",Preco);
            Console.WriteLine("Novo preço:  {0}");
            Preco = decimal.Parse (Console.ReadLine());
            Console.WriteLine("Preço Alterado!");
            Console.ReadKey();
        }
    }
}

