using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.UI;

public class CategoriaUI
{
    List<Categoria> categorias = Categoria.categorias;

    public void Cadastrar()
    {
        Console.WriteLine("CADASTRO DE CATEGORIA");
        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "0";

        Categoria categoria = new Categoria(categorias.Count + 1, nome, descricao);
        categorias.Add(categoria);

        Console.WriteLine(" 🧾 Categoria cadastrada com sucesso! ✅ ");
    }

    public void Alterar()
    {
        Console.WriteLine("ALTERAÇÃO DE CATEGORIA");
        Console.Write(" -> ID da categoria: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Categoria? categoria = categorias.Find(c => c.CategoriaID == id);

        if (categoria == null)
        {
            Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
            return;
        }

        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Descrição: ");
        string descricao = Console.ReadLine() ?? "0";

        categoria.Nome = nome;
        categoria.Descricao = descricao;

        Console.WriteLine(" 🧾 Categoria Alterada com Sucesso! ✅ ");
    }

    public void BuscarTodas()
    {
        Console.WriteLine(" 📜 TODAS AS CATEGORIAS 📜 ");

        Console.WriteLine(" ");
        foreach (Categoria categoria in categorias)
        {
            Console.WriteLine($" {categoria.CategoriaID} - Nome: {categoria.Nome} | Descrição: {categoria.Descricao}");
        }
        Console.WriteLine(" ");
    }

    public void BuscarPorId()
    {
        Console.WriteLine("BUSCA DE CATEGORIA POR ID");
        Console.Write(" -> ID da categoria: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Categoria? categoria = categorias.Find(c => c.CategoriaID == id);

        if (categoria == null)
        {
            Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
            return;
        }

        Console.WriteLine($" {categoria.CategoriaID} - Nome: {categoria.Nome} | Descrição: {categoria.Descricao}");
    }

    public void Remover()
    {
        Console.WriteLine("REMOÇÃO DE CATEGORIA");
        Console.Write(" -> ID da categoria: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Categoria? categoria = categorias.Find(c => c.CategoriaID == id);

        if (categoria == null)
        {
            Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
            return;
        }

        categorias.Remove(categoria);

        Console.WriteLine(" 🧾 Categoria removida com sucesso! 🗑️ ");
    }
}