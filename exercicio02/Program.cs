class Program 
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase");
        string frase = Console.ReadLine();

        string[] arrayFrase = frase.Split(' ');


        for (int n= 0; n < arrayFrase.Length; n++)
        {
            string novaPalavra = "";
            for (int i = 0; i < arrayFrase[n].Length; i++)
            {
                string palavra = arrayFrase[n];
                char letra = (char)(palavra[i] + 2);
                novaPalavra += letra;
            }
            Console.WriteLine(novaPalavra);

        }

        Console.WriteLine(arrayFrase[0]);
        Console.WriteLine(arrayFrase[1]);

    }
}