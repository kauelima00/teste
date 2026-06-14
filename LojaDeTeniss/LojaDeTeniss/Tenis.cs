using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeTeniss
{   
        internal class Tenis
        {
            public string Nome;
            public string Marca;
            public decimal Preco;
            public int Numeracao;
            public int Estoque;
        }

        internal class Loja
        {
            public static List<Tenis> Estoque = new List<Tenis>()
        {
            new Tenis { Nome = "Air Max",
                        Marca = "Nike",   
                        Preco = 599.99m, 
                        Numeracao = 42, 
                        Estoque = 10 },

            new Tenis { Nome = "Ultraboost", 
                        Marca = "Adidas", 
                        Preco = 799.99m,  
                        Numeracao = 41, 
                        Estoque = 0  },

            new Tenis { Nome = "Classic",   
                        Marca = "Vans",  
                        Preco = 349.99m, 
                        Numeracao = 43, 
                        Estoque = 8  }
        };

            public static List<Funcionario> Funcionarios = new List<Funcionario>()
        { 
            new Funcionario {  Nome = "Joao",
                               Cargo = "Caixa",
                               Salario = 1300.00m },

            new Funcionario {  Nome = "Maria",
                               Cargo = "Vendedora", 
                               Salario = 1500.00m },

            new Funcionario {  Nome = "Pedro", 
                               Cargo = "Estoquista",
                               Salario = 1200.00m }
        };
        }
}






