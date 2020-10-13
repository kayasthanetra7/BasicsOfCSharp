// This is a example of Dynamic Polymorphism, which uses method overriding.
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismPractice
{
    public class Shapes
    {
        // Area method is overriden in other class since it is virtual
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle : Shapes 
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        
        public override double Area() 
        { 
            return 3.14 * Radius * Radius;
        }
    }

    public class Square : Shapes
    { 
        public double Side { get; set; }
        public Square()
        {
            Side = 4;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }

    public class Triangle : Shapes
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
            Base = 6;
            Height = 12;
        }
        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
