using System;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }

        public decimal Lado { get; set; }

        public override decimal Area => ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;

        public override decimal Perimetro => Lado * 3;

    }
}
