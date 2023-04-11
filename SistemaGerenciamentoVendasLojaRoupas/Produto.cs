using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoVendasLojaRoupas
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string Categoria { get; set; }

    }
    public Produto(string nome, string Descricao, string Preco, string Categoria)
    {
        Nome = nome
        Descricao = descricao;
        Preco = preco;
        Categoria = categoria;
    }
}

