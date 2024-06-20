using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_GeometricPolymorphism
{
    internal class GeometricalShape
    {
        public double Height { get; set; }
        public double Floor { get; set; }
        public virtual double GetArea()
        {
            return Height * Floor;
        }
        public virtual double GetPerimeter()
        {
            return (Height + Floor) * 2;
        }
        public void PrintInfo()
        {
            Console.WriteLine(GetArea());
            Console.WriteLine(GetPerimeter());
        }
    }
    internal class Square : GeometricalShape
    {
        public Square(double h, double f)
        {
            Height = h;
            Floor = f;
        }
    }
    internal class RightAngledTriangle : GeometricalShape
    {
        public RightAngledTriangle(int h, int f)
        {
            Height = h;
            Floor = f;
        }
        public override double GetArea()
        {
            return base.GetArea() / 2;
        }
        public override double GetPerimeter()
        {
            double perimeter;
            double hypotenuse = Math.Sqrt(Height * Height + Floor * Floor);
            return perimeter = Height + Floor + hypotenuse;
        }
    }
    internal class Rectangle : GeometricalShape
    {
        public Rectangle(int h, int f)
        {
            Height = h;
            Floor = f;
        }
    }
    internal class Circle : GeometricalShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

}
