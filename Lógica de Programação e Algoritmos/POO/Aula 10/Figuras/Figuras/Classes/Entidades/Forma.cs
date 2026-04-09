using Figuras.Classes.Contratos;
namespace Figuras.Classes.Enumerações;

internal class Forma : IArea
{
    /// </summary>
    /// Cores disponíveis Vermelho, Azul e Amerelo
    /// <summary>
   //Campo
    private Cor cor;
    //Propriedade
    public Forma(Cor corDaForma)
    {
        CorDaForma = corDaForma;
    }
    //Construtor
    protected Cor CorDaForma
    {
        get { return cor; }
        set { cor = value; }
    }
    //Método
    public virtual double Area()
    {
        throw new NotImplementedException();
    }
}
