namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public decimal Lado { get; set; }

        public override decimal Area => Lado * Lado;

        public override decimal Perimetro => Lado * 4;

    }
}
