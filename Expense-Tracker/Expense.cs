using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Tracker
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Expense(int id, string description, double amount, DateTime date)
        {
            this.Id = id;
            this.Description = description;
            this.Amount = amount;
            this.Date = date;
        }

        public override string ToString()
        {
            return  Id + "              " + Date + "            " + Description + "                 " + Amount;
        }
    }
}
