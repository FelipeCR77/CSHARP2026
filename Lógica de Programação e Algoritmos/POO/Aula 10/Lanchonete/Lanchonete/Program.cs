using static System.Console;
//Uma lanchonete possui vários produtos. Cada produto possui um código e um preço. Você deve fazer um programa para ler o código e a quantidade comprada de um produto (suponha um código válido), e daí informar qual o valor a ser pago, com duas casas decimais, conforme tabela de produtos ao lado. 

class Program
{
    static void Main(string[] args)
    {
        string[] input = ReadLine().
        int codigo = int.Parse(input[0]);
        int quantidade = int.Parse(input[1]);
        double preco = 0.0;
        switch (codigo)
        {
            case 1:
                preco = 4.00;
                break;
            case 2:
                preco = 4.50;
                break;
            case 3:
                preco = 5.00;
                break;
            case 4:
                preco = 2.00;
                break;
            case 5:
                preco = 1.50;
                break;
        }
        double valorAPagar = preco * quantidade;
        WriteLine($"Total: R$ {valorAPagar:F2}");
    }
}



