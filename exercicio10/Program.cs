class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //Iniciando numero aleatorio
            byte tentativas = 5;

            // Chamando biblioteca de numeros aleatorios
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 5);

            int numeroEscolhido = 0;

            // Loop para tentar acertar, irá rodar até as tentativas acabarem ou ele acertar
            while (tentativas > 0)
            {
                // Escolher um número para tentar
                Console.Write("==== Digite um número entre 1 e 50: ");
                numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                
                // Validar número escolhido para ser entre 1 e 50
                bool numeroValido = numeroEscolhido >= 1 && numeroEscolhido <= 50;

                // Se o número for válido ele checa se está correto ou não e imprime as mensagens
                if (numeroValido)
                {
                    if (numeroEscolhido == numeroAleatorio)
                    {
                        Console.WriteLine($"\nParabéns! Você acertou o número! Número sorteado = {numeroAleatorio}\n");
                        break;
                    }
                    else
                    {
                        tentativas--;
                        Console.WriteLine($"\nVocê errou! Restam {tentativas} tentativas.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nNúmero inválido!\n");
                }

            }
            // Se o jogo acabou por falta de tentativas ele mostra qual era o número
            if (tentativas == 0)
            {
                Console.WriteLine($"\n\nGAME OVER! O número correto era: {numeroAleatorio}");
            }

            Console.WriteLine("\n\nFim do jogo!\n");
            Console.ReadKey(); // Apenas para ler a mensagem antes de fechar

        // Capturando erro no código
        } catch (Exception ex)
        {
            Console.WriteLine("\nErro: " + ex.Message);
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}