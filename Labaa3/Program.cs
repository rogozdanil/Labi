using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Laba2;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(10, 2);
            Square square = new Square(4);
            Console.WriteLine("\nTest");
            Console.WriteLine("\nНеобобщенный список");
            ArrayList figuresArrayList = new ArrayList
            {
                circle,
                rectangle,
                square
            };
            figuresArrayList.Sort();
            foreach (var figure in figuresArrayList)
            {
                Console.WriteLine(figure.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("\nОбобщенный список");
            var figuresList = new List<Figure>
            {
                circle,
                rectangle,
                square
            };
            figuresList.Sort();
            foreach (var figure in figuresList)
            {
                Console.WriteLine(figure.ToString());
            }
            Console.WriteLine();


            Console.WriteLine("\nМатрица");
            SparseMatrix<Figure> cube = new SparseMatrix<Figure>(3, 3, 3, null);
            cube[0, 0, 0] = rectangle;
            cube[1, 1, 1] = square;
            cube[2, 2, 2] = circle;
            Console.WriteLine(cube.ToString());
            Console.WriteLine();

            Console.WriteLine("\nСамодельный обощенный список");
            SimpleList<Figure> list = new SimpleList<Figure>
            {
                circle
            };
            list.Add(square);
            list.Add(rectangle);
            foreach (var x in list) Console.WriteLine(x.ToString());

            Console.WriteLine("\nСтек");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rectangle);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
        }
    }
}
