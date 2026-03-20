using System;

namespace Funcionário
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        // método para calcular o salário líquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        // método para aumentar o salário bruto em uma porcentagem
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

        // método para exibir os dados do funcionário, nome e salário líquido
    public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário Líquido: {SalarioLiquido():F2}");
        }
    }
}
