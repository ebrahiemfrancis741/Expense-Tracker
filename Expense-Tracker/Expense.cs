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
        public DateOnly Date {  get; set; }


    }
}
