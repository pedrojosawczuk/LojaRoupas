namespace LojaRoupas.Model;

public class ProdutoModel
{
    public long ProdutoID;
    private string _nome;
    private string _descricao;
    private double _preco;
    private double _quantidade;
    private CategoriaModel _categoria;

    public ProdutoModel(long produtoID, string nome, string descricao, double preco, int quantidade, CategoriaModel categoria)
    {
        ProdutoID = produtoID;
        _nome = nome;
        _descricao = descricao;
        _preco = preco;
        _quantidade = quantidade;
        _categoria = categoria;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public string Descricao
    {
        get { return _descricao; }
        set { _descricao = value; }
    }
    public double Preco
    {
        get { return _preco; }
        set { _preco = value; }
    }
    public CategoriaModel Categoria
    {
        get { return _categoria; }
        set { _categoria = value; }
    }
    public double Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }
}