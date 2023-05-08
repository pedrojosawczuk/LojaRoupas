using LojaRoupas.Model;
using LojaRoupas.UI.Cliente;
using LojaRoupas.UI.Categoria;
using LojaRoupas.UI.Produto;
using LojaRoupas.UI.Venda;

using LojaRoupas.Inicializacao;

namespace LojaRoupas;

class Program
{
    static List<CategoriaModel> categorias = new List<CategoriaModel>();
    static List<ProdutoModel> produtos = new List<ProdutoModel>();
    static List<ClienteModel> clientes = new List<ClienteModel>();
    static List<VendaProdutoModel> vendaProdutos = new List<VendaProdutoModel>();
    static List<VendaModel> vendas = new List<VendaModel>();

    public static void Main(string[] args)
    {
        new BaseDeDados(categorias, produtos, clientes, vendaProdutos, vendas).PopularBaseDeDados();

        bool continuar = true;

        do
        {
            Console.WriteLine(" 🛍️ Loja de Roupas👗 ");
            //Console.WriteLine(" ");
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
                        Console.Clear();
                        new ClienteUI(clientes).MenuCliente();
                        break;

                    case 2:
                        Console.Clear();
                        new CategoriaUI(categorias).MenuCategoria();
                        break;

                    case 3:
                        Console.Clear();
                        new ProdutoUI(produtos, categorias).MenuProduto();
                        break;

                    case 4:
                        Console.Clear();
                        new VendaUI(produtos, clientes, vendaProdutos, vendas).MenuVenda();
                        break;

                    case 5:
                        Console.Clear();
                        continuar = false;
                        Console.WriteLine(" 👋 Tchau, tchau...");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine(" 😳 Opção Inválida!");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
            }
        } while (continuar);
    }
}