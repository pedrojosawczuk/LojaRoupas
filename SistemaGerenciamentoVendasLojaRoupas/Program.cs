using System;

namespace SistemaGerenciamentoVendasLojaRoupas
{
    class Program
    {
        static void Main(string[] args)
        {/*
            List<Produto> produtos = new List<Produto>();
            List<Categoria> categorias = new List<Categoria>();*/

            Console.WriteLine("🛍️ Sistema de Gerenciamento de Vendas Loja de Roupas 👗");

            while (true)
            {
                Console.WriteLine(' ');
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Cliente");
                Console.WriteLine("2 - Categoria");
                Console.WriteLine("3 - Produto");
                Console.WriteLine("4 - Realizar Venda");
                Console.WriteLine("5 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("👋 Tchau, tchau...");
                        return;
                    default:
                        Console.WriteLine("😳 Opção Inválida!");
                        break;
                }
            }
        }
    }
}