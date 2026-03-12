//Exercicio de lista com a estrutura de repetição for
using static System.Console;

//declaração de variaveis
int n;
List<double> numeros = new List<double>();
// entrada de dados
Write("Quantos numeros deseja digitar? ");
n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    Write("Digite um numero: ");
    numeros.Add(double.Parse(ReadLine()));

}

for(int i = 0; i < n; i++)
{
    Write ("Valores =");
    Write($"{numeros[i]} ");
}
Write($"\nSoma= {numeros.Sum()}");
Write($"\nMédia= {numeros.Average()}");
