namespace LojaRoupas.Model;

public class ClienteModel
{
    public long ClienteID { get; private set; }
    private string _nome;
    private string _sobrenome;
    private string _endereco;
    private string _telefone;

    public ClienteModel(long clienteID, string nome, string sobrenome, string endereco, string telefone)
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
    public string NomeCompleto
    {
        get
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}