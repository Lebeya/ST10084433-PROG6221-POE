using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // objects of the classes
            HomeLoan hl = new HomeLoan();
            Calc c = new Calc();
            Vehicle v = new Vehicle();
            DetailedExpenses dt = new DetailedExpenses();

            // temp variable for holding user decision
            int decision;

            do
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------"); // housekeeping
                Console.WriteLine("                            Welcome to the budget keeping app                                        ");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");

                hl.expenses();
                hl.input();

                if (HomeLoan.temp == 2) // if user chose purchasing property --> then execute
                {
                    hl.repayment(HomeLoan.purchasePrice, HomeLoan.deposit, HomeLoan.interestRate, HomeLoan.repaymentTime);
                }
                v.input();
                c.input();
                dt.output();

                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("Would you like to continue using the app?: "
                                  + "Enter (1) for 'Yes', enter (2) to exit");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                decision = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            } while (decision != 2); // do while user does not choose exit

            // executed upon exiting app
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("App shutting down...");
            Thread.Sleep(3000);
            Console.WriteLine("Goodbye :)");
            Thread.Sleep(1000);
            Console.ForegroundColor= ConsoleColor.White;
            System.Environment.Exit(0);
       
            Console.Read();
        }
    }
}
