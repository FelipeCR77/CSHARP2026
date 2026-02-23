using static System.Console;
//declaração de variaveis
double a, b, c, areaQuadrado, areaTriangulo, areaTrapezio;
//entrada de dados
Write("Digite a medida A: ");
a = double.Parse(ReadLine());
Write("Digite a medida B: ");
b = double.Parse(ReadLine());
Write("Digite a medida C: ");
c = double.Parse(ReadLine());
//processamento de dados
areaQuadrado = a * a;
areaTriangulo = (a * b) / 2;
areaTrapezio = ((a + b) * c) / 2;
//saida de dados
WriteLine($"A area do quadrado = {areaQuadrado}");
WriteLine($"A area do triangulo = {areaTriangulo}");
WriteLine($"A area do trapezio = {areaTrapezio}");

