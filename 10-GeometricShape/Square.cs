using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GeometricShape
{
    internal class Square : GeometricShapes
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the height of your square or rectangle: ");
            int.TryParse(Console.ReadLine(), out int height);
            Height = height;
            Console.WriteLine("Enter the floor of your square or rectangle: ");
            int.TryParse(Console.ReadLine(), out int floor);
            Floor = floor;
            int area = (Height * Floor);
            Console.WriteLine("Area: " + area);
        }
        public override void GetPerimeter()
        {
            int perimeter = 2*(Height + Floor);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
