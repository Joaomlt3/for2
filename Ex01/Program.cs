double soma = 0;
double media;
int defeituosas = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite o diametro da peça" + i + "(mm):");
    double diametro = Convert.ToDouble(Console.ReadLine());

    soma += diametro;

    if (diametro < 14.8 || diametro > 15.2)
    {
        defeituosas++;
    }
}

media = soma / 10;

Console.WriteLine("\nMedia dos diametros:" + media + "mm");
Console.WriteLine("Quantidade de peças fora do padrao:" +
defeituosas);
