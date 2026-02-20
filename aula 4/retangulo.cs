using static System.Console;
//declaração de variaveis
double Base, altura, area, perimetro,diagonal;
//Processamento de dados 
Write("Digite a base do retengulo: ");
Base = double.Parse(ReadLine());
Write("Digite a altura do retengulo: ");
altura = double.Parse(ReadLine());
area = Base * altura;
perimetro = 2 * (Base + altura);
diagonal = Math.Sqrt(Math.Pow(Base,2) + Math.Pow(altura,2));
//saida de dados
WriteLine($"A area do retangulo é de {area}, o perimetro é de {perimetro} e a diagonal é de {diagonal}");
