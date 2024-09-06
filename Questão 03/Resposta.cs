using System;

class Program
{
    static void Main()
    {
        
        double[] faturamento = { 200.0, 300.0, 0.0, 150.0, 0.0, 400.0, 0.0, 250.0, 0.0, 500.0, 0.0, 100.0 };

        // Calculando o menor e o maior valor de faturamento
        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0.0;
        int diasComFaturamento = 0;

        // Primeiro loop para calcular menor, maior e soma do faturamento
        foreach (double valor in faturamento)
        {
            if (valor > 0)
            {
                if (valor < menorFaturamento)
                {
                    menorFaturamento = valor;
                }
                if (valor > maiorFaturamento)
                {
                    maiorFaturamento = valor;
                }
                somaFaturamento += valor;
                diasComFaturamento++;
            }
        }

        // Calculando a média anual
        double mediaAnual = somaFaturamento / diasComFaturamento;

        // Calculando o número de dias com faturamento superior à média
        int diasAcimaMedia = 0;
        foreach (double valor in faturamento)
        {
            if (valor > mediaAnual)
            {
                diasAcimaMedia++;
            }
        }

        // Exibindo os resultados
        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaMedia}");
    }
}
