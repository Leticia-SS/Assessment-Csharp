using exercicio11;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Verificando se arquivo existe
            if (!File.Exists("Contatos.txt"))
            {
                File.Create("Contatos.txt").Close(); 
            }

            // Criando o cadadstro de arquivos para salvar os contatos
            CadastroArquivo arquivo = new CadastroArquivo("Contatos.txt");

            byte opcao = Menu();

            while (opcao != 3)
            {
                // Iniciando o menu
                switch (opcao)
                {
                    case 1:
                        arquivo.AdicionarContato(AddContato());
                        Console.WriteLine("\nContato cadastrado com sucesso!");
                        Console.ReadKey();
                        opcao = Menu();
                        break;
                    case 2:
                        Console.WriteLine("\nContatos cadastrados:");
                        Console.WriteLine("\n");
                        arquivo.MostrarContatos();
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

    // Método par ao Menu
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

    // Método para adicionar contato e retornar ele
    public static Contato AddContato()
    {
        // Pedindo os dados ao usuário
        Console.Write("\nNome: ");
        string nome = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        // Adicionando o contato
        Contato contato = new Contato(nome, telefone, email);
        return contato;
    }

}