using System;
using System.Collections.Generic;
using LojaRoupas.Model;

namespace LojaRoupas.UI;

public class ClienteUI
{
    List<Cliente> clientes = Cliente.clientes;

    public void Cadastrar()
    {
        Console.WriteLine(" 🤔 CADASTRO DE CLIENTE 🤔 ");
        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Sobrenome: ");
        string sobrenome = Console.ReadLine() ?? "0";
        Console.Write(" -> Endereco: ");
        string endereco = Console.ReadLine() ?? "0";
        Console.Write(" -> Telefone: ");
        string telefone = Console.ReadLine() ?? "0";

        Cliente cliente = new Cliente(clientes.Count + 1, nome, sobrenome, endereco, telefone);
        clientes.Add(cliente);

        Console.WriteLine(" 👤 Cliente cadastrado com sucesso! ✅ ");
    }

    public void Alterar()
    {
        Console.WriteLine(" 🧑 ALTERAÇÃO DE CLIENTE 🧑 ");
        Console.Write(" -> ID do cliente: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Cliente? cliente = clientes.Find(c => c.Id == id);

        if (cliente == null)
        {
            Console.WriteLine(" 👤 Cliente não encontrado! 🗺️ ");
            return;
        }

        Console.Write(" -> Nome: ");
        string nome = Console.ReadLine() ?? "0";
        Console.Write(" -> Sobreome: ");
        string sobrenome = Console.ReadLine() ?? "0";
        Console.Write(" -> Endereço: ");
        string endereco = Console.ReadLine() ?? "0";
        Console.Write(" -> Telefone: ");
        string telefone = Console.ReadLine() ?? "0";

        cliente.Nome = nome;
        cliente.Sobrenome = sobrenome;
        cliente.Endereco = endereco;
        cliente.Telefone = telefone;

        Console.WriteLine(" 👤 Cliente alterado com sucesso! ✅ ");
    }

    public void BuscarTodas()
    {
        Console.WriteLine(" 📜 TODOS OS CLIENTES 📜 ");

        Console.WriteLine(" ");
        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine($" {cliente.Id} - Nome: {cliente.Nome} | Sobrenome: {cliente.Sobrenome} | Endereco: {cliente.Endereco} | Telefone: {cliente.Telefone}");
        }
        Console.WriteLine(" ");
    }

    public void BuscarPorId()
    {
        Console.WriteLine(" 🕵️‍♀️ BUSCA DE CLIENTE POR ID 🕵️‍♀️ ");
        Console.Write(" -> ID do cliente: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Cliente? cliente = clientes.Find(c => c.Id == id);

        if (cliente == null)
        {
            Console.WriteLine(" 👤 Cliente não encontrado! 🗺️ ");
            return;
        }

        Console.WriteLine($" {cliente.Id} - Nome: {cliente.Nome} | Sobrenome: {cliente.Sobrenome} | Endereco: {cliente.Endereco} | Telefone: {cliente.Telefone}");
    }

    public void Remover()
    {
        Console.WriteLine(" 💀 REMOÇÃO DE CLIENTE 💀 ");
        Console.Write(" -> ID do cliente: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Cliente? cliente = clientes.Find(c => c.Id == id);

        if (cliente == null)
        {
            Console.WriteLine(" 👤 Cliente não encontrado! 🗺️ ");
            return;
        }

        clientes.Remove(cliente);

        Console.WriteLine(" 💀 Cliente removido com sucesso! ⚰️ ");
    }
}