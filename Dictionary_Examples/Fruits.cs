using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Examples
{
    class Fruits
    {
        public void Types()
        {
            // Adding dictionary which contains int as key and string as value
            Dictionary<int, string> TypesOfFruits = new Dictionary<int, string>();
            TypesOfFruits.Add(1, "Mango");
            TypesOfFruits.Add(2, "Banana");
            TypesOfFruits.Add(3, "Orange");
            TypesOfFruits.Add(4, "Pears");
            TypesOfFruits.Add(5, "Strawberry");
            TypesOfFruits[3] = "Apple"; // reassigning a new value for key 3

            // print the dictionary with the keyvalue pair
            foreach (KeyValuePair<int, string> kvp in TypesOfFruits)
                Console.WriteLine("Key: {0}, Pair {1}", kvp.Key, kvp.Value);
            Console.WriteLine();

            // Check if a particular key /value exist 
            Console.WriteLine(TypesOfFruits.ContainsKey(1));
            Console.WriteLine(TypesOfFruits.ContainsValue("Strawberry"));
            Console.WriteLine();

            // Check if particular key exist and print its value
            if (TypesOfFruits.ContainsKey(2))
            {
                Console.WriteLine(TypesOfFruits[2]);
            }
            Console.WriteLine();

            //Check if particular value exist
            if (TypesOfFruits.ContainsValue("Strawberry"))
            {
                Console.WriteLine("Strawberry is present");
            }

            if (TypesOfFruits.ContainsValue("Watermelon"))
            {
                Console.WriteLine("Watermelon is present");
            }
            Console.WriteLine();

            //Creating a copy of dictionary
            Dictionary<int, string> secondCopy = new Dictionary<int, string>(TypesOfFruits);
            foreach (KeyValuePair<int, string> kvp in secondCopy)
                Console.WriteLine("Key: {0}, Pair {1}", kvp.Key, kvp.Value);

        }
    }
}
