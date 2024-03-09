using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura dos dados do funcionário
        Console.WriteLine("Digite o nome do funcionário:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o salário bruto do funcionário:");
        double salarioBruto = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a porcentagem de imposto do funcionário:");
        double imposto = double.Parse(Console.ReadLine());

        // Cálculo do salário líquido
        double salarioLiquido = salarioBruto * (1 - imposto);

        // Exibição dos dados do funcionário
        Console.WriteLine("\nDados do Funcionário:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário Bruto: R${salarioBruto:F2}");
        Console.WriteLine($"Salário Líquido: R${salarioLiquido:F2}");

        // Aumento do salário do funcionário
        Console.WriteLine("\nDigite a porcentagem de aumento do salário:");
        double aumento = double.Parse(Console.ReadLine());

        salarioBruto += salarioBruto * (aumento / 100);

        // Cálculo do novo salário líquido
        salarioLiquido = salarioBruto * (1 - imposto / 100);

        // Exibição dos dados atualizados do funcionário
        Console.WriteLine("\nDados Atualizados do Funcionário:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário Bruto: R${salarioBruto:F2}");
        Console.WriteLine($"Salário Líquido: R${salarioLiquido:F2}");
    }
}
