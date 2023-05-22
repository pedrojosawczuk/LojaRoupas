namespace LojaRoupas.Model;

public class CategoriaModel
{
    public long CategoriaID { get; private set; }
    private string _nome;
    private string _descricao;

    public CategoriaModel(long categoriaID, string nome, string descricao)
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