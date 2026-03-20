using static System.Console;
// Crie uma classe chamada Funcionario
using System;
namespace Funcionário
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie um objeto da classe Funcionario e solicite ao usuário que insira os dados do funcionário
            Funcionario funcionario = new Funcionario();
            Write("Digite o nome do funcionário: ");
            funcionario.Nome = ReadLine();
            Write("Digite o salário bruto do funcionário: ");
            funcionario.SalarioBruto = double.Parse(ReadLine());
            Write("Digite o imposto do funcionário: ");
            funcionario.Imposto = double.Parse(ReadLine());
            // Exiba os dados do funcionário, nome e salário líquido
            WriteLine("\nDados do Funcionário:");
            funcionario.ExibirDados();
            // Solicite ao usuário que insira a porcentagem de aumento salarial e aplique o aumento
            Write("\nDigite a porcentagem de aumento salarial: ");
            double porcentagemAumento = double.Parse(ReadLine());
            funcionario.AumentarSalario(porcentagemAumento);
            // Exiba novamente os dados do funcionário, nome e salário líquido atualizado
            WriteLine("\nDados do Funcionário após aumento:");
            funcionario.ExibirDados();
        }
    }
}