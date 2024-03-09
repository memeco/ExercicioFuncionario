using System;
using System.Globalization;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioLiquido = funcionario.CalcularSalarioLiquido();

            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + funcionario.Nome + ", R$ " + salarioLiquido.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(porcentagem);

            salarioLiquido = funcionario.CalcularSalarioLiquido();

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario.Nome + ", R$ " + salarioLiquido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}