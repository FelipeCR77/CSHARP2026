
using Heranca;

namespace heranca
{
    internal class Pessoajuridica : PessoaFisica
    {
        private double limite;

        public double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }



        public Pessoajuridica(int numeroConta, string titularConta, double limiteEmprestimo) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public Pessoajuridica(int numeroConta, string titularConta, double saldoConta, double limiteEmprestimo) : base(numeroConta, titularConta, saldoConta)
        {
            LimiteEmprestimo = limiteEmprestimo; 
        }

        //Métodos
        public void Limite(double quantia)
        {
            LimiteEmprestimo += quantia;
        }
    }
}
