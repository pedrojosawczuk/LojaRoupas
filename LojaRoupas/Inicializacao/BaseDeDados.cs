using LojaRoupas.Model;

namespace LojaRoupas.Inicializacao;

public class BaseDeDados
{
    private List<CategoriaModel> _categorias;
    private List<ProdutoModel> _produtos;
    private List<ClienteModel> _clientes;
    private List<VendaProdutoModel> _vendaProdutos;
    private List<VendaModel> _vendas;

    public BaseDeDados(List<CategoriaModel> categorias, List<ProdutoModel> produtos, List<ClienteModel> clientes, List<VendaProdutoModel> vendaProdutos, List<VendaModel> vendas)
    {
        _categorias = categorias;
        _produtos = produtos;
        _clientes = clientes;
        _vendaProdutos = vendaProdutos;
        _vendas = vendas;
    }
    public void PopularBaseDeDados()
    {
        CategoriaModel categoria1 = new CategoriaModel(1, "Roupas Masculinas", "Roupas para homens");
        _categorias.Add(categoria1);
        CategoriaModel categoria2 = new CategoriaModel(2, "Roupas Femininas", "Roupas para mulheres");
        _categorias.Add(categoria2);
        CategoriaModel categoria3 = new CategoriaModel(3, "Calçados", "Calçados para todos os gêneros");
        _categorias.Add(categoria3);
        CategoriaModel categoria4 = new CategoriaModel(4, "Acessórios", "Acessórios para todos os gêneros");
        _categorias.Add(categoria4);
        CategoriaModel categoria5 = new CategoriaModel(5, "Roupas Infantis", "Roupas para crianças");
        _categorias.Add(categoria5);


        ClienteModel cliente1 = new ClienteModel(1, "João", "Silva", "Rua A, 123", "(11) 1234-5678");
        _clientes.Add(cliente1);
        ClienteModel cliente2 = new ClienteModel(2, "Maria", "Souza", "Rua B, 456", "(11) 2345-6789");
        _clientes.Add(cliente2);
        ClienteModel cliente3 = new ClienteModel(3, "Pedro", "Santos", "Rua C, 789", "(11) 3456-7890");
        _clientes.Add(cliente3);
        ClienteModel cliente4 = new ClienteModel(4, "Ana", "Silveira", "Rua D, 234", "(11) 4567-8901");
        _clientes.Add(cliente4);
        ClienteModel cliente5 = new ClienteModel(5, "Fernando", "Carvalho", "Rua E, 345", "(11) 5678-9012");
        _clientes.Add(cliente5);
        ClienteModel cliente6 = new ClienteModel(6, "Mariana", "Oliveira", "Rua F, 456", "(11) 6789-0123");
        _clientes.Add(cliente6);


        ProdutoModel produto1 = new ProdutoModel(1, "Camisa Polo", "Camisa polo de algodão", 59.90, 10, categoria1);
        _produtos.Add(produto1);
        ProdutoModel produto2 = new ProdutoModel(2, "Calça Jeans", "Calça jeans slim fit", 129.90, 5, categoria1);
        _produtos.Add(produto2);
        ProdutoModel produto3 = new ProdutoModel(3, "Vestido Floral", "Vestido longo com estampa floral", 149.90, 8, categoria2);
        _produtos.Add(produto3);
        ProdutoModel produto4 = new ProdutoModel(4, "Tênis Esportivo", "Tênis para corrida e atividades físicas", 199.90, 3, categoria3);
        _produtos.Add(produto4);
        ProdutoModel produto5 = new ProdutoModel(5, "Cinto de Couro", "Cinto de couro legítimo", 49.90, 15, categoria4);
        _produtos.Add(produto5);
        ProdutoModel produto6 = new ProdutoModel(6, "Blusa de Frio", "Blusa de frio de lã", 89.90, 7, categoria1);
        _produtos.Add(produto6);
        ProdutoModel produto7 = new ProdutoModel(7, "Sapato Social", "Sapato social de couro", 169.90, 2, categoria3);
        _produtos.Add(produto7);
    }
}