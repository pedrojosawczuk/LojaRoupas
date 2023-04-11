using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoVendasLojaRoupas
{
    class Categoria
    {
        public string Nome { get; set; }
        public Categoria(string nome)
        {
            Nome = nome;
        }
    }
    public class Loja
    {
        public List<Categoria> CategoriasDisponiveis { get; set; }
        public Loja()
        {
            CategoriasDisponiveis = new List<Categoria>();
            CategoriasDisponiveis.Add(new Categoria("Camisas"));
            CategoriasDisponiveis.Add(new Categoria("Calças"));
            CategoriasDisponiveis.Add(new Categoria("Sapatos"));
        }
    }
}
