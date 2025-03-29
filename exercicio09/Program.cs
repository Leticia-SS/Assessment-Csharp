using System.ComponentModel.Design;
using exercicio09;

class Program
{
    public static void Main(string[] args)
    {
        // Pegando erro de digitação do código todo
        try { 
        // Criando o objeto do estoque 
        short tamanhoEstoque = 0;
        Produto[] estoque = new Produto[5];

        // Controle de erro
        try
        {
            // Se o arquiuvo não existir o sistema cria outro
            if (!File.Exists("Estoque.txt"))
            {
                File.Create("Estoque.txt").Close(); // Se usar o metodo create e não fechar o arquivo ele não vai permitir escrever 
            } 
        } catch (Exception ex) 
        {
            Console.WriteLine("Erro ao criar o arquivo de estoque. Erro: " + ex.Message);
        }

        // Chamando o Menu de opções e iniciando na variavel opcao oq o usuário escolher
        short opcao = Menu();

        do 
        {
            switch (opcao) 
            {
                case 1:
                    // Vari[avel de verificação se o txt ta cheio
                    int itensEstoque = File.Exists("Estoque.txt") ? File.ReadAllLines("Estoque.txt").Length : 0;

                    // Se o limite do estoque for atingido ele retorna a mensagem e da break no loop
                    if (tamanhoEstoque >= 5 || itensEstoque >=5)
                    {
                        Console.WriteLine("Estoque cheio! . . .\n");
                        Console.ReadKey(); //Somente para dar um espaço para ler a msg antes de aparecer o menu
                        opcao = Menu();
                        break;
                    }

                    // Colocando nome do produto
                    Console.WriteLine("\nDigite o nome do produto:");
                    string nome = Console.ReadLine();

                    // Colocando a quantidade do produto
                    Console.WriteLine("Digite a quantidade em estoque:");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    // Colocando o preço 
                    Console.WriteLine("Digite o preço do produto:");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Produto Adicionado . . .\n");

                    // Adicionando o produto no estoque
                    estoque[tamanhoEstoque] = new Produto(nome, quantidade, preco);

                    // Controle de erro
                    try
                    {
                        // Adicionar produto no txt
                        using (StreamWriter salvarTxt = File.AppendText("Estoque.txt"))
                        {
                            // Adicionei alem do nome e preco a quantidade de estoque, mesmo não estando no exemplo da questão
                            salvarTxt.WriteLine($"{estoque[tamanhoEstoque]._Nome}, {estoque[tamanhoEstoque]._Preco}, {estoque[tamanhoEstoque]._QuantidadeEstoque}");
                        }
                    } catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao salvar item em estoque. Erro:" + ex.Message);
                    }

                    // Adiciona 1 ao tamanho do estoque, e com isso quando chegar a 5 ele vai brecar no if em cima
                    tamanhoEstoque++;

                    Console.ReadKey(); //Somente para dar um espaço para ler a msg antes de aparecer o menu

                    //Chamando o menu de novo para selecionar uma nvoa opcao
                    opcao = Menu();

                    break;
                case 2:
                    // Código da Parte A do exercício 9
                    //// Printando todos os produtos em estoque
                    //foreach (Produto produto in estoque)
                    //{
                    //    // Não mostra produtos que sejam nullos, ou deja, que ainda não existem no array 
                    //    if (produto != null)
                    //    {
                    //        produto.MostrarProdutod();
                    //    }
                    //}

                    // Controle de erro
                    try
                    {
                        // Verificando se ta vazio
                        if (new FileInfo("Estoque.txt").Length == 0)
                        {
                            Console.WriteLine("\nNenhum Produto Cadastrado");
                            return;
                        }
                        // Printando direto do arquivo txt
                        using (StreamReader lerTxt = new StreamReader("Estoque.txt"))
                        {
                            string linha;
                            while ((linha = lerTxt.ReadLine()) != null)
                            {
                                Console.WriteLine(linha);
                            }
                        }
                    } catch (Exception ex)
                    {
                            Console.WriteLine("Erro ao ler item em estoque. Erro:" + ex.Message);
                        }

                        Console.ReadKey(); //Somente para dar um espaço para ler a msg antes de aparecer o menu
                    Console.WriteLine("\n"); // Pular uma linha por estética

                    // Chamando o menu de novo para selecionar uma nova opcao
                    opcao = Menu();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Escolha uma opção válida . . .\n");
                    Console.ReadKey(); //Somente para dar um espaço para ler a msg antes de aparecer o menu

                    // Chamando o menu de novo para selecionar uma nova opcao
                    opcao = Menu();
                    break;
            }
            
        } while (opcao != 3);

        Console.WriteLine("Fechando Estoque! . . .");
        Console.ReadKey();
    } catch (Exception ex)
    {
        Console.WriteLine("Errro: " + ex.Message);
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

    // Método do Menu
    public static byte Menu() 
    {
        Console.Clear(); // Limpando a tela
        Console.WriteLine("==========MENU==========");
        Console.WriteLine("Escolha uma das opções:\n\n1 - Inserir Produto\n2 - Listar Produtos\n3 - Sair\n");
        Console.WriteLine($"Cadastro Máximo de: 5");
        return Convert.ToByte(Console.ReadLine());
    }
}