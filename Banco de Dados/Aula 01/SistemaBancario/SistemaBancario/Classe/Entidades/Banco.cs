
namespace SistemaBancario.Classe.Entidades
{
    /// <summary>
    /// Classe que representa uma conta bancária com operações básicas 
    /// implenta as regras de negócio
    /// </summary>
    internal class Banco
    {
        /// Campo
        /// <summary>
        /// Taxa fixa cobrada em cada operação de saque
        /// </summary>
        private const double TaxaSaque = 5.00;


        // Propriedade
        /// <summary>
        /// identificador único da conta bancária de dados (gerado automaticamente)
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Numero de conta bancária
        /// 'init' garante que o valor só ser atribuido na criação(imutável, após construção)
        /// </summary>
        public int NumeroConta { get; init; }

        /// <summary>
        /// Nome do titular da conta
        /// </summary>

        public string Titular { get; set; }

        /// <summary>
        /// Salão atual da conta
        /// 'private set' impede alterações direta - só pode mudar atráves de Depósito ou Saque
        /// </summary>

        public string Saldo { get; private set; }

        // Construtores
        /// Construtor privado sem paramentro
        /// necessário p/o Entity Framework instanciar classes ao buscar
        /// no banco de dados
        /// não deve ser utilizado diretamente no código
        /// </summary>
        private Banco()
        {
        }
        /// <summary>
        /// Construtor principal para criar uma nova conta bancária
        /// </summary>
        /// <param name="numeroConta">Número único da conta (não pode ser alterado depois) </param>
        /// <param name="titular"> Nome do Titular da Conta </param>
        /// <param name="saldo"> Valor do depósito inical ( opcional, padrão = 0) </param>
        /// 
        public Banco(int numeroConta, string titular, string saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }
        // Métodos
        /// <summary>
        /// Realiza um depósito na conta, aumentando o saldo da conta
        /// </summary>
        /// <param name="Valor" > Valor a ser depositado, deve ser positivo</param>
        public void deposito(double Valor)
        {
            Console.WriteLine("Valor de depósito deve ser positivo.");
            return;
        }
        saldo += Valor;

            Console.WriteLine($"Depósito de R${Valor} realizado com sucesso");
            }
    /// <summary>
    /// Realiza um saque na conta,diminuindo o saldo
    /// cobra automaticamente uma taxa de R$5,00 por saque
    /// IMPORTANTE: permite saldo negativo se não houver fundos
    /// </summary>
    /// <param name="Valor" Valor a ser sacado(deve ser positivo,não inclui a taxa
}




