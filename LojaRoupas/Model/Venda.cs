namespace LojaRoupas.Model;

public class Venda
{
    public long VendaID;
    private Cliente _cliente;
    private List<Produto> _produtos;
    private double _preco;
    private int _quantidade;
    private string _data;
    private double _valorTotal;

    public static List<Venda> vendas = new List<Venda>();

    public Venda(long vendaID, Cliente cliente, List<Produto> produtos, double preco, int quantidade, string data)
    {
        VendaID = vendaID;
        _cliente = cliente;
        _produtos = produtos;
        _preco = preco;
        _quantidade = quantidade;
        _data = data;
        CalcularTotal(_produtos);
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

    private double Preco
    {
        get { return _preco; }
        set { _preco = value; }
    }
    private int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }
    public string Data
    {
        get { return _data; }
        set { _data = value; }
    }

    public double ValorTotal
    {
        get { return CalcularTotal(_produtos); }
        set { _valorTotal = CalcularTotal(_produtos); }
    }

    public double CalcularTotal(List<Produto> produtos)
    {
        double total = 0;
        foreach (Produto produto in _produtos)
        {
            total += produto.Quantidade * produto.Preco;
        }
        _valorTotal = total;
        return total;
    }
}