
namespace ImpostoDeRenda.Classes.Entidades
{
    abstract class PessoaJuridica
    {
        // Campos
        private string nome;
        private string rendaAnual;
        private string funcionarios;

        // Propriedades
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
        protected string Funcionarios;

        // Construtor
        protected PessoaJuridica(string nome, string rendaAnual, string funcionarios)
        {
            this.nome = nome;
            this.rendaAnual = rendaAnual;
            this.funcionarios = funcionarios;
        }
        // Método
        abstract protected double Imposto();
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


