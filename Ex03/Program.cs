double temperatura, maiorTemperatura, menorTemperatura;


Console.Write("Digite a temperatura da 1ª hora: ");
temperatura = double.Parse(Console.ReadLine());


maiorTemperatura = temperatura;
menorTemperatura = temperatura;


for (int hora = 2; hora <= 8; hora++)
{
    Console.Write($"Digite a temperatura da {hora}ª hora: ");
    temperatura = double.Parse(Console.ReadLine());

    
    if (temperatura > maiorTemperatura)
    {
        maiorTemperatura = temperatura;
    }

    
    if (temperatura < menorTemperatura)
    {
        menorTemperatura = temperatura;
    }
}


Console.WriteLine("\nResultado do monitoramento:");
Console.WriteLine($"Maior temperatura registrada: {maiorTemperatura} °C");
Console.WriteLine($"Menor temperatura registrada: {menorTemperatura} °C");

