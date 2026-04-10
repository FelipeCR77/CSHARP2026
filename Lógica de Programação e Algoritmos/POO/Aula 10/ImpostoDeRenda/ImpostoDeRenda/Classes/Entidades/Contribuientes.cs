

namespace ImpostoDeRenda.Classes.Entidades
{
    abstract class Contribuientes
    {
        // Campos

        private double nome;
        private double rendaAnual;
        private double gastoSaude;
        private double Funcionarios;
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
        protected double GastoSaude
        { get { return gastoSaude; } }
        protected double Funcionarios
        { get { return Funcionarios; } }

        // Construtor
        private Contribuientes(double nome, double rendaAnual, double gastoSaude, double funcionarios)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
            this.gastoSaude = gastoSaude;
            this.Funcionarios = funcionarios;
        }
        public override string ToString() {
            return $"{nome}: $ {Imposto().ToString("F2")}";


        }
}
}
