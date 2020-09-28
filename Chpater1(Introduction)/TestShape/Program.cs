using System;

namespace TestShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle=new Circle(5);
            Console.WriteLine(circle.calcArea());

            Rectangle rectangle =new Rectangle(4, 5);
            Console.WriteLine(rectangle.calcArea());

            Console.ReadLine();

        }
    }
    public abstract class Shape
    {
        protected double area;
        public abstract double calcArea();
    }

    public class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double calcArea()
        {
            area = 3.14 * (radius * radius);
            return (area);
        }
    }
    public class Rectangle :Shape
    {
        private double lenght;
        private double width;

        public Rectangle(double l, double w)
        {
            lenght = l;
            width = w;
        }

        public override double calcArea()
        {
            area =lenght *width;
            return (area);
        }
    }


}
