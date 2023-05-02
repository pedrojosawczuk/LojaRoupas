namespace LojaRoupas.Model;

public class Categoria
{
    public long CategoriaID;
    private string _nome;
    private string _descricao;

    public static List<Categoria> categorias = new List<Categoria>();

    public Categoria(long categoriaID, string nome, string descricao)
    {
        CategoriaID = categoriaID;
        _nome = nome;
        _descricao = descricao;
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
}