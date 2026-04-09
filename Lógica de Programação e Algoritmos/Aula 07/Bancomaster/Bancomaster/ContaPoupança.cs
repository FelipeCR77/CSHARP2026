

namespace Bancomaster
{
    internal class ContaPoupanca : Conta
    {
		//Campo
		private double juros;

        //Propriedade
        public double Juros
        {
            get { return juros; }
            set { juros = value; }
        }

        //Construtores
        public ContaPoupanca(int numeroConta, string titularConta, double saldoConta, double jurosConta) : base(numeroConta, titularConta) {
        {
                TaxaDeJuros = TaxaJuros;

        }
            public ContaPoupanca(int numeroConta, string titularConta, double TaxaJuros) : base(numeroConta, titularConta,  saldoConta)
            {
                TaxaDeJuros = TaxaJuros;
            }
        //Métodos

        public void AtualizacaoDeSaldo()
        {
            SaldoConta += SaldoConta + (SaldoConta * TaxaDeJuros);
        }

        public override void Saque(double qtd)
        {
            SaldoConta -= qtd;


        }

}
}
