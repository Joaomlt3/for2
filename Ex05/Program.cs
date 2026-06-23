int votosSim = 0, votosNao = 0, abstencoes = 0;
int voto;


for (int i = 1; i <= 15; i++)
{
    Console.WriteLine($"Vereador {i}:");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    Console.WriteLine("3 - Abstenção");
    Console.Write("Digite seu voto: ");
    voto = int.Parse(Console.ReadLine());

    if (voto == 1)
    {
        votosSim++;
    }
    else if (voto == 2)
    {
        votosNao++;
    }
    else if (voto == 3)
    {
        abstencoes++;
    }
    else
    {
        Console.WriteLine("Voto inválido!");
    }

    Console.WriteLine();
}


Console.WriteLine("Resultado da votação:");
Console.WriteLine($"Votos SIM: {votosSim}");
Console.WriteLine($"Votos NÃO: {votosNao}");
Console.WriteLine($"Abstenções: {abstencoes}");

if (votosSim >= 8)
{
    Console.WriteLine("Projeto APROVADO.");
}
else
{
    Console.WriteLine("Projeto REJEITADO.");
}