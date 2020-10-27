using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue_Examples
{
    class MultiplesOfTen
    {
        public void GetQueue()
        {
            //Create and Initialise the queue
            Queue myQueue = new Queue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(50);
            myQueue.Enqueue(100);
            myQueue.Enqueue(500);
            myQueue.Enqueue(700);
            myQueue.Enqueue(1000);

            //Removes and returns the object on top of the Queue
            myQueue.Dequeue();

            foreach (int i in myQueue)
            {
                Console.WriteLine("Multiples of 10: {0}", i);
            }
            Console.WriteLine();

            // Returns the object at the beginning of the queue
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine();

            //check if an element is present in the queue
            if (myQueue.Contains(100))
            {
                Console.WriteLine("100 is present");
            }
            else
            {
                Console.WriteLine("100 is missing");
            }
            Console.WriteLine();

            //Creating copy using Clone() method 
            Queue myQueue1 = (Queue)myQueue.Clone();

            //Removes all the object from the stack
            myQueue.Clear();
            Console.WriteLine("Elements Present: {0}", myQueue1.Count);
            Console.WriteLine();

            foreach (int i in myQueue1)
            {
                Console.WriteLine("Elements in myQueue1: {0}", i);
            }
        }
    }
}
