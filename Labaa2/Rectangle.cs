using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    public class Rectangle : Figure, IPrint
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override string FigureName => $"прямоугольника";

        public Rectangle(double width = 0, double height = 0)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;
        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString()
        {
            return $"Площадь {this.FigureName} = {this.Area()}";
        }
    }
}
