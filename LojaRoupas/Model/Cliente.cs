namespace LojaRoupas.Model;

public class Cliente
{
    public long ClienteID;
    private string _nome;
    private string _sobrenome;
    private string _endereco;
    private string _telefone;

    public static List<Cliente> clientes = new List<Cliente>();

    public Cliente(long clienteID, string nome, string sobrenome, string endereco, string telefone)
    {
        ClienteID = clienteID;
        _nome = nome;
        _sobrenome = sobrenome;
        _endereco = endereco;
        _telefone = telefone;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public string Sobrenome
    {
        get { return _sobrenome; }
        set { _sobrenome = value; }
    }
    public string Endereco
    {
        get { return _endereco; }
        set { _endereco = value; }
    }
    public string Telefone
    {
        get { return _telefone; }
        set { _telefone = value; }
    }
}