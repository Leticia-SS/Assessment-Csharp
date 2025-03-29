using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class CadastroMemoria
    {
        // Criando lista para adicionar os contatos na memoria
        private List<Contato> _Memoria;

        // Construtor
        public CadastroMemoria()
        {
            _Memoria = new List<Contato>();
        }

        // Adicionar contato na lista
        public void AdicionarContato(Contato contato)
        {
            _Memoria.Add(contato);
        }

        //public List<Contato> ListarContatos()
        //{
        //    return _memoria;
        //}

        // Mostrar a lista
        public void MostrarContatos()
        {
            foreach (var contato in _Memoria)
            {
                Console.WriteLine(contato);
            }
        }
    }
}
