using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    internal class CadastroArquivo
    {
        private string _Arquivo; // Atributo do caminho do arquivo

        // Construtor com parâmetros
        public CadastroArquivo(string arquivo)
        {
            _Arquivo = arquivo;
        }

        // Método para adicionar contato no arquivo
        public void AdicionarContato(Contato contato)
        {
            string[] diretorios = Directory.GetDirectories(_Arquivo);
        }
    }
}
