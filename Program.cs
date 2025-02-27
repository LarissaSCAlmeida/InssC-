using System;
using DS.Model;  // Importando a classe INSS

class Program
{
    static void Main()
    {
        Console.Write("Digite o salário: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        double desconto = INSS.CalcularDesconto(salario);

        Console.WriteLine($"O desconto do INSS é: R$ {desconto:F2}");
    }
}
