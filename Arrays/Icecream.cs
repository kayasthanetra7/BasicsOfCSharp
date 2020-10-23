using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Icecream
    {

        // Base price of an icecream
        public decimal BasePrice = 1.55M;

        // Declaring arrays
        private string[] Flavor = new string[6];
        private string[] Container = new string[3];
        private string[] Toppings;

        //additional factors for processing an icecream order
        public decimal Scoops;
        public decimal TotalPrice;

        //Initialising array
        public Icecream()
        {
            Flavor[0] = "Chocolate";
            Flavor[1] = "Vanilla";
            Flavor[2] = "Strawberry";
            Flavor[3] = "Cookie Dough";
            Flavor[4] = "Pistachio";
            Flavor[5] = "Banana Foster";

            Container[0] = "Small";
            Container[1] = "Medium";
            Container[2] = "Large";

            Toppings = new string[4];
            Toppings[0] = "No additional Toppings";
            Toppings[1] = "Kitkats";
            Toppings[2] = "Chocolate Chip";
            Toppings[3] = "Nuts";

        }
        // Method for requesting flavor from the user
        public int ChooseFlavor()
        {
            int Choice = 0;
            // user should select a valid number 
            do
            {
                //Incase its a symbol and not a number
                try
                {
                    Console.WriteLine("What flavor would you like");
                    for (int i = 0; i < Flavor.Length; i++)
                        Console.WriteLine("{0} - {1}", i + 1, Flavor[i]);
                    Console.Write("Your choice?");
                    Choice = int.Parse(Console.ReadLine());
                }
                // display the message to catch if it is a symbol
                catch
                {
                    Console.WriteLine("Oops this is not a number, Pls try again");
                }

                // if the number entered is out of the allowed range for Flavors
                if (Choice < 1 || Choice > Flavor.Length)
                {
                    Console.WriteLine("Choice does not exist, Pls try again");
                }
            }
            while (Choice < 1 || Choice > Flavor.Length);

            // return the choice since its valid
            return Choice;
        }

        // Method for choosing the size of the container for your Icecream
        public int ChooseContainer()
        {
            int Choice = 0;
            // user should select a valid number 
            do
            {
                //Incase its a symbol and not a number
                try
                {
                    Console.WriteLine("What type of container would you like?");
                    for (int i = 0; i < Container.Length; i++)
                        Console.WriteLine("{0} - {1}", i + 1, Container[i]);
                    Console.WriteLine("Your choice");
                    Choice = int.Parse(Console.ReadLine());
                }
                // display the message to catch if it is a symbol
                catch
                {
                    Console.WriteLine("Oops this is not a number, Pls try again");
                }
                // if the number entered is out of the allowed range for container
                if (Choice < 1 || Choice > Container.Length)
                {
                    Console.WriteLine("Choice does not exist, Pls try again");
                }
            }
            while (Choice < 1 || Choice > Container.Length);

            // return the choice since its valid
            return Choice;
        }

        // Method for choosing the different toppings for your Icecream
        public int ChooseToppings()
        {
            int Choice = 0;
            // user should select a valid number 
            do
            {
                //Incase its a symbol and not a number
                try
                {
                    Console.WriteLine("What type of Toppings would you like?");
                    for (int i = 0; i < Toppings.Length; i++)
                        Console.WriteLine("{0}- {1}", i + 1, Toppings[i]);
                    Console.WriteLine("Your choice");
                    Choice = int.Parse(Console.ReadLine());
                }
                // display the message to catch if it is a symbol
                catch (FormatException)
                {
                    Console.WriteLine("Oops this is not a number, Pls try again");
                }
                // if the number entered is out of the allowed range for Toppings
                if (Choice < 1 || Choice > Toppings.Length)
                {
                    Console.WriteLine("Choice does not exist, Pls try again");
                }

            }
            while (Choice < 1 || Choice > Toppings.Length);
            // return the choice since its valid
            return Choice;
        }

        //  Method for choosing the number of scoops
        public void NumberofScoops()
        {
            do
            {
                try
                {
                    Console.WriteLine("How many scoops (1, 2 or 3)?");
                    Scoops = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pls enter a number");
                }
                if (Scoops < 1 || Scoops > 3)
                    Console.WriteLine("Pls enter a number from the above selection");
            }
            while (Scoops < 1 || Scoops > 3);

        }

        //Method to process the order
        public void ProcessOrder()
        {
            int ChoiceFlavor, ChoiceContainer, ChoiceToppings;
            decimal PriceToppings, PriceScoop, PriceContainer;

            //Different components for processing the icecream order
            Console.WriteLine("Ice cream Machine");
            ChoiceFlavor = ChooseFlavor();
            ChoiceContainer = ChooseContainer();
            ChoiceToppings = ChooseToppings();
            NumberofScoops();

            // Cost of each topping
            if (ChoiceToppings == 2 || ChoiceToppings == 3 || ChoiceToppings == 4)
                PriceToppings = 2.5M;
            else
                PriceToppings = 0.0M;

            //cost of each scoop
            if (Scoops == 1)
                PriceScoop = 2.5M;
            else if (Scoops == 2)
                PriceScoop = 4.0M;
            else
                PriceScoop = 5.0M;

            //cost of container
            if (ChoiceContainer == 1)
                PriceContainer = 3.0M;
            else if (ChoiceContainer == 2)
                PriceContainer = 5.0M;
            else
                PriceContainer = 6.5M;

            //Calculate total price of Icecream
            TotalPrice = BasePrice + PriceScoop + PriceToppings + PriceContainer;

            DisplayReciept(ref ChoiceFlavor, ref ChoiceContainer, ref ChoiceToppings);

        }

        //Display reciept of what the user is paying for
        public void DisplayReciept(ref int Flv, ref int Cnt, ref int Top)
        {
            Console.WriteLine("Flavor: {0}", Flavor[Flv - 1]);
            Console.WriteLine("Container: {0}", Container[Cnt - 1]);
            Console.WriteLine("Toppings: {0}", Toppings[Top - 1]);
            Console.WriteLine("Scoops: {0}", Scoops);
            Console.WriteLine("Total Price: {0}", TotalPrice);
        }
    }
}