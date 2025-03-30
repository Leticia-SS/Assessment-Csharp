using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatods(List<Contato> contatos)
        {
            base.ExibirContatods(contatos);

            Console.WriteLine("\n## Lista de Contatos\n");

            foreach (var contato in contatos)
            {
                Console.WriteLine($"- **Nome:** {contato._Nome}\n");
                Console.WriteLine($"- 📞 Telefone: {contato._Telefone}\n");
                Console.WriteLine($"- 📧 Email: {contato._Email}\n");
            }
        }
    }
}
