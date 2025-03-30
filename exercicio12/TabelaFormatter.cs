using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatods(List<Contato> contatos)
        {
            base.ExibirContatods(contatos);
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("\n| Nome | Telefone | Email |\n");
            Console.WriteLine("\n-----------------------------------------\n\n");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"| {contato._Nome} | {contato._Telefone} | {contato._Email}\n");
            }
            Console.WriteLine("\n-----------------------------------------\n");

        }
    }
}
