string nomeProduto;
int quantidade;


for (int i = 1; i <= 8; i++)
{
    Console.WriteLine($"\nProduto {i}:");

    Console.Write("Nome do produto: ");
    nomeProduto = Console.ReadLine();

    Console.Write("Quantidade em estoque: ");
    quantidade = Convert.ToInt32(Console.ReadLine());

    
    if (quantidade < 5)
    {
        Console.WriteLine($"ATENÇÃO: O produto {nomeProduto} está com estoque crítico!");
    }
}

Console.WriteLine("\nVerificação de estoque concluída.");
