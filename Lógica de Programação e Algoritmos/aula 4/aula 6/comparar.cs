using static System.Console;
int valor1, valor2, valor3;
Write("Digite o primeiro valor: ");
valor1 = int.Parse(ReadLine());
Write("Digite o segundo valor: ");
valor2 = int.Parse(ReadLine());
Write("Digite o terceiro valor: ");
valor3 = int.Parse(ReadLine());
Write($"Valores digitados: {valor1}, {valor2}, {valor3}");
Write("O primeiro valor é igual ao terceiro valor? ");
WriteLine(valor1 == valor3);
Write("O segundo valor é diferente do primeiro valor? ");
WriteLine(valor2 != valor1);
Write("O segundo valor é maior que o terceiro valor? ");
WriteLine(valor2 > valor3);
Write("O primeiro valor é menor ou igual que teceiro valor? ");
WriteLine(valor1 <= valor3);










