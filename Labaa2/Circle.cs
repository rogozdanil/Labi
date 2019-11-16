using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    public class Circle : Figure, IPrint
    {
        public double Radius { get; set; }

        public override string FigureName => $"круга";

        public Circle(double radius = 0) => Radius = radius;

        public override double Area() => Math.PI * Radius * Radius;
        public void Print() => Console.WriteLine(this.ToString());

        public override string ToString()
        {
            return $"Площадь {this.FigureName} = {this.Area()}";
        }
    }
}
