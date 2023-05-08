namespace LojaRoupas.Model;

public class VendaProdutoModel
{
    public long VendaProdutoID;
    private ProdutoModel _produto;
    private double _quantidade { get; set; }
    private double _precoUniatario { get; set; }

    public VendaProdutoModel(long vendaProdutoID, ProdutoModel produto, double quantidade, double precoUnitario)
    {
        VendaProdutoID = vendaProdutoID;
        _produto = produto;
        _quantidade = quantidade;
        _precoUniatario = precoUnitario;
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
        get { return _precoUniatario; }
        set { _precoUniatario = value; }
    }
    public double Subtotal
    {
        get { return _quantidade * _precoUniatario; }
    }
}