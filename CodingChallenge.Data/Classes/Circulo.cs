using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private const decimal PI = (decimal)Math.PI;

        public Circulo(decimal radio)
        {
            Radio = radio;
        }

        public decimal Radio { get; set; }

        public override decimal Area => (decimal)Math.PI * (Radio / 2) * (Radio / 2);

        public override decimal Perimetro => PI * Radio;
    }
}
