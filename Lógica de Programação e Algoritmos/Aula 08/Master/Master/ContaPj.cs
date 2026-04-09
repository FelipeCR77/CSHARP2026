
namespace Master
{
    internal class ContaPj : Conta
    {
        //Campo
        private double limite;

        //Propriedade
        public double LimiteConta
        {
            get { return limite; }
            set { limite = value; }
        }
        //Construtor
        public ContaPj(int numeroConta, double saldoConta, Pessoa dadosCliente, double limite) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }
        //Método
        public void Emprestio(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }
    }

}

