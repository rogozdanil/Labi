using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Circle circle = new Circle(123);
            Square square = new Square(14325364);
            Rectangle rectangle = new Rectangle(12, 12);
            circle.Print();
            square.Print();
            rectangle.Print();
        }
    }
}
