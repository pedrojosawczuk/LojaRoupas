namespace SistemaGerenciamentoVendasLojaRoupas.Model;

public class Venda
{
    public int Id { get; set; }
    private Cliente _cliente;
    private List<Produto> _produtos;
    private double _preco;
    private int _quantidade;
    private string _data;
    private double _valorTotal;

    public static List<Venda> vendas = new List<Venda>();

    public Venda(int id, Cliente cliente, List<Produto> produtos, double preco, int quantidade, string data)
    {
        Id = id;
        this._cliente = cliente;
        this._produtos = produtos;
        this._preco = preco;
        this._quantidade = quantidade;
        this._data = data;
        CalcularTotal(this._produtos);
    }

    public Cliente Cliente
    {
        get { return _cliente; }
        set { this._cliente = value; }
    }

    public List<Produto> Produtos
    {
        get { return _produtos; }
        set { this._produtos = value; }
    }

    private double Preco
    {
        get { return _preco; }
        set { this._preco = value; }
    }
    private int Quantidade
    {
        get { return _quantidade; }
        set { this._quantidade = value; }
    }
    public string Data
    {
        get { return _data; }
        set { this._data = value; }
    }

    public double ValorTotal
    {
        get { return CalcularTotal(this._produtos);}
        set { this._valorTotal = CalcularTotal(this._produtos); }
    }

    public double CalcularTotal(List<Produto> produtos)
    {
        double total = 0;
        foreach (Produto produto in _produtos)
        {
            total += this._quantidade * this._preco;
        }
        _valorTotal = total;
        return total;
    }
}