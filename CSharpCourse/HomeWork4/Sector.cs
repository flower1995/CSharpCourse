namespace HomeWork4
{
    class Sector : Figures
    {
        double radius;
        double length;

        public Sector(double radius, double length)
        {
            this.radius = radius;
            this.length = length;
        }

        public override string Name()
        {
            return "Сектор:";
        }

        public override double GetArea()
        {
            return 0.5 * radius * length;
        }

        public override double GetPerimetr()
        {
            return (length + 2) / radius;
        }
    }
}
