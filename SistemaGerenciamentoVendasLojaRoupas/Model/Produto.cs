namespace SistemaGerenciamentoVendasLojaRoupas.Model
{
    public class Produto
    {
        public int Id { get; set; }
        private string _nome;
        private string _descricao;
        private double _preco;
        public Categoria Categoria { get; set; }

        public Produto(int id, string nome, string descricao, double preco, Categoria categoria)
        {
            Id = id;
            _nome = nome;
            _descricao = descricao;
            _preco = preco;
            Categoria = categoria;
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
    }

}