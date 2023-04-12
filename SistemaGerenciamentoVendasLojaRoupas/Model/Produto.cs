namespace SistemaGerenciamentoVendasLojaRoupas.Model
{
    public class Produto
    {
        public int Id { get; set; }
        private string _nome;
        private string _descricao;
        private double _preco;
        private List<Categoria> _categoria;

        public Produto(int id, string nome, string descricao, double preco, List<Categoria> categoria)
        {
            Id = id;
            _nome = nome;
            _descricao = descricao;
            _preco = preco;
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
        public List<Categoria> Categorias
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
    }

}