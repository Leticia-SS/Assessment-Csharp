using System.ComponentModel.Design;
using exercicio09;

class Program
{
    public static void Main(string[] args)
    {
        // Criando o objeto do estoque 
        short tamanhoEstoque = 0;
        Produto[] estoque = new Produto[5];

        // Chamando o Menu de opções
        Menu();

        do 
        {
            switch (opcao) 
            {
                case 1:
                    // Colocando nome do produto
                    Console.WriteLine("Digite o nome do produto:");
                    string nome = Console.ReadLine();

                    // Colocando a quantidade do produto
                    Console.WriteLine("Digite a quantidade em estoque:");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    // Colocando o preço 
                    Console.WriteLine("Digite o preço do produto:");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    // Se o limite do estoque for atingido ele retorna a mensagem e da break no loop
                    if (tamanhoEstoque == 5)
                    {
                        Console.WriteLine("Estoque cheio!");
                        break;
                    }

                    // Adicionando o produto no estoque
                    estoque[tamanhoEstoque] = new Produto(nome, quantidade, preco);

                    // Adiciona 1 ao tamanho do estoque, e com isso quando chegar a 5 ele vai brecar no if em cima
                    tamanhoEstoque++;
                    
                    break;
                case 2:
                    Console.WriteLine("Estoque atual:");
                    foreach (Produto produto in estoque)
                    {
                        if (produto != null)
                        {
                            Console.WriteLine(produto.MostrarProdutod());
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Fechando Estoque! . . .");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Escolha uma opção válida . . .");
                    break;

            }
            
        } while (opcao != 3);
    }

    public static byte Menu() 
    {
        Console.WriteLine("==========MENU==========");
        Console.WriteLine("Escolha uma das opções:\n\n1 - Inserir Produto\n2 - Listar Produtos\n3 - Sair\n");
        Console.WriteLine($"Cadastro Máximo de: 5\n");
        byte opcao = Convert.ToByte(Console.ReadLine());
        return opcao;

    }


}