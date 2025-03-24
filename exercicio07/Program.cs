using exercicio07;

class Program
{
    public static void Main(string[] args)
    {
        // Criando objeto da conta bancaria
        ContaBancaria conta = new ContaBancaria("Hugo");

        conta.ExibirTitular(); // Exibindo tirular

        Console.WriteLine(conta.Depositar(500)); // Fazendo depósito
        conta.ExibirDados(); // Exibindo saldo

        Console.WriteLine(conta.Sacar(700)); // Fazendo saque
        conta.ExibirDados(); // Exibindo saldo

        Console.WriteLine(conta.Sacar(200)); // Fazendo saque
        conta.ExibirDados(); // Exibindo saldo


    }
}