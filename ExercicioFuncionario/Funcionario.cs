using System;

public class Funcionario
{
    private string nome;
    private double salarioBruto;
    private double imposto;

    public Funcionario() // Construtor sem parâmetros
    {
        // Perguntar o nome do funcionário
        Console.WriteLine("Digite o nome do funcionário:");
        nome = Console.ReadLine();

        // Perguntar o salário bruto do funcionário
        Console.WriteLine("Digite o salário bruto do funcionário:");
        salarioBruto = double.Parse(Console.ReadLine());

        // Perguntar a porcentagem de imposto do funcionário
        Console.WriteLine("Digite a porcentagem de imposto do funcionário:");
        imposto = double.Parse(Console.ReadLine());
    }

    public string GetNome()
    {
        return nome;
    }

    public double GetSalarioBruto()
    {
        return salarioBruto;
    }

    public double CalcularSalarioLiquido()
    {
        return salarioBruto - (salarioBruto * imposto);
    }

    public void AumentarSalario(double aumento)
    {
        salarioBruto *= (1 + aumento / 100);
    }

    public override string ToString()
    {
        return $"Nome: {nome}\nSalário Bruto: R${salarioBruto:F2}\nSalário Líquido: R${CalcularSalarioLiquido():F2}";
    }
}
