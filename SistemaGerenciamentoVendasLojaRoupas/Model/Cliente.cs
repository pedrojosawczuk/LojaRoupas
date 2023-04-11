using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVendasLojaRoupas
{
	public class Cliente
	{
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string sobrenome, string endereco, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            Telefone = telefone;
        }

    }


}