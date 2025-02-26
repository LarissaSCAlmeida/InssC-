using System;
using ProjetoINSS.Services;

class Program
{
    static void Main()
    {
        Console.Write("Digite o seu salário bruto: R$ ");
        double salario = Convert.ToDouble(Console.ReadLine());
        double inss = INSSService.CalcularINSS(salario);
        Console.WriteLine($"O valor do INSS a ser pago é: R$ {inss:F2}");
    }
}
