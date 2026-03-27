using Banco;
 using static System.Console;
using static System.Globalization.CultureInfo;

Title = "Abertura de conta";
Contabancaria conta;
WriteLine("Abertura de conta");
Write("Entre com um numero de conta: ");
int numero = int.Parse(ReadLine());
Write("Entre com o nome do titular");
string nome = ReadLine();
Write("Deseja fazer um deposito inicial (s/n)?");
char resposta = char.Parse(ReadLine());

if ( resposta == 's' )
    {
    Write("Entre com o valor do deposito inicial: R$ ");
    double deposito = double.Parse(ReadLine());
    conta = new Contabancaria(numero, nome, deposito);
}
else
{
   conta = new Contabancaria(numero, nome);
}

conta.Dados();

WriteLine("Entre com um valor para deposito: R$ ");
double quantia = double.Parse(ReadLine());
conta.Deposito(quantia);
WriteLine("Entre com um valor para saque: R$ ");
quantia = double.Parse(ReadLine());
conta.Saque(quantia);



ReadKey();





