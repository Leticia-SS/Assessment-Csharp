using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    internal class CadastroArquivo
    {
        public string _Arquivo;
        public List<Contato> _Contatos = new List<Contato>();

        public CadastroArquivo(string arquivo)
        {
            _Arquivo = arquivo;
            _Contatos = new List<Contato>();
            SalvarContatos();
        }
        public void AdicionarContato(Contato contato)
        {
            try
            {
                using (StreamWriter ler = new StreamWriter(_Arquivo, true))
                {
                    ler.WriteLine(contato.ToString());
                }
                _Contatos.Add(contato);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir no arquivo: " + e.Message);
            }
        }

        // Salvar contatos em Lista
        public void SalvarContatos()
        {
            try
            {
                _Contatos.Clear(); // Limpar a lista de contatos para não duplicar
                if (new FileInfo(_Arquivo).Length == 0)
                {
                    Console.WriteLine("\nNenhum Contato Cadastrado");
                    return;
                }

                // Ler o arquivo
                using (StreamReader ler = new StreamReader(_Arquivo))
                {
                    // Pegar cada linha do conteudo do arquivo
                    string linha;
                    while ((linha = ler.ReadLine()) != null) // Loop enquanto tiver linhas
                    {
                        // Verificar e separar Nome, Telefone e Email
                        string[] newLinha = linha.Split('|');
                        if ((linha.Split('|')).Length == 3)
                        {
                            // Adicionar o contato na lista
                            _Contatos.Add(new Contato(newLinha[0], newLinha[1], newLinha[2]));
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
