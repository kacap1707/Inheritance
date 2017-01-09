using System;

namespace ThreeDimensionalForms
{
    public class Ellipsoid : ThreeDShape
    {
        public Ellipsoid(double radiusA, double radiusB, double radiusC)
        {
            this.radiusA = radiusA;
            this.radiusB = radiusB;
            this.radiusC = radiusC;
        }

        public double radiusA;
        public double radiusB;
        public double radiusC;

        private const double p = 1.6075; // there is no exacte formule for ellipsoid surface, so it's for approximation

        public override double Volume => 4d / 3 * Math.PI * radiusA * radiusB * radiusC;

        public override double Surface
            =>
                4 * Math.PI *
                Math.Pow((Math.Pow(radiusA * radiusB, p) + Math.Pow(radiusA * radiusC, p) + Math.Pow(radiusB * radiusC, p)) / 3, p);
    }
}
