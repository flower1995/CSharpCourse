namespace HomeWork4
{
    class Rectangle : Figures
    {
        double width;
        double heigth;

        public Rectangle(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public override string Name()
        {
            return "Прямоугольник:";
        }

        public override double GetArea()
        {
            return width * heigth;
        }

        public override double GetPerimetr()
        {
            return 2 * (width + heigth);
        }
    }
}
