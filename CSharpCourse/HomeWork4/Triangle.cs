using System;
namespace HomeWork4
{
    class Triangle : Figures
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override string Name()
        {
            return "Треугольник:";
        }

        public override double GetArea()
        {
            double perimetr = GetPerimetr();
            return Math.Sqrt(perimetr * (perimetr - side1) * (perimetr - side2) * (perimetr - side3));
        }

        public override double GetPerimetr()
        {
            return side1 + side2 + side3;
        }
        
    }
}
