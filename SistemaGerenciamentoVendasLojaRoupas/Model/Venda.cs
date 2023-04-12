namespace SistemaGerenciamentoVendasLojaRoupas.Model
{
    public class Venda
    {
        public int Id { get; set; }
        private List<Cliente> _cliente;
        private List<Produto> _produtos;
        private DateTime _data;
        private double _valorTotal;

        public Venda(int id, List<Cliente> cliente, List<Produto> produtos, DateTime data, double valorTotal)
        {
            Id = id;
            _cliente = cliente;
            _produtos = produtos;
            _data = data;
            _valorTotal = valorTotal;
        }

        public List<Cliente> Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public List<Produto> Produtos
        {
            get { return _produtos; }
            set { _produtos = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public double ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }
    }
}