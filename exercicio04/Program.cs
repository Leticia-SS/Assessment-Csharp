class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Input da sua data de aniversário
            Console.Write("Digite sua data de aniversário (dd/mm/aaaa): ");
            DateTime dataAnv = Convert.ToDateTime(Console.ReadLine());

            // Adicionando Data atual para comparação
            DateTime dataAtual = DateTime.Now;

            // Salvando a diferença em dias e meses pois não é possível calcular a diferença em anos
            int dias = dataAnv.Day - dataAtual.Day;
            int meses = dataAnv.Month - dataAtual.Month;
            TimeSpan diferenca = dataAnv - dataAtual;

            if (dataAnv.Day == dataAtual.Day && dataAnv.Month == dataAtual.Month)  // Caso o seu aniversário seja hoje
            {
                Console.WriteLine("\nFeliz Aniversário ! ! !");
            }
            else if (diferenca.Days < 7)  // Se a diferença for de menos de 7 dias
            {
                Console.WriteLine("\nQuase lá, faltam menos de 7 dias para seu aniversário ! ! !");
            }
            else  // Se a diferença for de mais de 7 dias
            {
                if (dias < 0)
                {
                    // Se o dia for negativo é porque o dia equivalente já passou ent tem que somar o total de dias do mÊs para a diferença em dias
                    dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month); // Pegar o total de dias do mês de acordo com o mês e ano
                    // Diminui o mês pois a diferenã em dias indica que não completou dias para o mês
                    meses--;
                }
                if (meses < 0)
                {
                    // Se o mês for negativo é porque o mês equivalente já passou ent tem que somar o total de meses do ano para a diferença em meses
                    meses += 12; // Adiciona 12 meses para a diferença em meses
                }

                Console.WriteLine($"\nFaltam {meses} meses e {dias} dias para seu aniversário ! ! !");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("\nErro: " + ex.Message);
        }
    }
}