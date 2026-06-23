
int totalVendas;
double valorVenda, faturamentoTotal = 0, maiorVenda = 0;


Console.Write("Digite a quantidade de vendas do turno: ");
totalVendas = int.Parse(Console.ReadLine());


for (int i = 0; i < totalVendas; i++)
{
    Console.Write($"Digite o valor da {i + 1} venda: R$ ");
    valorVenda = double.Parse(Console.ReadLine());

    
    faturamentoTotal += valorVenda;

    
    if (valorVenda > maiorVenda)
    {
        maiorVenda = valorVenda;
    }
}


Console.WriteLine("Fechamento de Caixa");
Console.WriteLine($"Faturamento total: R$ {faturamentoTotal:F2}");
Console.WriteLine($"Maior venda do dia: R$ {maiorVenda:F2}");