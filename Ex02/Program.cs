double saldo;

Console.Write("Digite o valor do aporte inicial: R$ ");
saldo = double.Parse(Console.ReadLine());

for (int mes = 1; mes <= 12; mes++)
{
    
    saldo = saldo * 1.006;

   
    Console.WriteLine($"Mês {mes}: Saldo = R$ {saldo:F2}");
}
