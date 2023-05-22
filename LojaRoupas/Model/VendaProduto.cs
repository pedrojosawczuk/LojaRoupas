namespace LojaRoupas.Model;

public class VendaProdutoModel
{
    public long VendaProdutoID { get; private set; }
    private ProdutoModel _produto;
    private double _quantidade { get; set; }
    private double _precoUnitario { get; set; }

    public VendaProdutoModel(long vendaProdutoID, ProdutoModel produto, double quantidade, double precoUnitario)
    {
        VendaProdutoID = vendaProdutoID;
        _produto = produto;
        _quantidade = quantidade;
        _precoUnitario = precoUnitario;
    }

    public ProdutoModel Produto
    {
        get { return _produto; }
        set { _produto = value; }
    }
    public double Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }
    public double PrecoUnitario
    {
        get { return _precoUnitario; }
        set { _precoUnitario = value; }
    }
    public double Subtotal
    {
        get { return _quantidade * _precoUnitario; }
    }
}