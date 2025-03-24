class Program 
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase");
        string frase = Console.ReadLine();

        string[] arrayFrase = frase.Split(' ');


        foreach (string palavra in arrayFrase)
        {
            Console.WriteLine(palavra);
            string novaPalavra = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                char letra = (char)(palavra[i] + 2);
                Console.Write(letra);
                novaPalavra += letra;
            }
            Console.WriteLine(novaPalavra);

        }

        Console.WriteLine(arrayFrase[0]);
        Console.WriteLine(arrayFrase[1]);

    }
}