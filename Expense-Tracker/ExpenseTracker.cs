using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Tracker
{
    public class ExpenseTracker
    {
        public List<Expense> Expenses { get; set; }

        // RecycledIDs are the IDs of deleted expense objects, these IDs should be used for creating new expense objects
        // before using any new ID
        public List<int> RecycledIDs { get; set; }

        public ExpenseTracker()
        {
            Expenses = new List<Expense>();
            RecycledIDs = new List<int>();
        }

        // Get the next appropriate ID, if RecycledIDs list is empty, simply use ( number of expense objects + 1) as the next ID
        public int getNextId()
        {
            if (RecycledIDs.Count == 0)
            {
                return Expenses.Count + 1;
            }
            else
            {
                int nextId = RecycledIDs[0];
                RecycledIDs.RemoveAt(0);
                return nextId;
            }
        }

        public bool AddExpense(string description, double amount)
        {
            return false;
        }

        public bool UpdateExpense(int id, double amount)
        {
            return false;
        }

        public bool DeleteExpense(int id)
        {
            return false;
        }

        public string Summary()
        {
            return "";
        }

        public string Summary(int month)
        {
            return "";
        }

    }
}
