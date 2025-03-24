class Program 
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase");
        string frase = Console.ReadLine();

        string[] arrayFrase = frase.Split(' ');

        Console.WriteLine("");

        Console.Write("Frase antes: ");
        foreach(string palavra in arrayFrase)
        {
            Console.Write(palavra + " ");
        }

        Console.WriteLine("");

        Console.Write("Frase depois: ");
        for (int n= 0; n < arrayFrase.Length; n++)
        {
            string novaPalavra = "";
            for (int i = 0; i < arrayFrase[n].Length; i++)
            {
                string palavra = arrayFrase[n];
                char letra = (char)(palavra[i] + 2);
                novaPalavra += letra;
            }
            arrayFrase[n] = novaPalavra;
            Console.Write(novaPalavra + " ");

        }
        Console.WriteLine("");

    }
}