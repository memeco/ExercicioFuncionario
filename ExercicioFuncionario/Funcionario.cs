using System.Globalization;

namespace ExercicioFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double CalcularSalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
    }
}
