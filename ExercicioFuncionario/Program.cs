using System;
using System.Globalization;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioBruto, imposto, salarioLiquido;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioLiquido = salarioBruto - imposto;

            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + nome + ", R$ " + salarioLiquido.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.0);
            salarioLiquido = salarioBruto - imposto;

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + nome + ", R$ " + salarioLiquido.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}