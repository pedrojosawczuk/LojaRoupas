namespace SistemaGerenciamentoVendasLojaRoupas.Model;

public class Cliente
{
    public int Id { get; set; }
    private string _nome;
    private string _sobrenome;
    private string _endereco;
    private string _telefone;

    public static List<Cliente> clientes = new List<Cliente>();

    public Cliente(int id, string nome, string sobrenome, string endereco, string telefone)
    {
        Id = id;
        this._nome = nome;
        this._sobrenome = sobrenome;
        this._endereco = endereco;
        this._telefone = telefone;
    }

    public string Nome
    {
        get { return _nome; }
        set { this._nome = value; }
    }
    public string Sobrenome
    {
        get { return _sobrenome; }
        set { this._sobrenome = value; }
    }
    public string Endereco
    {
        get { return _endereco; }
        set { this._endereco = value; }
    }
    public string Telefone
    {
        get { return _telefone; }
        set { this._telefone = value; }
    }
}