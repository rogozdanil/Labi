using System;

namespace frst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Rogozin Danila IU5-31";
            double A, B, C;
            string AS, BS, CS;
            string answ = "Yes";
            while (answ == "Yes")
            {
                if ((args != null) && (args.Length >= 1))
                {
                    AS = args[0];
                }
                else
                {
                    Console.Write("A = ");
                    AS = Console.ReadLine();
                }
                while (!double.TryParse(AS, out A))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод. Повтори: ");
                   
                    AS = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                if ((args != null) && (args.Length >= 2))
                {
                    BS = args[1];
                }
                else
                {
                    Console.Write("B = ");
                    BS = Console.ReadLine();
                }
                while (!double.TryParse(BS, out B))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод. Повтори: ");
                    BS = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                if ((args != null) && (args.Length >= 3))
                {
                    CS = args[2];
                }
                else
                {
                    Console.Write("C = ");
                    CS = Console.ReadLine();
                }
                while (!double.TryParse(CS, out C))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод. Повтори: ");
                    CS = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.White;


                if ((A == 0) && (B == 0) && (C == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень уравнения - любое число.");
                    Console.WriteLine("Повторить? Yes/No");
                    answ = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((C != 0) && (B == 0) && (A == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет решений!");
                    Console.WriteLine("Повторить? Yes/No");
                    answ = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((B != 0) && (A == 0))
                {
                    double X = -C / B;
                    if (X < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет действительных корней.");
                        Console.WriteLine("Повторить? Yes/No");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (X == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:\nX = 0");
                        Console.WriteLine("Повторить? Yes/No");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни уравнения:\nX1 = {Math.Sqrt(X)}\nX2 = {-Math.Sqrt(X)}");
                        Console.WriteLine("Повторить? Yes/No");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    double D = B * B - 4 * A * C;
                    if (D < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Дискрименант меньше нуля. Уравнение не имеет действительных корней.");
                        Console.WriteLine("Повторить? Yes/No");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        double X = ((-1 * B) - Math.Sqrt(D)) / (2 * A);
                        double Y = ((-1 * B) + Math.Sqrt(D)) / (2 * A);
                        if ((X < 0) && (Y < 0))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Уравнение не имеет действительных корней.");
                            Console.WriteLine("Повторить? Yes/No");
                            answ = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корни уравнения:");
                            if (X > 0)
                            {
                                double X_1 = Math.Sqrt(X);
                                double X_2 = -1 * X_1;
                                Console.WriteLine($"X1 = {X_1},\nX2 = {X_2}");
                            }
                            else if (X == 0)
                                Console.WriteLine($"X = {X}");
                            if ((Y > 0) && (X != Y))
                            {
                                double Y_1 = Math.Sqrt(Y);
                                double Y_2 = -1 * Y_1;
                                Console.WriteLine($"X1 = {Y_1},\nX2 = {Y_2}");
                            }
                            else if ((Y == 0) && (X != Y))
                                Console.WriteLine($"X = {Y}");
                            Console.WriteLine("Повторить? Yes/No");
                            answ = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                args = null;
            }
        }

    }
}

