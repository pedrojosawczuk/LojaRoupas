using LojaRoupas.Model;
using LojaRoupas.UI.Produto;
using LojaRoupas.UI.Cliente;

namespace LojaRoupas.UI.Venda;

public class VendaUI
{
    private List<VendaProdutoModel> _vendaProdutos;
    private List<ProdutoModel> _produtos;
    private List<CategoriaModel> _categoria;
    private List<ClienteModel> _clientes;
    private List<VendaModel> _vendas;
    public VendaUI(List<ProdutoModel> produtos, List<ClienteModel> clientes, List<VendaProdutoModel> vendasProduto, List<VendaModel> vendas)
    {
        _produtos = produtos;
        _clientes = clientes;
        _vendaProdutos = vendasProduto;
        _vendas = vendas;
    }

    public void MenuVenda()
    {
        bool continuar = true;
        do
        {

            Console.WriteLine(" 💳 VENDA 💳 ");
            //Console.WriteLine(" ");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine(" 1 - Realizar Venda");
            Console.WriteLine(" 2 - Listar Todas as Vendas");
            Console.WriteLine(" 3 - Buscar Venda por Id");
            Console.WriteLine(" 4 - Buscar Venda por Data");
            Console.WriteLine(" 5 - Buscar por Cliente");
            Console.WriteLine(" 6 - Voltar");
            Console.Write(" 👉 ");
            try
            {
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        RealizarVenda();
                        break;
                    case 2:
                        Console.Clear();
                        ListarVendas(_vendas);
                        break;
                    case 3:
                        Console.Clear();
                        BuscarVendasPorId();
                        break;
                    case 4:
                        Console.Clear();
                        BuscarVendasPorData();
                        break;
                    case 5:
                        Console.Clear();
                        BuscarVendasPorCliente();
                        break;
                    case 6:
                        Console.Clear();
                        continuar = false;
                        break;
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

    private void RealizarVenda()
    {
        Console.WriteLine(" 💳 REALIZAÇÃO DE VENDA 💳 ");

        ClienteUI listarClientes = new ClienteUI(_clientes);
        Console.Clear();
        listarClientes.ListarClientes(_clientes);

        Console.Write(" -> Id do cliente: ");
        int Id = int.Parse(Console.ReadLine() ?? "0");

        ClienteModel? cliente = _clientes.Find(c => c.ClienteID == Id);

        if (cliente == null)
        {
            Console.Clear();
            Console.WriteLine(" 👤 Cliente não encontrado! 🗺️ ");
            return;
        }

        Console.Write(" -> Data (dd/mm/aaaa): ");
        string date = Console.ReadLine() ?? "0";

        while (true)
        {
            ProdutoUI listarProduto = new ProdutoUI(_produtos, _categoria);
            Console.Clear();
            listarProduto.ListarProdutos(_produtos);

            Console.Write(" -> ID do produto: ");
            int idProduto = int.Parse(Console.ReadLine() ?? "0");

            ProdutoModel? produto = _produtos.Find(p => p.ProdutoID == idProduto);

            if (produto == null)
            {
                Console.Clear();
                Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
                return;
            }

            Console.Write(" -> Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine() ?? "0");

            if (quantidade > produto.Quantidade)
            {
                Console.Clear();
                Console.WriteLine("Quantidade Solicitada é Maior do que a Quantidade em Estoque!");
                return;
            }

            VendaProdutoModel vendaProduto = new VendaProdutoModel(
                _vendaProdutos.Max((v) => v.VendaProdutoID) + 1,
                produto,
                quantidade,
                produto.Preco
            );
            _vendaProdutos.Add(vendaProduto);
            produto.Quantidade -= quantidade;

            Console.WriteLine(" Deseja adicionar mais um produto? Digite 1 para Sair");
            bool continuar = bool.Parse(Console.ReadLine() ?? "0");
            if (continuar)
            {
                break;
            }
        }


        DateTime currentDateTime = DateTime.Today;
        DateOnly currentDate = DateOnly.FromDateTime(currentDateTime);

        VendaModel venda = new VendaModel(
            _vendas.Max((v) => v.VendaID) + 1,
            cliente,
            _vendaProdutos,
            /*vendaProduto.PrecoUnitario,
            vendaProduto.Quantidade,*/
            currentDate
        );

        Console.Clear();
        Console.WriteLine(" 💳 Venda realizada com sucesso! ✅ ");
    }

    private void BuscarVendasPorId()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE VENDA POR ID 🪪 ");
        Console.Write(" -> ID da venda: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        VendaModel? venda = _vendas.Find(v => v.VendaID == id);

        if (venda == null)
        {
            Console.Clear();
            Console.WriteLine(" 💳 Venda Não Encontrada! 🗺️ ");
            return;
        }

        Console.WriteLine($" {venda.VendaID} - Data: {venda.Data}");
        Console.WriteLine($"  -> Cliente: {venda.Cliente.Nome}");
        Console.WriteLine($"  -> Produtos: ");

        ListarVendaProdutos(venda.Produtos);

        Console.WriteLine($" Valor Total: {venda.ValorTotal}");
    }
    private void BuscarVendasPorData()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE VENDA POR DATA 📅 ");
        Console.Write(" -> Data (dd/mm/aaaa): ");
        DateOnly data = DateOnly.Parse(Console.ReadLine() ?? "0");

        List<VendaModel> vendasEncontradas = _vendas.FindAll(v => v.Data == data);

        Console.WriteLine($" Foram Encontradas {vendasEncontradas.Count} Vendas nesta data:");
        Console.WriteLine(" ");

        ListarVendas(_vendas);
    }

    private void BuscarVendasPorCliente()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE VENDA POR CLIENTE 👤 ");
        Console.Write(" -> ID do cliente: ");
        int idCliente = int.Parse(Console.ReadLine() ?? "0");

        ClienteModel? cliente = _clientes.Find(c => c.ClienteID == idCliente);

        if (cliente == null)
        {
            Console.Clear();
            Console.WriteLine(" 👤 Cliente Não Encontrado! 🗺️  ");
            return;
        }

        List<VendaModel> vendasEncontradas = _vendas.FindAll(v => v.Cliente.ClienteID == idCliente);

        if (vendasEncontradas.Count == 0)
        {
            Console.Clear();
            Console.WriteLine(" 💳 Nenhuma Venda Encontrada para Este Cliente! 🗺️ ");
            return;
        }

        Console.WriteLine(" ");
        Console.WriteLine($" Foram Encontradas {vendasEncontradas.Count} Vendas para o Cliente {cliente.Nome}:");

        ListarVendas(_vendas);
    }
    public void ListarVendaProdutos(List<VendaProdutoModel> vendaProdutos)
    {
        if (vendaProdutos.Count < 0)
        {
            Console.WriteLine(" ");
            Console.Write("\x1B[3m"); // Change font to italic
            Console.WriteLine(" Não há Produtos para Está Venda.");
            Console.ResetColor(); // Reset font style to default
        }

        foreach (VendaProdutoModel vendaProduto in vendaProdutos)
        {
            Console.WriteLine($"  -> {vendaProduto.VendaProdutoID} - Nome: {vendaProduto.Produto.Nome} | Preço: {vendaProduto.PrecoUnitario} | Quantidade: {vendaProduto.Quantidade} | SubTotal: {vendaProduto.Subtotal}");
        }
        Console.WriteLine(" ");
    }
    public void ListarVendas(List<VendaModel> vendas)
    {
        Console.Clear();
        Console.WriteLine(" 📜 TODAS AS VENDAS 📜 ");

        if (vendas.Count < 0)
        {
            Console.WriteLine(" ");
            Console.Write("\x1B[3m"); // Change font to italic
            Console.WriteLine(" Não há Vendas Realizadas.");
            Console.ResetColor(); // Reset font style to default
        }

        foreach (VendaModel venda in vendas)
        {
            Console.WriteLine($" {venda.VendaID} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome}");
        }
        Console.WriteLine(" ");
    }
}