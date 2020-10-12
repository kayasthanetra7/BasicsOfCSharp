// This is example of Static Polymorphism, which is based on the concept of method overloading.
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPractice
{
    public class Calculator
    {
        public void AddNumbers(int a, int b) // Method AddNumbers takes 2 parameters.
        {
            Console.WriteLine("a + b = {0}", a + b);
        }

        public void AddNumbers(int a, int b, int c) // Method AddNumbers takes 3 parameters.
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }
}
