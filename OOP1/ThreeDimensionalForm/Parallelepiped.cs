using System;

namespace ThreeDimensionalForms
{
    public class Parallelepiped : ThreeDShape
    {
        public Parallelepiped(double baseEdgeA, double baseEdgeB, double edgeC, double angleAB, double angleCBase)
        {
            this.baseEdgeA = baseEdgeA;
            this.baseEdgeB = baseEdgeB;
            this.edgeC = edgeC;
            this.angleAB = angleAB;
            this.angleCBase = angleCBase;
        }

        public double baseEdgeA;
        public double baseEdgeB;
        public double edgeC;
        public double angleAB;
        public double angleCBase;

        public override double Volume => baseEdgeA * baseEdgeB * edgeC * Math.Sin(angleAB) * Math.Sin(angleCBase);
        public override double Surface => 2 * (baseEdgeA * baseEdgeB + baseEdgeA * edgeC + baseEdgeB * edgeC);
    }
}
