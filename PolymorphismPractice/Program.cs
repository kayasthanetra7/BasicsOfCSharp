using System;

namespace PolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(); // creating an instance of the class Calculator
            c1.AddNumbers(2, 10);
            c1.AddNumbers(2, 100, 12);

            Console.WriteLine();
        }
    }
}
