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
            string units_taken = "19";
            int int_units_taken = Int32.Parse(units_taken);      // Convert string to int
            int inc_units_taken = ++int_units_taken;                // Increment by 1
            double price_per_unit = 100.50;
            double tuition = price_per_unit * inc_units_taken; // Calculate tuition
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
            Console.WriteLine("The number of units taken is: " + inc_units_taken);
            Console.WriteLine(" ");
            Console.WriteLine("The tuition before discount is " + tuition.ToString("C"));
            Console.WriteLine(" ");
            Console.WriteLine("The tuition after twenty-unit discount is " + afterDiscount.ToString("C"));
            Console.WriteLine(" ");
            Console.WriteLine("Your monthly payment is " + monthlyPayment.ToString("C"));


        }
    }
}
