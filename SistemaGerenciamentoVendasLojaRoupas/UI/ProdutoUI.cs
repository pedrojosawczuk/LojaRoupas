using System;
using System.Collections.Generic;
using SistemaGerenciamentoVendasLojaRoupas.Model;

namespace SistemaGerenciamentoVendasLojaRoupas.UI
{
    public class ProdutoUI
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Categoria> categorias = new List<Categoria>();

        /*public ProdutoUI(Produto produtos)
        {
            this.produtos.Add(produtos);
        }*/

        public void Cadastrar()
        {
            Console.WriteLine(" 👗 CADASTRO DE PRODUTO 👗 ");
            Console.Write(" -> Nome: ");
            string nome = Console.ReadLine();
            Console.Write(" -> Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write(" -> Preço: ");
            double preco = double.Parse(Console.ReadLine());
/*
            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine($" {categoria.Id} - {categoria.Nome}");
            }*/

            Console.Write(" -> ID da categoria: ");
            int idCategoria = int.Parse(Console.ReadLine());

            Categoria categoria = new Categoria(idCategoria, nome, descricao);

            if (categoria == null)
            {
                Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
                return;
            }

            Produto produto = new Produto(produtos.Count + 1, nome, descricao, preco, categoria);
            produtos.Add(produto);

            Console.WriteLine(" 👗 Produto cadastrado com sucesso! ✅ ");
        }

        public void Alterar()
        {
            Console.WriteLine("ALTERAÇÃO DE PRODUTO");
            Console.Write(" -> ID do produto: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto == null)
            {
                Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
                return;
            }

            Console.Write(" -> Nome: ");
            string nome = Console.ReadLine();
            Console.Write(" -> Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write(" -> Preço: ");
            double preco = double.Parse(Console.ReadLine());

            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine($" {categoria.Id} - {categoria.Nome}");
            }

            Console.Write(" -> ID da categoria: ");
            int idCategoria = int.Parse(Console.ReadLine());





            produto.Categoria = categorias.Find(c => c.Id == idCategoria);
            /*
            Categoria categoria = CategoriaUI.BuscarPorId(idCategoria);
            
            Console.WriteLine(" ->" + categoria.Id + "<- ");
            Console.WriteLine(" ->" + categoria.Nome + "<- ");
            Console.WriteLine(" ->" + categoria.Descricao + "<- ");

*/

            if (produto.Categoria == null)
            {
                Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
                return;
            }

            produto.Nome = nome;
            produto.Descricao = descricao;
            produto.Preco = preco;
            produto.Categoria = produto.Categoria;

            Console.WriteLine("Produto alterado com sucesso! ✅ ");
        }

        public void BuscarTodos()
        {
            Console.WriteLine(" 📜 LISTA DE PRODUTOS 📜 ");
            Console.WriteLine("--------------------");

            foreach (Produto produto in produtos)
            {
                Console.WriteLine($" {produto.Id} - Nome: {produto.Nome} | Descrição: {produto.Descricao} | Preço: {produto.Preco} | Categoria: {produto.Categoria.Nome}");
            }
        }

        public void BuscarPorId()
        {
            Console.WriteLine("BUSCA DE PRODUTO POR ID");
            Console.Write(" -> ID do produto: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto == null)
            {
                Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
                return;
            }

            Console.WriteLine($" {produto.Id} - Nome: {produto.Nome} | Descrição: {produto.Descricao} | Preço: {produto.Preco} | Categoria: {produto.Categoria.Nome}");
        }

        public void Remover()
        {
            Console.WriteLine("REMOÇÃO DE PRODUTO");
            Console.Write(" -> ID do produto: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto == null)
            {
                Console.WriteLine(" 👗 Produto não encontrado! 🗺️ ");
                return;
            }

            produtos.Remove(produto);

            Console.WriteLine("Produto removido com sucesso! 🗑️ ");
        }

    }
}