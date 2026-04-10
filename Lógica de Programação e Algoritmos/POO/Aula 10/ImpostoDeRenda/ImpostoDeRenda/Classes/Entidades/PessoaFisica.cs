

namespace ImpostoDeRenda.Classes.Entidades
{
    abstract class PessoaFisica
    {
        //Campos
        private string nome;
        private string rendaAnual;
        private string gastoSaude;

        //Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected string RendaAnual
        {
            get { return rendaAnual; }
            set { rendaAnual = value; }
        }
        protected string GastoSaude
        { get { return gastoSaude; } }

        //Construtor
        protected PessoaFisica(string nome, string rendaAnual, string gastoSaude)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
            this.gastoSaude = gastoSaude;
        }
        //Método
        abstract protected double Imposto();
        {    double imposto;
            if (rendaAnual > 20000.00)
            {
                imposto = rendaAnual * 0.25 - gastoSaude * 0.50;
            }
            else
            {
                imposto = rendaAnual * 0.15 - gastoSaude* 0.50;

            

        

}
