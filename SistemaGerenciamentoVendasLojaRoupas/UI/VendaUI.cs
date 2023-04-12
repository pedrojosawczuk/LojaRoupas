using System;
using System.Collections.Generic;
using SistemaGerenciamentoVendasLojaRoupas.Model;

namespace SistemaGerenciamentoVendasLojaRoupas.UI
{
    public class VendaUI
    {
        private List<Venda> vendas = new List<Venda>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Produto> produtos = new List<Produto>();
        DateTime date = DateTime.Now;

        /*public VendaUI(List<Venda> vendas, List<Cliente> clientes, List<Produto> produtos)
        {
            this.vendas = vendas;
            this.clientes = clientes;
            this.produtos = produtos;
        }*/

        public void RealizarVenda()
        {
            Console.WriteLine("REALIZAÇÃO DE VENDA");
            Console.Write("Id do cliente: ");
            int Id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == Id);

            Console.WriteLine(cliente);
            if (cliente == null)
            {
                Console.WriteLine(" 👤 Cliente não encontrado! 🗺️  ");
                return;
            }

            Console.Write("ID do produto: ");
            int idProduto = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == idProduto);

            if (produto == null)
            {
                Console.WriteLine(" 👗 Produto não encontrado! 🗺️  ");
                return;
            }

            /*
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade > produto.QuantidadeEstoque)
            {
                Console.WriteLine("Quantidade solicitada é maior do que a quantidade em estoque!");
                return;
            }*/

            Venda venda = new Venda(vendas.Count + 1, cliente, produtos, date, 1);
            vendas.Add(venda);

            /*produto.QuantidadeEstoque -= quantidade;*/

            Console.WriteLine("Venda realizada com sucesso! ✅ ");
        }

        public void BuscarTodas()
        {
            Console.WriteLine("LISTA DE VENDAS");
            Console.WriteLine("--------------------");

            foreach (Venda venda in vendas)
            {
                Console.WriteLine($" {venda.Id} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome} | Produto: {venda.Produtos[0].Nome} | Valor Total: {venda.ValorTotal}");
            }
        }

        public void BuscarPorId()
        {
            Console.WriteLine("BUSCA DE VENDA POR ID");
            Console.Write("ID da venda: ");
            int id = int.Parse(Console.ReadLine());

            Venda venda = vendas.Find(v => v.Id == id);

            if (venda == null)
            {
                Console.WriteLine("Venda não encontrada!");
                return;
            }

            Console.WriteLine($" {venda.Id} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome} | Produto: {venda.Produtos[0].Nome} |  Valor Total: {venda.ValorTotal}");
        }
        public void BuscarPorData()
        {
            Console.WriteLine("BUSCA DE VENDA POR DATA");
            Console.Write("Data (dd/mm/aaaa): ");
            string dataString = Console.ReadLine();

            DateTime data;

            try
            {
                data = DateTime.ParseExact(dataString, "dd/MM/yyyy", null);
            }
            catch (FormatException)
            {
                Console.WriteLine("Data inválida!");
                return;
            }

            List<Venda> vendasEncontradas = vendas.FindAll(v => v.Data.Date == data.Date);

            Console.WriteLine($"Foram encontradas {vendasEncontradas.Count} vendas nesta data:");
            Console.WriteLine("--------------------");

            foreach (Venda venda in vendasEncontradas)
            {
                Console.WriteLine($" {venda.Id} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome}");
            }
        }

        public void BuscarPorCliente()
        {
            Console.WriteLine("BUSCA DE VENDA POR CLIENTE");
            Console.Write("ID do cliente: ");
            int idCliente = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == idCliente);

            if (cliente == null)
            {
                Console.WriteLine(" 👤 Cliente não encontrado! 🗺️  ");
                return;
            }

            List<Venda> vendasEncontradas = vendas.FindAll(v => v.Cliente.Id == idCliente);

            if (vendasEncontradas.Count == 0)
            {
                Console.WriteLine("Nenhuma venda encontrada para este cliente!");
                return;
            }

            Console.WriteLine($"Foram encontradas {vendasEncontradas.Count} vendas para o cliente {cliente.Nome}:");
            Console.WriteLine("--------------------");

            /*foreach (Venda venda in vendasEncontradas)
            {
                Console.WriteLine($" {venda.Id} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome} | Total: R${venda.CalcularTotal():F2}");
            }*/
        }
    }
}