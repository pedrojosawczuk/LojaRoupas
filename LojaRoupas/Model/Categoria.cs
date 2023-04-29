namespace LojaRoupas.Model;

public class Categoria
{
    public int Id { get; set; }
    private string _nome;
    private string _descricao;

    public static List<Categoria> categorias = new List<Categoria>();

    public Categoria(int id, string nome, string descricao)
    {
        Id = id;
        this._nome = nome;
        this._descricao = descricao;
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
}