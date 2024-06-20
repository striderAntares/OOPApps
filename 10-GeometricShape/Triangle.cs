using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GeometricShape
{
    internal class Triangle : GeometricShapes
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the height of your right angled triangle: ");
            int.TryParse(Console.ReadLine(), out int height);
            Height = height;
            Console.WriteLine("Enter the floor of your right angled triangle: ");
            int.TryParse(Console.ReadLine(), out int floor);
            Floor = floor;
            int area = (Height * Floor) / 2;
            Console.WriteLine("Area: " + area);
        }
        public override void GetPerimeter()
        {
            double hypotenuse = Math.Sqrt(Height * Height + Floor * Floor);
            double perimeter = Height + Floor + hypotenuse;
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
