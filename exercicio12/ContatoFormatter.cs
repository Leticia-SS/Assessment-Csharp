using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class ContatoFormatter
    {
        // Criando lista para adicionar os contatos na memoria
        private List<Contato> _Memoria;

        // Construtor
        public ContatoFormatter()
        {
            _Memoria = new List<Contato>();
        }

        // Adicionar contato na lista
        public void AdicionarContato(Contato contato)
        {
            _Memoria.Add(contato);
        }

        // Mostrar a lista
        public List<Contato> ExibirContatos()
        {
            return _Memoria;
        }
    }
}
