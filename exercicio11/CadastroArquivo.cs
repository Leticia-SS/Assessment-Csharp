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
            try
            {
                using (StreamWriter ler = new StreamWriter(_Arquivo, true))
                {
                    ler.WriteLine(contato.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir no arquivo: " + e.Message);
            }
        }

        // Método para mostrar os contatos do arquivo
        public void MostrarContatos()
        {
            try
            {
                if (new FileInfo(_Arquivo).Length == 0)
                {
                    Console.WriteLine("\nNenhum Produto Cadastrado");
                }
                else
                {
                    using (StreamReader ler = new StreamReader(_Arquivo))
                    {
                        string linha;
                        while ((linha = ler.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao ler do arquivo: " + e.Message);
            }
        }
    }
}
