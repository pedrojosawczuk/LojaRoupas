namespace SistemaGerenciamentoVendasLojaRoupas.Model
{
    public class Venda
    {
        public int id { get; set; }
        private Cliente cliente { get; set; }
        private List<Produto> produtos { get; set; }
        private DateTime data { get; set; }
        private double valorTotal { get; set; }

        public Venda(int id, Cliente cliente, List<Produto> produtos, DateTime data, double valorTotal)
        {
            this.id = id;
            this.cliente = cliente;
            this.produtos = produtos;
            this.data = data;
            this.valorTotal = valorTotal;
        }
    }
}