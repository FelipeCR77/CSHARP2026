using static System.Console;
//ler a cotação do dólar em reais,informar o valor em reais e converter para dólares para o usuário, o usuario terá que pegar 6% de IOF sobre o valor em dólar

Title = "Conversor de Dólar";
//Entrada de dados
Write("Digite a cotação do dólar em reais: ");
double cotacaoDolar = double.Parse(ReadLine());
Write("Digite o valor em reais: ");
double valorReais = double.Parse(ReadLine());
//Cálculo do valor em dólares
double valorDolar = valorReais / cotacaoDolar;
//Cálculo do IOF
double iof = valorDolar * 0.06;
//Valor total em dólares com IOF
double valorTotalDolar = valorDolar + iof;
//Saída de dados
WriteLine($"Valor em dólares: {valorDolar:F2}");
WriteLine($"Valor do IOF: {iof:F2}");
WriteLine($"Valor total em dólares com IOF: {valorTotalDolar:F2}");

