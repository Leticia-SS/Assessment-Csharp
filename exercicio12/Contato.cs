using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Contato
    {
        private string _Nome { get; set; }
        private string _Telefone { get; set; }
        private string _Email { get; set; }

        // Construtor com parâmetros
        public Contato(string nome, string telefone, string email)
        {
            _Nome = nome;
            _Telefone = telefone;
            _Email = email;
        }

        // Método sobrescrevendo o método ToString para mostrar os contatos
        public override string ToString()
        {
            return $"{_Nome} | {_Telefone} | {_Email}";
        }
    }
}
