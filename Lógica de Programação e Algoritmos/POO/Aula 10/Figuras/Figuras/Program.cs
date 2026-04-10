using Figuras.Classes.Entidades;
using Figuras.Classes.Enumerações;
using static System.Console;

List<Forma> formas = new();

Write("Entre com a quantidade de formas: ");
int qtd = int .Parse(ReadLine());

for (int i = 0; i < qtd; i++)
{
  Write($"Dados do objeto geométrico nº {i + 1}:");
Write($"Retângulo ou Círculo (r/c)? ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
WriteLine("Qual é a cor do objeto?" +
    "\n\t1 - Vermelho" +
    "\n\t2 - Azul" +
    "\n\t3 - Amerelo" +
    "\n\t4 - Rosa");
        int cor = int.Parse(ReadLine());
    WriteLine("Digite a largura do retângulo: ");
        double l = double.Parse(ReadLine());
        Write("Digite a altura do retângulo: ");
        double a = double.Parse(ReadLine());
        formas.Add(new Retangulo((Cor)cor,l, a));
    }
    else if (escolha == 'c')
    {
        WriteLine("Qual é a cor do objeto?" +
    "\n\t1 - Vermelho" +
    "\n\t2 - Azul" +
    "\n\t3 - Amerelo" +
    "\n\t4 - Rosa");
        int cor = int.Parse(ReadLine());
        Write("Digite o raio da circunferência: ");
        double r = double.Parse(ReadLine());
        formas.Add(new Circulo((Cor)cor,r));



    }
}
foreach (var figurinhas in formas)
{
    Write(figurinhas.ToString());
}

