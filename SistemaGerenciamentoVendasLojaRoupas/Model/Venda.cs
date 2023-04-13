namespace SistemaGerenciamentoVendasLojaRoupas.Model;

public class Venda
{
    public int Id { get; set; }
    private Cliente _cliente;
    private List<Produto> _produtos;
    private string _data;
    private double _valorTotal;

    public static List<Venda> vendas = new List<Venda>();

    public Venda(int id, Cliente cliente, List<Produto> produtos, string data, double valorTotal)
    {
        Id = id;
        _cliente = cliente;
        _produtos = produtos;
        _data = data;
        _valorTotal = valorTotal;
    }

    public Cliente Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }

    public List<Produto> Produtos
    {
        get { return _produtos; }
        set { _produtos = value; }
    }

    public string Data
    {
        get { return _data; }
        set { _data = value; }
    }

    public double ValorTotal
    {
        get { return _valorTotal; }
        set { _valorTotal = value; }
    }
}