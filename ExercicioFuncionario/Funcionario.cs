using System;

public class Funcionario
{
    private string _nome;
    private double _salarioBruto;
    private double _imposto;

    public Funcionario() // Construtor sem parâmetros
    {
        // Perguntar o nome do funcionário
        Console.WriteLine("Digite o nome do funcionário:");
        _nome = Console.ReadLine();

        // Perguntar o salário bruto do funcionário
        Console.WriteLine("Digite o salário bruto do funcionário:");
        _salarioBruto = double.Parse(Console.ReadLine());

        // Perguntar a porcentagem de imposto do funcionário
        Console.WriteLine("Digite a porcentagem de imposto do funcionário:");
        _imposto = double.Parse(Console.ReadLine());
    }

    public string GetNome()
    {
        return _nome;
    }

    public double GetSalarioBruto()
    {
        return _salarioBruto;
    }

    public double CalcularSalarioLiquido()
    {
        return _salarioBruto - (_salarioBruto * _imposto);
    }

    public void AumentarSalario(double aumento)
    {
        _salarioBruto *= (1 + aumento / 100);
    }

    public override string ToString()
    {
        return $"Nome: {_nome}\nSalário Bruto: R${_salarioBruto:F2}\nSalário Líquido: R${CalcularSalarioLiquido():F2}";
    }
}
