using System;
using System.Collections.Generic;

namespace HomeWork4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12, 15);
            Triangle triangle = new Triangle(50, 42, 46);
            Sector sector = new Sector(12, 15);
            Circle circle = new Circle(10);

            List<Figures> list = new List<Figures>();
            list.Add(rectangle);
            list.Add(triangle);
            list.Add(sector);
            list.Add(circle);

            foreach(Figures figure in list)
            {
                Console.WriteLine("Площадь фигуры:{0}", figure.GetArea().ToString("0.00"));
                Console.WriteLine("Периметр фигуры:{0}", figure.GetPerimetr().ToString("0.00"));
            }
            
            Console.ReadLine();
        }
    }

    abstract class Figures
    {
        public abstract string Name ();

        public abstract double GetArea();

        public abstract double GetPerimetr();
    }
}
