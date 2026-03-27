using static System.Console;

//declare a namespace called "dolares"

namespace dolares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(ReadLine());
            Write("Quantos dólares você vai comprar? ");
            double valorDolar = double.Parse(ReadLine());
            double valorReais = valorDolar * cotacao;
            double iof = valorDolar * 0.06;
            double total = valorReais + iof;
            WriteLine($"Valor a ser pago em reais: {total:F2}");
        }
    }
}

