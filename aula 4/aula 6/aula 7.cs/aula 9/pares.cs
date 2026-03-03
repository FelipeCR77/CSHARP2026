using static System.Console;
//Declarar as variaveis
int numero, valor;
try
{
    //Entrada de dados
    Write("Quantos números voce vai digitar?");
    numero = int.Parse(ReadLine());
    // processamento de dados
    for(int i = 0; i <numero; i++)
{
    Write("Digite um número:");
    valor = int.Parse(ReadLine());
    if(valor < 0)
    {
        Write("Negativo");
    }
    else if(valor> 0)
    {
        Write("Positivo");
    }
    else
        {
            Write("Nulo");
        }

        if((valor % 2)==0)
        {
            WriteLine("PAR");
        }
        else if ((valor % 2  )!=0)
        {
            WriteLine("IMPAR");
        }
}
}

catch (Exception ex)
{
    WriteLine("Valor invalido, erro = ", ex.Message);
}