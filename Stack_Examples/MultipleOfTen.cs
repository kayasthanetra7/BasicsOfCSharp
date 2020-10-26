using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack_Examples
{
    class MultipleOfTen
    {
        public void GetStack()
        {
            //Create and Initialise the stack
            Stack myStk1 = new Stack();
            myStk1.Push(10);
            myStk1.Push(20);
            myStk1.Push(30);
            myStk1.Push(40);
            myStk1.Push(100);
            myStk1.Push(1000);

            //Removes and returns the object on top of the stack
            myStk1.Pop();

            foreach (int i in myStk1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Return the object on top of the stack without removing it
            Console.WriteLine("The last element: {0}", myStk1.Peek());
            Console.WriteLine();

            //Checks whether an element is in the stack
            if (myStk1.Contains(20))
            {
                Console.WriteLine("Yay! 20 is present");
            }
            else
            {
                Console.WriteLine("Element is missing");
            }
            Console.WriteLine();

            //Creating copy using Clone() method 
            Stack myStk2 = (Stack)myStk1.Clone();

            //Removes all the object from the stack
            myStk1.Clear();
            Console.WriteLine("Elements present: {0}", myStk1.Count);
            Console.WriteLine();

            foreach (int i in myStk2)
            {
                Console.WriteLine("Elements in myStk2: {0}", i);
            }
        }
    }
}
