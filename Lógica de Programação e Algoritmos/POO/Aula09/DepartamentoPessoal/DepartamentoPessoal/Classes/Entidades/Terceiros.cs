

namespace DepartamentoPessoal.Classes.Entidades
{
    internal class Terceiros : Funcionario
    {
        //Campo
        private double despesa;

        //Propriedade
        protected double DespesaAdicional
        {
            get { return despesa; }
            set { despesa = value; }
        }

        //Construtor
        public Terceiros(string nomeColaborador, int jornadaTrabalho, double valorHora) : base(nomeColaborador, jornadaTrabalho, valorHora)
        {
            DespesaAdicional = despesa;
        }

        //Método
        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }
    }
}



