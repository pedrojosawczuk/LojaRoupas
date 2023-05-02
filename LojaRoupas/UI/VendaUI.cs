using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.UI;

public class VendaUI
{
    List<Categoria> categorias = Categoria.categorias;
    List<Produto> produtos = Produto.produtos;
    List<Cliente> clientes = Cliente.clientes;
    List<Venda> vendas = Venda.vendas;

    /*
    public VendaUI(List<Cliente> clientes, List<Produto> produtos)
    {
        this.clientes = clientes;
        this.produtos = produtos;
    }
    */

    public void RealizarVenda()
    {
        Console.WriteLine(" 💳 REALIZAÇÃO DE VENDA 💳 ");

        Console.WriteLine(" ");
        foreach (Cliente cliente1 in clientes)
        {
            Console.WriteLine($" {cliente1.ClienteID} - Nome: {cliente1.Nome} | Sobrenome: {cliente1.Sobrenome} | Endereco: {cliente1.Endereco} | Telefone: {cliente1.Telefone}");
        }
        Console.WriteLine(" ");

        Console.Write(" -> Id do cliente: ");
        int Id = int.Parse(Console.ReadLine() ?? "0");

        Cliente? cliente = clientes.Find(c => c.ClienteID == Id);

        if (cliente == null)
        {
            Console.WriteLine(" 👤 Cliente não encontrado! 🗺️ ");
            return;
        }

        Console.WriteLine(" ");
        foreach (Produto produto1 in produtos)
        {
            Console.WriteLine($" {produto1.ProdutoID} - Nome: {produto1.Nome} | Descrição: {produto1.Descricao} | Preço: {produto1.Preco} | Quantidade: {produto1.Quantidade} | Categoria: {produto1.Categoria.Nome}");
        }
        Console.WriteLine(" ");

        Console.Write(" -> ID do produto: ");
        int idProduto = int.Parse(Console.ReadLine() ?? "0");

        Produto? produto = produtos.Find(p => p.ProdutoID == idProduto);

        if (produto == null)
        {
            Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
            return;
        }

        Console.Write(" -> Data (dd/mm/aaaa): ");
        string date = Console.ReadLine() ?? "0";

        Console.Write(" -> Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine() ?? "0");

        if (quantidade > produto.Quantidade)
        {
            Console.WriteLine("Quantidade solicitada é maior do que a quantidade em estoque!");
            return;
        }

        Venda venda = new Venda(vendas.Count + 1, cliente, produtos, produto.Preco, quantidade, date);
        vendas.Add(venda);

        produto.Quantidade -= quantidade;

        Console.WriteLine(" 💳 Venda realizada com sucesso! ✅ ");
    }

    public void BuscarTodas()
    {
        Console.WriteLine(" 📜 TODAS AS VENDAS 📜 ");

        Console.WriteLine(" ");
        foreach (Venda venda in vendas)
        {
            Console.WriteLine($" {venda.VendaID} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome} | Produto: {venda.Produtos} | Produto: {venda.Produtos} | Valor Total: {venda.ValorTotal}");
        }
        Console.WriteLine(" ");
    }

    public void BuscarPorId()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE VENDA POR ID 🪪 ");
        Console.Write(" -> ID da venda: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Venda? venda = vendas.Find(v => v.VendaID == id);

        if (venda == null)
        {
            Console.WriteLine(" 💳 Venda não encontrada! 🗺️ ");
            return;
        }

        Console.WriteLine($" {venda.VendaID} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome} | Produto: {venda.Produtos[0].Nome} |  Valor Total: {venda.ValorTotal}");
    }
    public void BuscarPorData()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE VENDA POR DATA 📅 ");
        Console.Write(" -> Data (dd/mm/aaaa): ");
        string dataString = Console.ReadLine() ?? "0";

        List<Venda> vendasEncontradas = vendas.FindAll(v => v.Data == dataString);

        Console.WriteLine($" Foram encontradas {vendasEncontradas.Count} vendas nesta data:");
        Console.WriteLine("--------------------");

        Console.WriteLine(" ");
        foreach (Venda venda in vendasEncontradas)
        {
            Console.WriteLine($" {venda.VendaID} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome}");
        }
        Console.WriteLine(" ");
    }

    public void BuscarPorCliente()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE VENDA POR CLIENTE 👤 ");
        Console.Write(" -> ID do cliente: ");
        int idCliente = int.Parse(Console.ReadLine() ?? "0");

        Cliente? cliente = clientes.Find(c => c.ClienteID == idCliente);

        if (cliente == null)
        {
            Console.WriteLine(" 👤 Cliente não encontrado! 🗺️  ");
            return;
        }

        List<Venda> vendasEncontradas = vendas.FindAll(v => v.Cliente.ClienteID == idCliente);

        if (vendasEncontradas.Count == 0)
        {
            Console.WriteLine(" 💳 Nenhuma venda encontrada para este cliente! 🗺️ ");
            return;
        }

        Console.WriteLine(" ");
        Console.WriteLine($" Foram encontradas {vendasEncontradas.Count} vendas para o cliente {cliente.Nome}:");

        Console.WriteLine(" ");

        foreach (Venda venda in vendasEncontradas)
        {
            Console.WriteLine($" {venda.VendaID} - Data: {venda.Data} | Cliente: {venda.Cliente.Nome} | Total: R${venda.CalcularTotal(venda.Produtos):F2}");
        }
        Console.WriteLine(" ");
    }
}