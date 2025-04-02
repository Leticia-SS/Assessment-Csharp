using exercicio12;

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Para aceitar emoji == Não funcionou
        try
        {
            if (!File.Exists("Contatos.txt"))
            {
                File.Create("Contatos.txt").Close();
            }

            CadastroArquivo arquivo = new CadastroArquivo("Contatos.txt");
            arquivo.SalvarContatos(); // Garante a lista preenchida quando iniciar o código
            byte opcao = Menu();

            while (opcao != 3)
            {
                switch (opcao)
                {
                    case 1:
                        arquivo.AdicionarContato(AddContato());
                        Console.WriteLine("\nContato cadastrado com sucesso!");
                        Console.ReadKey();
                        opcao = Menu();
                        break;
                    case 2:
                        if (arquivo._Contatos.Count == 0)
                        {
                            Console.WriteLine("\nNenhum contato cadastrado");
                            Console.ReadKey();
                            opcao = Menu();
                            break;
                        }
                        byte formatter = MenuFormatter();
                        bool valid = formatter >= 1 && formatter <= 3;
                        if (!valid)
                        {
                            Console.WriteLine("\nOpção inválida");
                            Console.ReadKey();
                            opcao = Menu();
                            break;
                        }
                        Console.WriteLine("\nContatos cadastrados:");
                        ContatoFormatter formatoEscolhido; // Iniciando variável para escolher o formato
                        
                        // Switch para escolher a classe filha para chamar
                        switch(formatter)
                        {
                            case 1:
                                formatoEscolhido = new MarkdownFormatter();
                                break;
                            case 2:
                                formatoEscolhido = new TabelaFormatter();
                                break;
                            default:
                                formatoEscolhido = new RawTextFormatter();
                                break;
                        }
                        formatoEscolhido.ExibirContatods(arquivo._Contatos);
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        opcao = Menu();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        Console.ReadKey();
                        opcao = Menu();
                        break;
                }
            }
            Console.WriteLine("\nEncerrando o programa . . .");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nErro: " + ex.Message);
            Console.WriteLine("\nDigite qualquer tecla para sair . . .");
            Console.ReadKey();
        }
    }
    public static byte Menu()
    {
        Console.Clear();
        Console.WriteLine("=========Menu=========");
        Console.WriteLine("1 - Adicionar novo contato");
        Console.WriteLine("2 - Listar contatos cadastrados");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
        return Convert.ToByte(Console.ReadLine());
    }
    public static Contato AddContato()
    {
        Console.Write("\nNome: ");
        string nome = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Contato contato = new Contato(nome, telefone, email);
        return contato;
    }
    // Escolher formato para printar dados
    public static byte MenuFormatter()
    {
        Console.WriteLine("\nEscolha o formato para printar os dados:");
        Console.WriteLine("1 - Markdown");
        Console.WriteLine("2 - Tabela");
        Console.WriteLine("3 - RawText\n");
        Console.Write("Escolha uma opção: ");
        return Convert.ToByte(Console.ReadLine());
    }
}
