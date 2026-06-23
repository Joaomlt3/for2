double totalReembolsado = 0.0;
double totalDoBolso = 0.0;
double gasto;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Digite o gasto com refeições do consultor " + i + ": R$ ");
    gasto = double.Parse(Console.ReadLine());

    if (gasto <= 150.0)
    {
        totalReembolsado += gasto;
    }
    else
    {
        totalReembolsado += 150.0;
        totalDoBolso += (gasto - 150.0);
    }
}

Console.WriteLine("Total reembolsado pela empresa: R$ " + totalReembolsado);
Console.WriteLine("Total pago do próprio bolso: R$ " + totalDoBolso);