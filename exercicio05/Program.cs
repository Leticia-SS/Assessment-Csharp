class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite a data atual (dd/mm/aaaa): ");
            DateTime dataAtual = Convert.ToDateTime(Console.ReadLine());

            DateTime dataFormatura = new DateTime(2027, 07, 31);
            DateTime dataReal = DateTime.Now;

            TimeSpan diferenca = dataFormatura - dataAtual; // Diferença total em dias
            int dias = dataFormatura.Day - dataAtual.Day; // Diferença em dias
            int meses = dataFormatura.Month - dataAtual.Month; // Diferença em meses
            int anos = dataFormatura.Year - dataAtual.Year; // Diferença em anos

            bool isValid = (dataAtual.Day == dataReal.Day && dataAtual.Month == dataReal.Month && dataAtual.Year == dataReal.Year);

            if (!isValid)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            if (diferenca.Days < 0)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
            }
            else
            {
                if (dias < 0)
                {
                    dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
                    meses--;
                }
                if (meses < 0)
                {
                    meses += 12;
                }

                if (anos == 0)
                {
                    Console.WriteLine($"\nFaltam {meses} meses e {dias} dias para a formatura");

                    if (meses < 6) { Console.WriteLine("A reta final chegou! Prepare-se para a formatura!"); }
                }
                else
                {
                    Console.WriteLine($"\nFaltam {anos} anos, {meses} meses e {dias} dias para a formatura");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}