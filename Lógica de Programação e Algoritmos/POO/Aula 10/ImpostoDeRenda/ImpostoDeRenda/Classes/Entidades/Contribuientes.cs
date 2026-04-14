

namespace ImpostoDeRenda.Classes.Entidades
{
    abstract class Contribuientes
    {
        // Campos

        private double nome;
        private double rendaAnual;
        private double gastoSaude;
        private double funcionarios;
        // Propriedades
        protected double Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected double RendaAnual
        {
            get { return rendaAnual; }
            set { rendaAnual = value; }
        }
        protected double GastoSaude { 
         get { return gastoSaude; }
         set {gastoSaude = value; }
        }



        protected double Funcionarios
        { get { return funcionarios; }
            set { funcionarios = value; }
        }

        // Construtor
        private Contribuientes(double nome, double rendaAnual, double gastoSaude, double funcionarios)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
            this.gastoSaude = gastoSaude;
            this.Funcionarios = funcionarios;
        }
        public override string ToString()
        {
            return $"{nome}: $ {Imposto():C}";
        }

        protected abstract object Imposto();
    }
}
