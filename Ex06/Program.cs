double somaKwh = 0;
double consumo, mediaConsumo;


for (int mes = 1; mes <= 6; mes++)
{
    Console.Write("Digite o consumo do mês " + mes + " (kWh): ");
    consumo = Convert.ToDouble(Console.ReadLine());

    somaKwh += consumo;
}


mediaConsumo = somaKwh / 6;


if (mediaConsumo > 300)
{
    Console.WriteLine("\nMédia de consumo: " + mediaConsumo.ToString("F2") + " kWh");
    Console.WriteLine("ALERTA: Alto Consumo!");
}
else
{
    Console.WriteLine("\nMédia de consumo: " + mediaConsumo.ToString("F2") + " kWh");
    Console.WriteLine("Consumo Normal.");
}
