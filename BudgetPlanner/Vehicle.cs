using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    internal class Vehicle : Expenses
    {
        public static double monthlyCarRepayment;

        public override void input()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // changing text colour for visual appeal 
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                             Vehicle                                                 ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Would you like to buy a vehicle?" + 
                              "\nEnter (1) for yes, (2) for no" );
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 1) // if 1 --> user input taken , if not --> skipped
            {
                Console.WriteLine("Enter the make: "); // taking user input
                string make = Console.ReadLine();

                Console.WriteLine("Enter the model: ");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the purchase price: ");
                double purchasePrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the total deposit: ");
                double totalDeposit = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the interest rate: ");
                double interestRateTemp = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the estimated insurance premium: ");
                double estInsurancePrem = Convert.ToDouble(Console.ReadLine());

                double principalAmount = purchasePrice - totalDeposit;
                double interestRate = interestRateTemp * 0.01; // * by 0.01 so that calc is able to use percentage correctly

                double totalRepayment = principalAmount * (1 + (interestRate * 5)); 

                monthlyCarRepayment = (totalRepayment / 60) + estInsurancePrem;

                Console.WriteLine();
                Console.WriteLine("Please wait...");
                Thread.Sleep(1000);
                Console.WriteLine("Calculating...");
                Thread.Sleep(2000);

                Console.WriteLine();
                Console.WriteLine("The monthly repayment amount for the " + make + " " + model + " will be: R" + Math.Round(monthlyCarRepayment)); // concatonation of user input make, model and calculated monthly repayment 
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
