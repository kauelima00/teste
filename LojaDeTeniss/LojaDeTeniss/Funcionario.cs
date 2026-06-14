using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LojaDeTeniss
{
    internal class Funcionario
    {
        public string Nome;
        public string Cargo;
        public decimal Salario;

        public void Menu()
        {

            string val = "w";

            while (val != "q" && val != "Q")
            {

                Console.Clear();
                Console.WriteLine("\n======FUNCIONARIO======");
                Console.WriteLine("-------------------------");
                Console.WriteLine("[1] - Cadastrar Tenis");
                Console.WriteLine("[2] - Exibir Estoque");
                Console.WriteLine("[3] - Alterar Preco");
                Console.WriteLine("[4] - Alterar Estoque");
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
                    AlterarEstoque();
                }
            }
        }

        public void CadastrarTenis()
        {
            Tenis t = new Tenis();
            Console.WriteLine("Nome: ");
            t.Nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            t.Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Marca: ");
            t.Marca = Console.ReadLine();
            Console.WriteLine("Numeração: ");
            t.Numeracao = int.Parse(Console.ReadLine());
            Console.WriteLine("Estoque:   ");
            t.Estoque = int.Parse(Console.ReadLine());
            Loja.Estoque.Add(t);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tênis cadastrado com sucesso!");
            Console.WriteLine("-----------------------------");
            Console.ReadKey();
        }

        public void ExibirEstoque()
        {
            Console.Clear();
            Console.WriteLine("=====ESTOQUE=====");
            int total = 0;
            for (int i = 0; i < Loja.Estoque.Count; i++)
            {
                Tenis t = Loja.Estoque[i];
                Console.WriteLine("\n[" + (i + 1) + "]");
                Console.WriteLine("Nome:   {0}",t.Nome);
                Console.WriteLine("Preço:  {0}",t.Preco);
                Console.WriteLine("Marca:  {0}",t.Marca);
                Console.WriteLine("Numeração:  {0}",t.Numeracao);
                Console.WriteLine("Estoque     {0}", t.Estoque);
                total += t.Estoque;

            }
            Console.ReadKey();
        }

        public void AlterarPreco()
        {
            ExibirEstoque();
            Console.WriteLine("Escolhar o numero do Tenis: ");
            int index = int .Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Preço Atual: {0}", Loja.Estoque[index].Preco); 
            Console.WriteLine("Novo preço:    ");
            Loja.Estoque[index].Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Preço Alterado!");
            Console.ReadKey();
        }

        public void AlterarEstoque()
        {
            ExibirEstoque();
            Console.WriteLine("Escolha o numero do Tenis:  ");
            int index = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Estoque Atual  {0}", Loja.Estoque[index].Estoque);
            Console.WriteLine("Novo estoque:  ");
            Loja.Estoque[index].Estoque = int .Parse(Console.ReadLine());
            Console.WriteLine("Estoque Alterado!!!");
            Console.ReadKey();
        }
    }
}
