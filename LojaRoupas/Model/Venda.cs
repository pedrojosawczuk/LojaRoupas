namespace LojaRoupas.Model;

public class VendaModel
{
    public long VendaID;
    private ClienteModel _cliente;
    private List<VendaProdutoModel> _produtos;
    private DateOnly _data;
    private double _valorTotal;

    public VendaModel(long vendaID, ClienteModel cliente, List<VendaProdutoModel> produtos, DateOnly data)
    {
        VendaID = vendaID;
        _cliente = cliente;
        _produtos = produtos;
        _data = data;
        CalcularTotal(_produtos);
    }

    public ClienteModel Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }
    public List<VendaProdutoModel> Produtos
    {
        get { return _produtos; }
        set { _produtos = value; }
    }
    public DateOnly Data
    {
        get { return _data; }
        set { _data = value; }
    }
    public double ValorTotal
    {
        get { return CalcularTotal(_produtos); }
        set { _valorTotal = CalcularTotal(_produtos); }
    }

    private double CalcularTotal(List<VendaProdutoModel> produtos)
    {
        double total = 0;
        foreach (VendaProdutoModel produto in _produtos)
        {
            total += produto.Subtotal;
        }
        _valorTotal = total;
        return total;
    }
}