using static System.Console;
using static System.ConsoleColor;
using static Circunferencia03.calculadora;

Title = "Calculadora 03";
//Entrada de dados
Write("Digite o raio da circunferência: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//Saída de dados
WriteLine($"Circunferência: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
Write($"PI: {PI}");


