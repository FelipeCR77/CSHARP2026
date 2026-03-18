using static System.Console;
//declaração de variaveis
const int SENHAFIXA  = 2002;
int senha;
//entrada de dados
Write("Digite a senha: ");
senha = int.Parse(ReadLine());
//processamento de dados
while (senha != SENHAFIXA)
{
    if(contagem >=3)
    {
        WriteLine("Acesso Bloqueado!");
        break;
    }
    contagem++;
    Write("Senha Invalida! Digite novamente: ");
    senha = int.Parse(ReadLine());
}
if (contagem < 3)
{
WriteLine("Acesso Permitido!");

}

else
{
    
}

