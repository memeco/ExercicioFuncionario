public class Funcionario
{
    private string nome;
    private double salarioBruto;
    private double imposto;

    public Funcionario(string nome, double salarioBruto, double imposto)
    {
        this.nome = nome;
        this.salarioBruto = salarioBruto;
        this.imposto = imposto;
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

    public void AumentarSalario(double porcentagem)
    {
        salarioBruto += salarioBruto * (porcentagem / 100);
    }

    public override string ToString()
    {
        return $"Nome: {nome}\nSalário Bruto: R${salarioBruto:F2}\nSalário Líquido: R${CalcularSalarioLiquido():F2}";
    }
}
