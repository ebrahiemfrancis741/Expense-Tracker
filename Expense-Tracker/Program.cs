
namespace Expense_Tracker
{
    public class ExpenseTrackerApp
    {
        static void printExpenses(List<Expense> expenseList)
        {
            foreach (Expense e in expenseList)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ExpenseTracker expenseTracker = new ExpenseTracker();
            expenseTracker.AddExpense("food", 1000.0);
            expenseTracker.AddExpense("clothes", 2000.0);
            expenseTracker.AddExpense("coffee", 500.0);
            printExpenses(expenseTracker.Expenses);

            expenseTracker.DeleteExpense(2);
            printExpenses(expenseTracker.Expenses);

            expenseTracker.AddExpense("internet", 500.0);
            expenseTracker.AddExpense("water", 700.0);
            printExpenses(expenseTracker.Expenses);

        }
    }
}