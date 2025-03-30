using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatods(List<Contato> contatos)
        {
            base.ExibirContatods(contatos);

            foreach (var contato in contatos)
            {
                Console.WriteLine($"\nNome: {contato._Nome} | Telefone: {contato._Telefone} | Email: {contato._Email}");

            }

        }
    }
}
