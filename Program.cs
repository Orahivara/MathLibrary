using System;
using MathLibrary;

namespace MathProv
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 7;
            int c = 35;
            double[] num = new double[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(Class1.SumArray(num));
            Console.WriteLine(Class1.MaxFromArray(num));
            Console.WriteLine(Class1.MinFromArray(num));
            Console.WriteLine(Class1.AVGArray(num));

            Console.WriteLine(Geometry.TrianglAarea(a, b));
            Console.WriteLine(Geometry.TrianglAarea(a, b, c));
            Console.WriteLine(Geometry.SquareArea(a));
            Console.WriteLine(Geometry.RectangleArea(a, b));
            Console.WriteLine(Geometry.RhombusArea(a, b));
            Console.WriteLine(Geometry.CircleArea(a));

            Console.WriteLine(Trigonometry.Sin(c));
            Console.WriteLine(Trigonometry.Cos(c));
            Console.WriteLine(Trigonometry.Tgn(c));
            Console.WriteLine(Trigonometry.Ctg(c));

            Console.ReadKey();
        }
    }
    }

