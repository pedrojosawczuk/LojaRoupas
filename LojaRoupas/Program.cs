using System;
using System.Collections.Generic;
using LojaRoupas.Model;
using LojaRoupas.UI;

namespace LojaRoupas;

class Program
{
    public static void Main(string[] args)
    {
        /*
        List<Categoria> categorias = new List<Categoria>();
        List<Produto> produtos = new List<Produto>();
        List<Cliente> clientes = new List<Cliente>();
        */
        ClienteUI clienteUI = new ClienteUI();
        CategoriaUI categoriaUI = new CategoriaUI();
        VendaUI vendaUI = new VendaUI();
        ProdutoUI produtoUI = new ProdutoUI();

        while (true)
        {
            //Console.Clear();
            Console.WriteLine(" 🛍️ Loja de Roupas👗 ");
            Console.WriteLine(" ");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine(" 1 - 👤 Clientes");
            Console.WriteLine(" 2 - 🔠 Categorias");
            Console.WriteLine(" 3 - 👗 Produtos");
            Console.WriteLine(" 4 - 💳 Vendas");
            Console.WriteLine(" 5 - 🚪🚶 Sair");
            Console.Write(" 👉 ");

            try
            {
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                switch (opcao)
                {
                    case 1:
                        //Console.Clear();
                        Console.WriteLine(" 👤 CLIENTE 👤 ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Selecione uma opção: ");
                        Console.WriteLine(" 1 - Cadastrar Cliente");
                        Console.WriteLine(" 2 - Alterar Cliente");
                        Console.WriteLine(" 3 - Listar Todos os Clientes");
                        Console.WriteLine(" 4 - Buscar Cliente por Id");
                        Console.WriteLine(" 5 - Remover Cliente");
                        Console.WriteLine(" 6 - Voltar");
                        Console.Write(" 👉 ");

                        try
                        {
                            opcao = int.Parse(Console.ReadLine() ?? "0" ?? "0");

                            Console.WriteLine(" ");

                            switch (opcao)
                            {
                                case 1:
                                    clienteUI.Cadastrar();
                                    break;
                                case 2:
                                    clienteUI.Alterar();
                                    break;
                                case 3:
                                    clienteUI.BuscarTodas();
                                    break;
                                case 4:
                                    clienteUI.BuscarPorId();
                                    break;
                                case 5:
                                    clienteUI.Remover();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine(" 😳 Opção Inválida!");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
                        }
                        break;

                    case 2:
                        //Console.Clear();
                        Console.WriteLine(" 🔠 CATEGORIA 🔠 ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Selecione uma opção: ");
                        Console.WriteLine(" 1 - Cadastrar Categoria");
                        Console.WriteLine(" 2 - Alterar Categoria");
                        Console.WriteLine(" 3 - Buscar Todas as Categoria");
                        Console.WriteLine(" 4 - Buscar Categoria por Id");
                        Console.WriteLine(" 5 - Remover Categoria");
                        Console.WriteLine(" 6 - Voltar");
                        Console.Write(" 👉 ");

                        try
                        {
                            opcao = int.Parse(Console.ReadLine() ?? "0");

                            Console.WriteLine(" ");

                            switch (opcao)
                            {
                                case 1:
                                    categoriaUI.Cadastrar();
                                    break;
                                case 2:
                                    categoriaUI.Alterar();
                                    break;
                                case 3:
                                    categoriaUI.BuscarTodas();
                                    break;
                                case 4:
                                    categoriaUI.BuscarPorId();
                                    break;
                                case 5:
                                    categoriaUI.Remover();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine(" 😳 Opção Inválida!");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
                        }
                        break;

                    case 3:
                        //Console.Clear();
                        Console.WriteLine(" 👗 PRODUTO 👗 ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Selecione uma opção: ");
                        Console.WriteLine(" 1 - Cadastrar Produto");
                        Console.WriteLine(" 2 - Alterar Produto");
                        Console.WriteLine(" 3 - Buscar Todos os Produtos");
                        Console.WriteLine(" 4 - Buscar Produto por Id");
                        Console.WriteLine(" 5 - Remover Produto");
                        Console.WriteLine(" 6 - Voltar");
                        Console.Write(" 👉 ");

                        try
                        {
                            opcao = int.Parse(Console.ReadLine() ?? "0");

                            switch (opcao)
                            {
                                case 1:
                                    produtoUI.Cadastrar();
                                    break;
                                case 2:
                                    produtoUI.Alterar();
                                    break;
                                case 3:
                                    produtoUI.BuscarTodos();
                                    break;
                                case 4:
                                    produtoUI.BuscarPorId();
                                    break;
                                case 5:
                                    produtoUI.Remover();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine(" 😳 Opção Inválida!");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
                        }
                        break;

                    case 4:
                        Console.WriteLine(" 💳 VENDA 💳 ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Selecione uma opção: ");
                        Console.WriteLine(" 1 - Realizar Venda");
                        Console.WriteLine(" 2 - Buscar Todas as Vendas");
                        Console.WriteLine(" 3 - Buscar Venda por Id");
                        Console.WriteLine(" 4 - Buscar Venda por Data");
                        Console.WriteLine(" 5 - Buscar por Cliente");
                        Console.WriteLine(" 6 - Voltar");
                        Console.Write(" 👉 ");
                        try
                        {
                            opcao = int.Parse(Console.ReadLine() ?? "0");

                            switch (opcao)
                            {
                                case 1:
                                    vendaUI.RealizarVenda();
                                    break;
                                case 2:
                                    vendaUI.BuscarTodas();
                                    break;
                                case 3:
                                    vendaUI.BuscarPorId();
                                    break;
                                case 4:
                                    vendaUI.BuscarPorData();
                                    break;
                                case 5:
                                    vendaUI.BuscarPorCliente();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine(" 😳 Opção Inválida!");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine(" 👋 Tchau, tchau...");
                        return;
                    default:
                        Console.WriteLine(" 😳 Opção Inválida!");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
            }
        }
    }
}