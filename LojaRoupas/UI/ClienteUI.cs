using LojaRoupas.Model;

namespace LojaRoupas.UI.Cliente;

public class ClienteUI
{
    private List<ClienteModel> _clientes;
    public ClienteUI(List<ClienteModel> clientes)
    {
        _clientes = clientes;
    }

    public void MenuCliente()
    {
        bool continuar = true;
        do
        {
            Console.WriteLine(" 👤 CLIENTE 👤 ");
            //Console.WriteLine(" ");
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
                int opcao = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine(" ");

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        CadastrarCliente();
                        break;
                    case 2:
                        Console.Clear();
                        AlterarCliente();
                        break;
                    case 3:
                        Console.Clear();
                        ListarClientes(_clientes);
                        break;
                    case 4:
                        Console.Clear();
                        BuscarClientePorId();
                        break;
                    case 5:
                        Console.Clear();
                        RemoverCliente();
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
    private void CadastrarCliente()
    {
        Console.WriteLine(" 👤 CADASTRAR CLIENTE 👤 ");
        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Sobrenome: ");
        string sobrenome = Console.ReadLine() ?? "0";
        Console.Write(" -> Endereco: ");
        string endereco = Console.ReadLine() ?? "0";
        Console.Write(" -> Telefone: ");
        string telefone = Console.ReadLine() ?? "0";

        ClienteModel cliente = new ClienteModel
        (
            _clientes.Max((c) => c.ClienteID) + 1,
            nome,
            sobrenome,
            endereco,
            telefone
        );
        _clientes.Add(cliente);

        Console.Clear();
        Console.WriteLine(" 👤 Cliente Cadastrado com Sucesso! ✅ ");
    }

    private void AlterarCliente()
    {
        Console.WriteLine(" 🧑 ALTERAÇÃO DE CLIENTE 🧑 ");
        Console.Write(" -> ID do cliente: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        ClienteModel? cliente = _clientes.Find(c => c.ClienteID == id);

        if (cliente == null)
        {
            Console.Clear();
            Console.WriteLine(" 👤 Cliente Não Encontrado! 🗺️ ");
            return;
        }

        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Sobrenome: ");
        string sobrenome = Console.ReadLine() ?? "0";
        Console.Write(" -> Endereço: ");
        string endereco = Console.ReadLine() ?? "0";
        Console.Write(" -> Telefone: ");
        string telefone = Console.ReadLine() ?? "0";

        cliente.Nome = nome;
        cliente.Sobrenome = sobrenome;
        cliente.Endereco = endereco;
        cliente.Telefone = telefone;

        Console.Clear();
        Console.WriteLine(" 👤 Cliente Alterado com Sucesso! ✅ ");
    }

    private void BuscarClientePorId()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE CLIENTE POR ID 🕵️‍♀️ ");
        Console.Write(" -> ID do Cliente: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        ClienteModel? cliente = _clientes.Find(c => c.ClienteID == id);

        if (cliente == null)
        {
            Console.Clear();
            Console.WriteLine(" 👤 Cliente Não Encontrado! 🗺️ ");
            return;
        }

        Console.Clear();
        Console.WriteLine($" {cliente.ClienteID} - Nome: {cliente.Nome} | Sobrenome: {cliente.Sobrenome} | Endereco: {cliente.Endereco} | Telefone: {cliente.Telefone}");
    }

    private void RemoverCliente()
    {
        Console.WriteLine(" 💀 REMOÇÃO DE CLIENTE 💀 ");
        Console.Write(" -> ID do Cliente: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        ClienteModel? cliente = _clientes.Find(c => c.ClienteID == id);

        if (cliente == null)
        {
            Console.Clear();
            Console.WriteLine(" 👤 Cliente Não Encontrado! 🗺️ ");
            return;
        }

        _clientes.Remove(cliente);

        Console.Clear();
        Console.WriteLine(" 💀 Cliente Removido com Sucesso! ⚰️ ");
    }
    public void ListarClientes(List<ClienteModel> clientes)
    {
        Console.Clear();
        Console.WriteLine(" 📜 TODOS OS CLIENTES 📜 ");

        if (clientes.Count < 1)
        {
            Console.WriteLine(" ");
            Console.Write("\x1B[3m"); // Change font to italic
            Console.WriteLine(" Não há Clientes Cadastrados.");
            Console.ResetColor(); // Reset font style to default
        }

        foreach (ClienteModel cliente in clientes)
        {
            Console.WriteLine($" {cliente.ClienteID} - Nome: {cliente.NomeCompleto} | Endereco: {cliente.Endereco} | Telefone: {cliente.Telefone}");
        }
        Console.WriteLine(" ");
    }
}