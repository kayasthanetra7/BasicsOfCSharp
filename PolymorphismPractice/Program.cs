using System;

namespace PolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(); // creating an instance of the Calculator class
            c1.AddNumbers(2, 10);
            c1.AddNumbers(2, 100, 12);
            Console.WriteLine();

            Shapes circle1 = new Circle();
            Console.WriteLine("Area of the circle: {0}", circle1.Area());

            Shapes square1 = new Square();
            Console.WriteLine("Area of the square: {0}", square1.Area());

            Shapes triangle1 = new Triangle();
            Console.WriteLine("Area of the triangle: {0}", triangle1.Area());


        }
    }
}
