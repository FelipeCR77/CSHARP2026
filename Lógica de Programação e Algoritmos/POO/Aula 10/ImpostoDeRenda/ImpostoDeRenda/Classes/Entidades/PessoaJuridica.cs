
namespace ImpostoDeRenda.Classes.Entidades
{
    abstract class PessoaJuridica
    {
        // Campos
        private string nome;
        private double rendaAnual;
        private int funcionarios;

        // Propriedades
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
        protected string Funcionarios;

        // Construtor
        protected PessoaJuridica(string nome, double rendaAnual, int funcionarios)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
            this.funcionarios = funcionarios;
        }
        // Método
        protected double Imposto()
         {   double imposto;
            if (funcionarios < 10)
            {
                imposto = rendaAnual * 0.16;
            }
            else
            {
                imposto = rendaAnual * 0.14;
            }
            return imposto;
    }

    }
}



