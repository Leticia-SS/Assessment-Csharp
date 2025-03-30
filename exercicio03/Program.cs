class Program
{
    public static void Main(string[] args)
    {
        try { 
            Console.WriteLine("Digite o primeiro número: "); //Input primeiro npumero
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: "); // Input segundo número
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Escolha a operação: "); // Input operação
            Console.WriteLine("(1) Soma\n(2) Subtação\n(3) Multiplicação\n(4) Divisão\n(5) Sair");

            int operacao = Convert.ToInt32(Console.ReadLine()); 

            bool isValid = operacao <= 5 && operacao >= 1; // Verifica se a operação é válida

            if (isValid) // Se a operação não for válida
            {
                do { // Loop para executar quantas operações quiser
                    switch (operacao) // Switch para escolher a operação
                    {
                        case 1: // Soma
                            Console.WriteLine($"O resultado da soma é: {num1 + num2}");
                            Console.WriteLine("Escolha outra operação ou digite 5 para sair: ");
                            operacao = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2: // Subtração
                            Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
                            Console.WriteLine("Escolha outra operação ou digite 5 para sair: ");
                            operacao = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3: // Multiplicação
                            Console.WriteLine($"O resultado da multiplicação é: {num1 * num2}");
                            Console.WriteLine("Escolha outra operação ou digite 5 para sair: ");
                            operacao = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 4: // Divisão
                            if (num2 == 0) // Verifica se o segundo número é 0
                            {
                                Console.WriteLine("Não é possível dividir por 0");
                            }
                            else
                            {
                                Console.WriteLine($"O resultado da divisão é: {num1 / num2}");
                            }
                            Console.WriteLine("Escolha outra operação ou digite 5 para sair: ");
                            operacao = Convert.ToInt32(Console.ReadLine());
                            break;
                 
                    }
                } while (operacao != 5); // Se a operação for 5, o programa encerra
                Console.WriteLine("Fechando Programa ...");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Operação inválida"); // Erro se nenhuma das operações corretas for escolhida
                return;
            }

        }
        catch (Exception ex) 
        {
            Console.WriteLine("Erro: " + ex.Message); // Erro caso o usuário digite um valor inválido
        }

    }
}