using System;

namespace HomeWork4
{
    class Circle : Figures
    {
        double radius;
       
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override string Name()
        {
            return "Круг:";
        }

        public override double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public override double GetPerimetr()
        {
            return 2 * radius * Math.PI;
        }
    }
}
