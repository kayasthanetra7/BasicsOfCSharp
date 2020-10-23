using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Dictionary_Examples
{
    class Vegetables
    {
        public void TypeOfVeges()
        {
            //Adding dictionary which contains int as key and string as value
            Dictionary<int, string> Veges = new Dictionary<int, string>();
            Veges.Add(1, "Mushrooms");
            Veges.Add(2, "Green Peppers");
            Veges.Add(3, "Cabbage");
            Veges.Add(4, "Cauliflower");
            Veges.Add(5, "Brinjal");

            // print the dictionary with the keyvalue pair
            foreach (KeyValuePair<int, string> kvp in Veges)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine();

            //Reassign
            Veges[5] = "Okra";

            // print the dictionary with the new keyvalue pair reassignment
            foreach (KeyValuePair<int, string> kvp in Veges)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine();

            Console.WriteLine(Veges.ContainsKey(4));
            Console.WriteLine(Veges.ContainsValue("Cauliflower"));
            Console.WriteLine(Veges.ContainsValue("Tomato"));
            Console.WriteLine();

            // See whether Dictionary contains this key
            if (Veges.ContainsKey(4))
            {
                Console.WriteLine("I am Cauliflower!!");
            }

            // See whether Dictionary contains this string
            if (Veges.ContainsValue("Cabbage"))
            {
                Console.WriteLine("Cabbage is present");
            }
            Console.WriteLine();
        }

        public void ColourofVeges()
        {
            //Adding dictionary which contains string as both key and value
            Dictionary<string, string> Colour = new Dictionary<string, string>();
            Colour.Add("Tomato", "Red");
            Colour.Add("Cabbage", "Green");
            Colour.Add("Spinach", "Green");
            Colour.Add("Brinjal", "Purple");
            Colour.Add("Peppers", "Red");
            Colour.Add("Cauliflower", "green");

            // Count the number of strings that contain Green as the value
            var count = Colour.Count(x => string.Equals(x.Value, "green", StringComparison.OrdinalIgnoreCase));

            // print the dictionary with the keyvalue pair
            foreach (KeyValuePair<string, string> kvp in Colour)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine();

            Console.WriteLine("Count: {0}", count);

        }
    }
}
