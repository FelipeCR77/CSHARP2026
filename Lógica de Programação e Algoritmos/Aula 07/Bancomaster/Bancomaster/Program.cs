using Bancomaster;
using static System.Console;

WriteLine("Escolha qual conta deseja abrir:"+
"\n\t 1 - Conta Comum" +
    "\n\t 2 - Conta Poupança" +
    "\n\t 3 - Conta Empresa");

int opcao = int.Parse(ReadLine());

switch (opcao)
{

    case 1:
        Conta conta;
        Write("Digite o titular da conta: ");
        string titular = ReadLine();
        Write("Digite o número da conta: ");
        int numero = int.Parse(ReadLine());
        Write("Deseja fazer depósito inicial da conta (s/n) ");
        char escolha = char.Parse(ReadLine());

        if (escolha == 's')
        {
            Write("Digite o depósito inicial: ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(numero, titular, deposito);

        }
        else
        {
            conta = new Conta(numero, titular);
        }
        break;
}

