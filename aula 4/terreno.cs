using static System.Console;
//declaração de variaveis
double largura, comprimento, valor,area, preco;
//entrada de dados
Write("Digite a largura do terreno: ");
largura = double.Parse(ReadLine());
WriteLine("Digite comprimento do terreno: ");
comprimento = double.Parse(ReadLine());
Write("Digite o valor do m² do terreno: ");
valor = double.Parse(ReadLine());
//processamento de dados
area = largura * comprimento;
preco = area * valor;
//saida de dados
WriteLine($"A area do terreno é de {area} e o preço do terreno é de R$ {preco}");

 