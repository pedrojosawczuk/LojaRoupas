namespace SistemaGerenciamentoVendasLojaRoupas.Model;

public class Produto
{
    public int Id { get; set; }
    private string _nome;
    private string _descricao;
    private double _preco;
    private int _quantidade;
    private Categoria _categoria;

    public static List<Produto> produtos = new List<Produto>();

    public Produto(int id, string nome, string descricao, double preco, int quantidade, Categoria categoria)
    {
        Id = id;
        this._nome = nome;
        this._descricao = descricao;
        this._preco = preco;
        this._quantidade = quantidade;
        this._categoria = categoria;
    }

    public string Nome
    {
        get { return _nome; }
        set { this._nome = value; }
    }

    public string Descricao
    {
        get { return _descricao; }
        set { this._descricao = value; }
    }

    public double Preco
    {
        get { return _preco; }
        set { this._preco = value; }
    }
    public Categoria Categoria
    {
        get { return _categoria; }
        set { this._categoria = value; }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set { this._quantidade = value; }
        /*
        int vendasProdutos;
        return vendasProdutos.Where(vp => vp.Produto.Id == this.Id).Sum(vp => vp.Quantidade);
        */
    }
}