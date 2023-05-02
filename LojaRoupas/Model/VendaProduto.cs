namespace LojaRoupas.Model;

public class VendaProduto
{
    public long VendaProdutoID;
    private Produto? _produto { get; set; }
    private double _quantidade { get; set; }
    private double _precoUniatario { get; set; }

    public Produto? Produto 
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