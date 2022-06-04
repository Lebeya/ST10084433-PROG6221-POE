using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    internal class DetailedExpenses 
    {
        public delegate void msgDelTwo(int a);
        public static double expensesOutput;
        public void output()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Would you like to view all of your expenses?" + "\n Enter (1) for yes or (2) for no");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(HomeLoan.temp == 1) // used condition to decicide wwhether to add rental fee or home repayment
            {
                expensesOutput = Expenses.totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.rentalFee + Expenses.estTax;
            }
            else
            {
                expensesOutput = Expenses.totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.monthlyRepayment + Expenses.estTax;
            }

            msgDelTwo mg = new msgDelTwo(msg); // delegate declaration 
            Console.WriteLine();
            Console.WriteLine("Loading...");
            Thread.Sleep(3000);
            mg.Invoke(temp); // invokes the delegate
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void msg(int msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (msg == 1 && HomeLoan.temp == 1)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("Taxes: R" + Expenses.estTax);
                Console.WriteLine("Groceries: R" + Expenses.groceries);
                Console.WriteLine("Water and lights: R" + Expenses.waterLights);
                Console.WriteLine("Travel expenses: R" + Expenses.travel);
                Console.WriteLine("Phone: R" + Expenses.phone);
                Console.WriteLine("Extras: R" + Expenses.extras);
                Console.WriteLine("Monthly rent: R" + Math.Round(HomeLoan.rentalFee));
                Console.WriteLine("Monthly car repayment: R" + Math.Round(Vehicle.monthlyCarRepayment));
                Console.WriteLine();
                Console.WriteLine("Total expenses(including tax and repayments): R" + expensesOutput);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            }
            else if(msg == 1 && HomeLoan.temp == 2)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("Taxes: R" + Expenses.estTax);
                Console.WriteLine("Groceries: R" + Expenses.groceries);
                Console.WriteLine("Water and lights: R" + Expenses.waterLights);
                Console.WriteLine("Travel expenses: R" + Expenses.travel);
                Console.WriteLine("Phone: R" + Expenses.phone);
                Console.WriteLine("Extras: R" + Expenses.extras);
                Console.WriteLine("Monthly house repayment: R" + Math.Round(HomeLoan.monthlyRepayment));
                Console.WriteLine("Monthly car repayment: R" + Math.Round(Vehicle.monthlyCarRepayment));
                Console.WriteLine();
                Console.WriteLine("Total expenses(including tax and repayments): R" + expensesOutput);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
