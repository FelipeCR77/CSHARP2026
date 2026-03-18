using static System.Console;
using static System.Linq.Enumerable;
//declaração de variaveis
int n;
//entrada de dados
Write("Quantos numero voce deseja digitar? ");
n = int.Parse(ReadLine());
if (n<0)
{
    WriteLine("Valor invalido,digite somente números positivos");
}
else if (n > 10)
{
    WriteLine("Máximo de valores para digitar igual a 10");
    WriteLine("tente novamente");
}
else
{
    //declaração de vetores
    int[] numeros = new int[n];
    for (int i = 0; i<numeros.Length; i++)
    {
        Write($"Digite {i+1}º numero: ");
        numeros[i] = int.Parse(ReadLine());

    }
    WriteLine("NÚMEROS NEGATIVOS:");
foreach (int item in Range(0, numeros.Length))
{
    if (item < 0)
    {
        
        WriteLine(numeros[item]);
        WriteLine(item);
    }
}
}
