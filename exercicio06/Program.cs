using exercicio06;

class Program
{
    public static void Main(string[] args)
    {
        // Criando os objetos
        Aluno lara = new Aluno("Lara Saraiva", 15052020, "Engenharia de Pesca", 6.5);
        Aluno leticia = new Aluno("Leticia Saraiva", 09082000, "Engenharia de Software", 8.5);

        // Chamando o método ExibirDados
        lara.ExibirDados();
        leticia.ExibirDados();

        // Chamando o método VerificarAprovacao
        Console.WriteLine("Verificando aprovação de Lara Saraiva");
        lara.VerificarAprovacao();
        Console.WriteLine("\n");
        Console.WriteLine("Verificando aprovação de Leticia Saraiva");
        leticia.VerificarAprovacao();
    }
}