namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoDerecho, decimal ladoIzquierdo)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            LadoDerecho = ladoDerecho;
            LadoIzquierdo = ladoIzquierdo;
        }

        public decimal BaseMayor { get; set; }

        public decimal BaseMenor { get; set; }

        public decimal LadoDerecho { get; set; }

        public decimal LadoIzquierdo { get; set; }

        public decimal Altura { get; set; }

        public override decimal Area => (BaseMayor + BaseMenor) * Altura / 2;

        public override decimal Perimetro => BaseMayor + BaseMenor + LadoDerecho + LadoIzquierdo;

    }
}
