using static System.Console;
using static System.ConsoleColor;
Title = "Calculadora 01";

//declaração de variáveis
double raio, circunferencia, volume;
const double PI = 3.14;

//entrada de dados
WriteLine("Entre com o valor do raio da circunferencia: ");
ForegroundColor = Red;
raio = double.Parse(ReadLine());
ResetColor();

//Saída de dados
WriteLine($"Circunferência: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI}");

//Cálculo da circunferência
double Circunferencia(double raio)
{
    return 2 * PI * raio;
}

double Volume(double raio)
{
    return (4 / 3) * PI * raio;

}
