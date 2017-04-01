using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        public static void Main(string[] args)
        {

            Rectangle rect = new Rectangle(12, 15);


            Console.WriteLine("Площадь прямоугольника:{0}", rect.GetArea());
            Console.WriteLine("Периметр прямоугольника:{0}", rect.GetPerimetr());



            //    Console.WriteLine("Площадь круга:{0}", squareCircle.ToString("0.00"));
            //    Console.WriteLine("Периметр круга:{0}", perimeterCircle.ToString("0.00"));


            //    Console.WriteLine("Площадь треугольника:{0}", squareTriangle.ToString("0.00"));
            //    Console.WriteLine("Периметр треугольника:{0}", perimeterTriangle.ToString("0.00"));


            //    Console.WriteLine("Площадь сектора:{0}", squareSector);
            //    Console.WriteLine("Периметр сектора:{0}", perimeterSector);
            //    Console.ReadLine();
            //
        }
    }
    class Figures
    {

        public virtual string Name()
        {
            return "";
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public virtual double GetPerimetr()
        {
            return 0;
        }
        //public string st;

        //public uint Rectangle(uint lengthRectangle, uint widthRectangle)
        //{

        //    uint squareRectangle = lengthRectangle * widthRectangle;//S=a*b
        //    uint perimeterRectangle = (lengthRectangle + widthRectangle) / 2;//p=(a+b)/2

        //}

        //public double Circle()
        //{
        //    double squareCircle = radius * radius * Math.PI;//s=Пr^2
        //    double perimeterCircle = 2 * radius * Math.PI;//P=2Пr
        //}

        //public double Triangle()
        //{
        //    return 
        //    double perimeterTriangle = lengthTriangle1 + lengthTriangle2 + lengthTriangle3;//P=a+b+c; 
        //    double squareTriangle = Math.Sqrt(perimeterTriangle * (perimeterTriangle - lengthTriangle1) * (perimeterTriangle - lengthTriangle2) * (perimeterTriangle - lengthTriangle3));
        //}

        //public double Sector()
        //{
        //    double squareSector = 0.5 * radius * lengthSector;//S=1/2*l*r
        //    double perimeterSector = (lengthSector + 2) / radius;//p=(l+2)/r
        //}
    }

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

