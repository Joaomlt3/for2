int alunosMenores30 = 0;
int idade;
double porcentagem;

for (int i = 1; i <= 12; i++)
{
    Console.Write("Digite a idade do aluno " + i + ": ");
    idade = Convert.ToInt32(Console.ReadLine());

   
    if (idade < 30)
    {
        alunosMenores30++;
    }
}


porcentagem = (alunosMenores30 / 12.0) * 100;


Console.WriteLine("\nPercentual de alunos com menos de 30 anos: "
                  + porcentagem.ToString("F2") + "%");