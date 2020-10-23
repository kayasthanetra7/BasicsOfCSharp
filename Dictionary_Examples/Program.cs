using System;

namespace Dictionary_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruits f1 = new Fruits();
            f1.Types();
            Console.WriteLine();

            Vegetables v1 = new Vegetables();
            v1.TypeOfVeges();
            v1.ColourofVeges();
        }
    }
}
