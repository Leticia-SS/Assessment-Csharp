class Program 
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase");
        string frase = Console.ReadLine();

        // Criando um array com cada palavra da frase como item
        string[] arrayFrase = frase.Split(' ');

        Console.WriteLine(""); // Pulando uma linha

        // Printando a frase antes da soma de 2 letras em cada caracter
        Console.Write("Frase antes: ");
        foreach(string palavra in arrayFrase)
        {
            Console.Write(palavra + " ");
        }

        Console.WriteLine(""); // Pulando uma linha

        // Iterando cada palavra dentro do array
        Console.Write("Frase depois: ");
        for (int n= 0; n < arrayFrase.Length; n++)
        {
            // Criando uma variável para adicionar as letras modificadas formando uma palavra
            string novaPalavra = "";

            // Iterando cada palavra e modificando cada letra
            for (int i = 0; i < arrayFrase[n].Length; i++)
            {
                string palavra = arrayFrase[n];
                char letra = (char)(palavra[i] + 2);
                novaPalavra += letra;
            }

            // Salvando a palavra atual no array na posição da palavra antiga
            arrayFrase[n] = novaPalavra;
            // Printando a palavra modificada 
            Console.Write(novaPalavra + " ");

        }
        Console.WriteLine(""); // Pulando uma linha

    }
}