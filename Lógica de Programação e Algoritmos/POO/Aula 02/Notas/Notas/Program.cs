using static System.Console;
//ler o nome do aluno e as notas de 3 provas, calcular a média e mostrar se o aluno foi aprovado ou reprovado, considerando a média mínima para aprovação 60
using System;
class Program
{
    static void Main()
    {
        Write("Digite o nome do aluno: ");
        string nome = ReadLine();
        double[] notas = new double[3];
        for (int i = 0; i < notas.Length; i++)
        {
            Write($"Digite a nota da prova {i + 1}: ");
            notas[i] = Convert.ToDouble(ReadLine());
        }
        double media = CalcularMedia(notas);
        WriteLine($"A média do aluno {nome} é: {media:F2}");
        if (media >= 60)
        {
            WriteLine("O aluno foi aprovado.");
        }
        else
        {
            WriteLine("O aluno foi reprovado.");
        }
    }
    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }
        return soma / notas.Length;
    }
}