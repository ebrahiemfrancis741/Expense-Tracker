
using System.Collections;

namespace Expense_Tracker
{
    public class ExpenseTrackerApp
    {
        private static void PrintExpenses(List<Expense> expenseList)
        {
            foreach (Expense e in expenseList)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        // checks if the correct number of arguments are given for the specified
        // operation
        private static bool IsValidArgsCount(string[] args)
        {
            if (args.Length >= 1)
            {
                switch (args[0])
                {
                    case "list":
                        if (args.Length == 1)
                        {
                            return true;
                        }
                        break;
                    case "summary":
                        if (args.Length == 1)
                        {
                            return true;
                        }
                        break;
                    case "add":
                        if (args.Length == 5)
                        {
                            return true;
                        }
                        break;
                    case "update":
                        if (args.Length == 5)
                        {
                            return true;
                        }
                        break;
                    case "delete":
                        if (args.Length == 3)
                        {
                            return true;
                        }
                        break;
                    default:
                        return false;
                }
            }
            return false;
        }



        static void Main(string[] args)
        {
            ExpenseTracker expenseTracker = new ExpenseTracker();
            expenseTracker.AddExpense("food", 1000.0);
            expenseTracker.AddExpense("clothes", 2000.0);
            expenseTracker.AddExpense("coffee", 500.0);
            PrintExpenses(expenseTracker.Expenses);

            expenseTracker.DeleteExpense(2);
            PrintExpenses(expenseTracker.Expenses);

            expenseTracker.AddExpense("internet", 500.0);
            expenseTracker.AddExpense("water", 700.0);
            PrintExpenses(expenseTracker.Expenses);

            expenseTracker.UpdateExpense(1, 2000.0);
            PrintExpenses(expenseTracker.Expenses);

            Console.WriteLine("Total expenses: $" + expenseTracker.Summary(1));
        }
    }
}