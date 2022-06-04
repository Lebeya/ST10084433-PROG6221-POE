using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    internal class Calc : Expenses
    {
        public delegate void msgDel();
        public static double tempExpenses;

        public override void input()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                      Final Calculations                                             ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            double monthlyAmount;

            if (HomeLoan.temp == 1) // if rent was chosen --> then option 1 --> else option 2
            {
                monthlyAmount = (grossIncome-(totalExpenses + HomeLoan.rentalFee + Vehicle.monthlyCarRepayment + estTax));
            }
            else
            {
                monthlyAmount = (grossIncome - (totalExpenses + HomeLoan.monthlyRepayment + Vehicle.monthlyCarRepayment + estTax)); ;
            }


            msgDel mg = delegate // anon method using delegates
            {
                if (HomeLoan.temp == 1)
                {
                    tempExpenses = totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.rentalFee + estTax; // if rent was chosen rent is used in calc

                    if (tempExpenses > (grossIncome * 0.75)) // if expenses exceed 75% of gross income --> warning message is issued
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("******WARNING******" + "\n Total expenses exceed 75% of your income!"
                                          + "\n Saving is recommended");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    tempExpenses = totalExpenses + Vehicle.monthlyCarRepayment + HomeLoan.monthlyRepayment + estTax; // if purchase property was chosen --> monthly repayment is used in calc

                    if (tempExpenses > (grossIncome * 0.75))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("******WARNING******" + "\n Total expenses exceed 75% of your income!"
                                          + "\n Saving is recommended");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            };

            mg.Invoke();

            expensesList.Sort(); // expensesList is sorted
            expensesList.Reverse(); // after sorting is put into reverse order

            Console.WriteLine();
            int tempNum =1;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Expenses: ");
            foreach (double i in expensesList)
            {
                Console.WriteLine(tempNum + ") " +  i + " ", tempNum++); //prints out each value in the expensesList in descending order
            }


            Console.WriteLine();
            Console.WriteLine("The remaining balance for the month is : " + "R" + Math.Round(monthlyAmount));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
