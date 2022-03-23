namespace SOLID._3._LSP.Violacao.Exemplo2
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Comprimento { get; set; }
        public double Area { get { return Altura * Comprimento; } }
    }

    public class Quadrado : Retangulo
    {
        public override double Altura
        {
            set { base.Altura = base.Comprimento = value; }
        }

        public override double Comprimento
        {
            set { base.Altura = base.Comprimento = value; }
        }
    }
}
