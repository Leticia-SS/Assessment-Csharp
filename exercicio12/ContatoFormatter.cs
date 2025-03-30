using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal abstract class ContatoFormatter
    {
        public virtual void ExibirContatods(List<Contato> contatos)
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato encontrado.");
                return;
            }
        }
    }
}
