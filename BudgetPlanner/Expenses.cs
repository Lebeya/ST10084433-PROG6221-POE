using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    internal abstract class Expenses
    {
        // abstract class Expenses to hold variables utilised in derived classes
        public static double grossIncome;
        public static double estTax;
        public static double groceries;
        public static double waterLights;
        public static double travel;
        public static double phone;
        public static double extras;
        public static List<double> expensesList = new List<double>();

        public static double totalExpenses;

        public void expenses()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                        Income and Expenses                                          ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            // taking user input
            Console.WriteLine("Enter monthly income: ");
            grossIncome = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter estimated tax: ");
            estTax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter grocery costs: ");
            groceries = Convert.ToDouble(Console.ReadLine());
            expensesList.Add(groceries); // adding expenses into an array list using user input

            Console.WriteLine("Enter water and lights costs: ");
            waterLights = Convert.ToDouble(Console.ReadLine());
            expensesList.Add(waterLights);

            Console.WriteLine("Enter travel costs: ");
            travel = Convert.ToDouble(Console.ReadLine());
            expensesList.Add(travel);

            Console.WriteLine("Enter celllphone and/or telephone costs: ");
            phone = Convert.ToDouble(Console.ReadLine());
            expensesList.Add(phone);

            Console.WriteLine("Enter any other extra costs: ");
            extras = Convert.ToDouble(Console.ReadLine());
            expensesList.Add(extras);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            // variable to hold total amount of all instances in the list of T "expensesList"
            totalExpenses = Math.Round(expensesList.Sum());
            Console.ForegroundColor = ConsoleColor.White;
        }

        // abstract method
        public abstract void input();

    }
}
