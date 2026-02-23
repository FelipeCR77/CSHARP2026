using static System.Console;
//declaração de variaveis  
double dia, anos, meses, dias;
Write("Digite o número de dias: ");
dia = double.Parse(ReadLine());
//processamento de dados
anos = dia / 365;
meses = (dia % 365) / 30;
dias = (dia % 365) % 30;
//saida de dados
WriteLine($"{dia} dias equivalem a {anos} anos, {meses} meses e {dias} dias");
