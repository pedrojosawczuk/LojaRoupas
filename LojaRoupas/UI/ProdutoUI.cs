using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.UI;

public class ProdutoUI
{
    List<Produto> produtos = Produto.produtos;
    List<Categoria> categorias = Categoria.categorias;

    /*public ProdutoUI(List<Categoria> categorias)
    {
        this.categorias = categorias;
    }*/

    public void Cadastrar()
    {
        Console.WriteLine(" 👗 CADASTRO DE PRODUTO 👗 ");
        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "";
        Console.Write(" -> Preço: ");
        double preco = double.Parse(Console.ReadLine() ?? "");
        Console.Write(" -> Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine(" ");
        foreach (Categoria categoria1 in categorias)
        {
            Console.WriteLine($" {categoria1.CategoriaID} - {categoria1.Nome}");
        }
        Console.WriteLine(" ");

        Console.Write(" -> ID da categoria: ");
        int idCategoria = int.Parse(Console.ReadLine() ?? "0");

        Categoria? categoria = categorias.Find(c => c.CategoriaID == idCategoria);

        if (categoria == null)
        {
            Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
            return;
        }

        Produto produto = new Produto(produtos.Count + 1, nome, descricao, preco, quantidade, categoria);
        produtos.Add(produto);

        Console.WriteLine(" 👗 Produto cadastrado com sucesso! ✅ ");
    }

    public void Alterar()
    {
        Console.WriteLine(" 👗 ALTERAÇÃO DE PRODUTO");
        Console.Write(" -> ID do produto: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Produto? produto = produtos.Find(p => p.ProdutoID == id);

        if (produto == null)
        {
            Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
            return;
        }

        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "0";
        Console.Write(" -> Preço: ");
        double preco = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine(" ");
        foreach (Categoria categoria in categorias)
        {
            Console.WriteLine($" {categoria.CategoriaID} - {categoria.Nome}");
        }
        Console.WriteLine(" ");

        Console.Write(" -> Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine() ?? "");

        Console.Write(" -> ID da categoria: ");
        int idCategoria = int.Parse(Console.ReadLine() ?? "0");

        Categoria? categoria1 = categorias.Find(c => c.CategoriaID == idCategoria);

        if (categoria1 == null)
        {
            Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
            return;
        }
        produto.Categoria = categoria1;

        produto.Nome = nome;
        produto.Descricao = descricao;
        produto.Preco = preco;
        produto.Quantidade = quantidade;
        produto.Categoria = produto.Categoria;

        Console.WriteLine("Produto alterado com sucesso! ✅ ");
    }

    public void BuscarTodos()
    {
        Console.WriteLine(" 📜 TODOS OS PRODUTOS 📜 ");

        Console.WriteLine(" ");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($" {produto.ProdutoID} - Nome: {produto.Nome} | Descrição: {produto.Descricao} | Preço: {produto.Preco} | Quantidade: {produto.Quantidade} | Categoria: {produto.Categoria.Nome}");
        }
        Console.WriteLine(" ");
    }

    public void BuscarPorId()
    {
        Console.WriteLine("BUSCA DE PRODUTO POR ID");
        Console.Write(" -> ID do produto: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Produto? produto = produtos.Find(p => p.ProdutoID == id);

        if (produto == null)
        {
            Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
            return;
        }

        Console.WriteLine($" {produto.ProdutoID} - Nome: {produto.Nome} | Descrição: {produto.Descricao} | Preço: {produto.Preco} | Quantidade: {produto.Quantidade} | Categoria: {produto.Categoria.Nome}");
    }

    public void Remover()
    {
        Console.WriteLine("REMOÇÃO DE PRODUTO");
        Console.Write(" -> ID do produto: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Produto? produto = produtos.Find(p => p.ProdutoID == id);

        if (produto == null)
        {
            Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
            return;
        }

        produtos.Remove(produto);

        Console.WriteLine(" Produto removido com sucesso! 🗑️ ");
    }

}