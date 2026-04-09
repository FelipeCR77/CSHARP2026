

namespace Master
{
    internal class Conta: I0peracao
    {
        //Campos
        private Pessoa Cliente;
        private int numero;
        private double saldo;

        public Conta(int numeroConta, double saldoConta, Pessoa dadosCliente)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }


        //Propriedades
        public int NumeroConta
        { 
            get { return numero; }
        set { numero = value; }
        

        }
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Pessoa DadosCliente
        {
            get { return Cliente; }
            set { Cliente = value; }
        }


        //Métodos
        public void Deposito(double qtd)
        {
           saldo += qtd;
        }
        public void Saque(double qtd)
        {
         saldo -= qtd;   
        }

        public override string ToString()
        {
            return $"Dados da conta - {Tipo.ContaNormal} "+
                $"\n\tNome do titular: {Cliente.nome}" +
                $"\n\tCPF do titular: {Cliente.cpf}" +
                $"\n\tNúmero da conta: {numero}" +
                $"\n\tSaldo da conta: {saldo}";
        }
        
            
        }

    }

