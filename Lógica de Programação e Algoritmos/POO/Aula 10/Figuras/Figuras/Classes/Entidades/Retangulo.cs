using Figuras.Classes.Enumerações;


namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
        //Campos
        private double largura;

        public double altura;


        //Propriedades
        protected double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        
        protected double Largura
        {
            get { return largura; }
            set { largura = value; }
        }
        //Construtor
        public Retangulo(Cor corDaForma,double largura, double altura) : base(corDaForma)
        {
            Largura = largura;
            Altura = altura;

        }
        /// Calcula a aréa da forma usando as dimensões atuais
        /// <summary>
        /// <returns>O valor da aréa calculada com base na largura e altura do retângulo</returns>
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}

