using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class Contato
    {
        public string _Nome { get; set; }
        public string _Telefone { get; set; }
        public string _Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            _Nome = nome;
            _Telefone = telefone;
            _Email = email;
        }
        public override string ToString()
        {
            return $"{_Nome}|{_Telefone}|{_Email}";
        }
    }
}
