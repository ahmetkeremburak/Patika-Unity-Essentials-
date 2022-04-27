using System;

namespace Operatörler
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///User input for meal cost, tip percentage,tax percentage
            Console.WriteLine("Please Enter Meal Cost: ");
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Tip Percent: ");
            int tip_percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Tax Percent: ");
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            double tip;
        
            double tax;
        
            double total_cost;

            ///Tip and tax are calculated according to meal cost and prefered percentage.
            tip = meal_cost * tip_percent / 100;
        
            tax = meal_cost * tax_percent / 100;
            
            ///Total cost of the meal with tip and taxes are rounded up.
            total_cost = meal_cost + tip + tax;

            ///Total cost is printed on the console.
            Console.WriteLine("Your total cost comes to " + Math.Round(total_cost) + " gold coins.");
        }

        
    }
}
