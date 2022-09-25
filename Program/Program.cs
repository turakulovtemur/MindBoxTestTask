using System;
using ClassLibrary;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите радиус окружности для нахождения площади");
            //double number = Convert.ToDouble(Console.ReadLine());
            //Circle circle = new Circle(number);
            //Console.WriteLine($"Площадь круга радиусом {number} равна {circle.PrintCalculateSquare()}");



            Console.WriteLine("Введите длины сторон треугольника: a, b, c через enter");
            double FirstNum = Convert.ToDouble(Console.ReadLine());
            double SecondNum = Convert.ToDouble(Console.ReadLine());
            double ThirdNum = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle(FirstNum, SecondNum, ThirdNum);
            var square = triangle.GetSquare();


            Console.WriteLine($"Площадь треугольника равна {square}");
            if (triangle.IstRectangle == true)
            {
                Console.WriteLine($"Треугольник прямоугольный");
            }

        }
    }
}
