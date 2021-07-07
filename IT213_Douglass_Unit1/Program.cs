using System;

namespace IT213_Douglass_Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name = "John Smith";
            string address = "101 N. Main Street";
            string city = "AnyTown";
            string state = "TX";
            string zip = "11111";
            string unitsTaken = "19";
            int intUnitsTaken = Int32.Parse(unitsTaken);      // Convert string to int
            int incUnitsTaken = ++intUnitsTaken;              // Increment by 1
            double pricePerUnit = 100.50;
            double tuition = pricePerUnit * incUnitsTaken;    // Calculate tuition
            int discount = 150;
            double afterDiscount = tuition - discount;        // Calculate tuition after discount
            double monthlyPayment = afterDiscount / 12;       // Calculate monthly payment

            // Print output
            Console.WriteLine("Name: " + name);
            Console.WriteLine(" ");
            Console.WriteLine("Address: " + address);
            Console.WriteLine(" ");
            Console.WriteLine("City: " + city);
            Console.WriteLine(" ");
            Console.WriteLine("State: " + state);
            Console.WriteLine(" ");
            Console.WriteLine("Zip Code: " + zip);
            Console.WriteLine(" ");
            Console.WriteLine("The number of units taken is: " + incUnitsTaken);
            Console.WriteLine(" ");
            Console.WriteLine("The tuition before discount is " + tuition.ToString("C"));
            Console.WriteLine(" ");
            Console.WriteLine("The tuition after twenty-unit discount is " + afterDiscount.ToString("C"));
            Console.WriteLine(" ");
            Console.WriteLine("Your monthly payment is " + monthlyPayment.ToString("C"));


        }
    }
}
