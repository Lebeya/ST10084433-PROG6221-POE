using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    internal class HomeLoan : Expenses // derived from expenses 
    {
        // variables are set as public in order for Calc class to access them
        public static int temp;
        public static double monthlyRepayment;
        public static double rentalFee;
        // set to public in order for main to access variables 
        public static double purchasePrice;
        public static double deposit;
        public static double interestRate;
        public static int repaymentTime;

        
        public override void input()
        {              
            Console.ForegroundColor = ConsoleColor.Blue ;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                             Property                                                 ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            Console.WriteLine("Enter (1) if you are renting accomodation"
                              + "\n Enter (2) if you are buying a property");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 1) 
            {
                Console.WriteLine("Enter monthly rental fee: ");
                rentalFee = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter property purchase price: "); //taking user input
                purchasePrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter total deposit: ");
                deposit = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter interest rate: ");
                interestRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number of months to repay(between 240 and 360): ");
                repaymentTime = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;

        }

        public void repayment(double purchasePriceTemp, double totDepositTemp, double interestRateTemp, int monthsTemp)// arguments will take their values from the main class 
        {

            double principalAmount = purchasePriceTemp - totDepositTemp;
            int years = monthsTemp / 12;
            double interest = interestRateTemp * 0.01;

            double totalRepayment = (principalAmount*(1 + interest * years)); // calculating total repayment 

            monthlyRepayment = totalRepayment / monthsTemp;

            Console.WriteLine();
            Console.WriteLine("The monthly repayment will be: " + "R" + Math.Round(monthlyRepayment));
            Console.WriteLine();

            Console.WriteLine("Calculating...");
            Thread.Sleep(3000);
            Console.WriteLine();

           if (monthlyRepayment > (grossIncome / 3)) // if greater than 1/3 --> unlinkely loan approval
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("***WARNING***"
                                  + "\n Monthly repayment fee exceeds expected gross income amount"
                                  + "\n Loan approval unlikely");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***SUCCESS***"
                                 + "\n Expected gross income is sufficient"
                                 + "\n Loan approved");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
