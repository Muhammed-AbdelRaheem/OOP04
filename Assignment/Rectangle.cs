using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle :IRectangle
    {

        public double Width { get;  set; }
        public double Height { get;  set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}, Area: {Area}");
        }
    }
}
