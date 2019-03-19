namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public Rectangulo(decimal base1, decimal altura)
        {
            Base = base1;
            Altura = altura;
        }

        public decimal Base { get; set; }

        public decimal Altura { get; set; }

        public override decimal Area => Base * Altura;

        public override decimal Perimetro => Base * 2 + Altura * 2;

    }
}
