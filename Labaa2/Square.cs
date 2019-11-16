using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    public class Square : Rectangle, IPrint
    {

        public override string FigureName => $"квадрата";

        public Square(double side = 0)
            : base(side, side) {}

        public override double Area() => Width * Height;

        public override string ToString()
        {
            return $"Площадь {this.FigureName} = {this.Area()}";
        }
    }
}
