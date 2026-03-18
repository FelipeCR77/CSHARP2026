using static System.Console;
//Declaração de uma matriz 

int n = int.Parse(ReadLine());
if ( n<=10)


int[,] matriz = new int[n, n];

//Entrada de dados
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
       Write($"Digite o valor p/ a posição [{i},{j}]: ");
         matriz[i, j] = int.Parse(ReadLine());

    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write("{matriz[i, j]} \t");
    }
    WriteLine();
}