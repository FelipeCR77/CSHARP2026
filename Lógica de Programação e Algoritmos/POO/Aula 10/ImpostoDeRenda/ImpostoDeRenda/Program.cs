using static System.Console;
Write(" é pessoal física ou jurídica? (f/j) ");
char escolha = char.Parse(ReadLine()!);
Write("Digite o valor do salário: ");
double salario = double.Parse(ReadLine()!);
Console.WriteLine(salario);
Write("Digite o valor do gasto com saúde: ");
double gastoSaude = double.Parse(ReadLine()!);
for (int i = 0; i < 1; i++)
{
    if (salario > 20000.00)
    {
        double imposto = salario * 0.25 - gastoSaude * 0.50;
        Console.WriteLine($"O imposto a ser pago é: {imposto.ToString("F2")}");
    }
    else
    {
        double imposto = salario * 0.15 - gastoSaude * 0.50;
        Console.WriteLine($"O imposto a ser pago é: {imposto.ToString("F2")}");
    }
}
if (escolha == 'j')
{
    Write("Digite o número de funcionários: ");
    int funcionarios = int.Parse(ReadLine()!);
    if (funcionarios < 10)
    {
        double imposto = salario * 0.16;
        Console.WriteLine($"O imposto a ser pago é: {imposto.ToString("F2")}");
    }
    else
    {
        double imposto = salario * 0.14;
        Console.WriteLine($"O imposto a ser pago é: {imposto.ToString("F2")}");
    }
}
if (escolha == 'f')
{
    double imposto = salario * 0.15 - gastoSaude * 0.50;
    Console.WriteLine($"O imposto a ser pago é: {imposto.ToString("F2")}");
}




