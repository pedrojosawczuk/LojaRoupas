using System;
using System.Collections.Generic;
using SistemaGerenciamentoVendasLojaRoupas.Model;

namespace SistemaGerenciamentoVendasLojaRoupas.UI
{
    public class CategoriaUI
    {
        public List<Categoria> categorias = new List<Categoria>();
        /*
                public CategoriaUI(Categoria categorias)
                {
                    this.categorias.Add(categorias);
                }*/

        public void Cadastrar()
        {
            Console.WriteLine("CADASTRO DE CATEGORIA");
            Console.Write(" -> Nome: ");
            string nome = Console.ReadLine();
            Console.Write(" -> Descrição: ");
            string descricao = Console.ReadLine();

            Categoria categoria = new Categoria(categorias.Count + 1, nome, descricao);
            categorias.Add(categoria);

            Console.WriteLine(" 🧾 Categoria cadastrada com sucesso! ✅ ");
        }

        public void Alterar()
        {
            Console.WriteLine("ALTERAÇÃO DE CATEGORIA");
            Console.Write(" -> ID da categoria: ");
            int id = int.Parse(Console.ReadLine());

            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria == null)
            {
                Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
                return;
            }

            Console.Write(" -> Nome: ");
            string nome = Console.ReadLine();
            Console.Write(" -> Descrição: ");
            string descricao = Console.ReadLine();

            categoria.Nome = nome;
            categoria.Descricao = descricao;

            Console.WriteLine("🧾Categoria alterada com sucesso! ✅ ");
        }

        public void BuscarTodas()
        {
            Console.WriteLine(" 📜 LISTA DE CATEGORIAS 📜 ");
            Console.WriteLine("--------------------");

            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine($" {categoria.Id} - Nome: {categoria.Nome} | Descrição: {categoria.Descricao}");
            }
        }

        public void BuscarPorId()
        {
            Console.WriteLine("BUSCA DE CATEGORIA POR ID");
            Console.Write(" -> ID da categoria: ");
            int id = int.Parse(Console.ReadLine());

            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria == null)
            {
                Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
                return;
            }

            Console.WriteLine($" {categoria.Id} - Nome: {categoria.Nome} | Descrição: {categoria.Descricao}");
        }

        public void Remover()
        {
            Console.WriteLine("REMOÇÃO DE CATEGORIA");
            Console.Write(" -> ID da categoria: ");
            int id = int.Parse(Console.ReadLine());
            Categoria categoria = categorias.Find(c => c.Id == id);

            if (categoria == null)
            {
                Console.WriteLine(" 🤷‍♂️ Categoria não encontrada! 🗺️");
                return;
            }

            categorias.Remove(categoria);

            Console.WriteLine(" 🧾 Categoria removida com sucesso! 🗑️ ");
        }
    }
}