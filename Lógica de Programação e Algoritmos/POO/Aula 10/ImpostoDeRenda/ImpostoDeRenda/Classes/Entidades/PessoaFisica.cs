

namespace ImpostoDeRenda.Classes.Entidades
{
    abstract class PessoaFisica
    {
        //Campos
        private string nome;
        private double rendaAnual;
        private double gastoSaude;

        //Propriedades
        protected string Nome
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

        //Construtor
        protected PessoaFisica(string nome, double rendaAnual, double gastoSaude)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
            this.gastoSaude = gastoSaude;
        }
        //Método
        abstract protected double Imposto();
        

            

        

}
}


