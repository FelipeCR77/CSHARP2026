using static System.Console;
//declaração de variaveis
double valor, valorPago, troco;
//entrada de dados
Write("Digite o valor da compra: ");
valor = double.Parse(ReadLine());
Write("Digite o valor pago: ");
valorPago = double.Parse(ReadLine());
//processamento de dados
troco = valorPago - valor;
//saida de dados
WriteLine($"O valor do troco é de R$ {troco}");


